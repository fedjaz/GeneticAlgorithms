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
    public partial class MainMenuForm : FlatForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        public void StartGame(Game game, string path)
        {
            Model defaultModel;
            
            try
            {
                string JSON;
                using(StreamReader sr = new StreamReader(path))
                {
                    JSON = sr.ReadToEnd();
                }
                defaultModel = JsonConvert.DeserializeObject<Model>(JSON);
            }
            catch
            {
                defaultModel = null;
            }
            GameForm gameForm = new GameForm(this, game, defaultModel);
            gameForm.Visible = true;
            Visible = false;
        }

        private void BreakoutButton_Click(object sender, EventArgs e)
        {

        }

        private void FlappyBirdButton_Click(object sender, EventArgs e)
        {
            StartGame(new FlappyBird(0.5, new Random(), true), @"../../../../Default Models/FlappyBird.model");
        }

        private void DinoButton_Click(object sender, EventArgs e)
        {

        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            TrainingForm trainingForm = new TrainingForm(this);
            trainingForm.Visible = true;
            Visible = false;
        }
    }
}
