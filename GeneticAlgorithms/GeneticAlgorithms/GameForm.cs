using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    public partial class GameForm : FlatForm
    {
        Game game;
        Form parent;
        public static Size ControlSize = new Size(1000, 500);
        Model loadedModel;
        public GameForm(Form parent, Game game, Model defaultModel)
        {
            InitializeComponent();
            GameBox.Size = ControlSize;
            this.parent = parent;
            ConfigureGame(game);
            SetModel(defaultModel, "default model");
        }

        void ConfigureGame(Game game)
        {
            this.game = game;
            game.ControlSize = GameBox.Size;
            GameBox.Paint += game.PaintOnControl;
            KeyDown += game.RecieveKey;
            game.SetDefaultOptions();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadButton.Enabled = !game.IsActive;
            if(game.IsDead && !game.IsActive)
            {
                GameBox.Paint -= game.PaintOnControl;
                KeyDown -= game.RecieveKey;
                ConfigureGame(game.Clone() as Game);
            }
            if(game.IsActive)
            {
                game.Tick();
                Matrix<double> features = game.GetFeatures();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("======Features======");
                for(int i = 0; i < features.Cells; i++)
                {
                    sb.AppendLine($"{features[0, i]}");
                }
                InfoBox.Text = sb.ToString();
                if(checkBox1.Checked && loadedModel != null)
                {
                    loadedModel.Predict(game);
                }
            }
            GameBox.Invalidate();
        }

        void SetModel(Model newModel, string modelName)
        {
            if(newModel == null || 
              (newModel.GameType != Model.Games.FlappyBird && game is FlappyBird) /*||
              (newModel.GameType == Model.Games.Dino && game is Dino) ||
              (newModel.GameType == Model.Games.Breakout && game is Breakout)*/)
            {
                ModelStatus.Visible = true;
                ModelStatus.Text = "This model is damaged or incompatible with this game!";
                ModelStatus.ForeColor = Color.Red;
            }
            else
            {
                AverageScore.Text = $"Average score: {newModel.MeanScore}"; 
                ModelName.Text = $"Model name: {modelName}";
                if(newModel.GameType == Model.Games.FlappyBird)
                {
                    CompatibleGame.Text = "Compatible game: Flappy bird";
                }
                if(newModel.GameType == Model.Games.Dino)
                {
                    CompatibleGame.Text = "Compatible game: Dino";
                }
                if(newModel.GameType == Model.Games.Breakout)
                {
                    CompatibleGame.Text = "Compatible game: Breakout";
                }
                ModelStatus.Visible = true;
                ModelStatus.Text = "Model is ready.";
                ModelStatus.ForeColor = Color.White;
                loadedModel = newModel;
            }
        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked && loadedModel == null)
            {
                MessageBox.Show("Model is not set.");
                checkBox1.Checked = false;
            }
            GameBox.Focus();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Model model;
                    string JSON;
                    using(StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        JSON = sr.ReadToEnd();
                    }
                    model = JsonConvert.DeserializeObject<Model>(JSON);
                    SetModel(model, openFileDialog1.SafeFileName.Split(new char[] { '.' }).First());
                }
                catch
                {
                    SetModel(null, null);
                }
            }
        }
    }
}
