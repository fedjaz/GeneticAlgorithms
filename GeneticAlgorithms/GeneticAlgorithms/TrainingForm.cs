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
    public partial class TrainingForm : FlatForm
    {
        Form parent;
        public TrainingForm(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            GenerationProgress.Maximum = 1000;
            Trainer trainer = new Trainer();
            trainer.ModelTested += (obj, value) =>
            {
                GenerationProgress.Invoke((MethodInvoker)(() =>
                {
                    GenerationProgress.Value = value;
                }));
            };
            trainer.GenerationPassed += (obj, args) =>
            {
                richTextBox1.Invoke((MethodInvoker)(() => 
                {
                    richTextBox1.AppendText($"Generation {args.GenerationNumber}. Best fitness - {args.Fitness}, best mean score - {args.MeanScore}\n");
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                }));
            };
            Random r = new Random();
            Model defaultModel = new Model(new NeuralNetwork(4, new int[] { 8}, 1, r), Model.Games.FlappyBird);
            Game etalonGame = new FlappyBird(1, r, false);
            etalonGame.ControlSize = GameForm.ControlSize;
            etalonGame.SetDefaultOptions();
            Model result;
            Task.Factory.StartNew(() =>
            {
                result = trainer.Train(defaultModel, etalonGame, 1000, 20, 200, 1000, 10, 0.4, 0.25, r);
                string Json = JsonConvert.SerializeObject(result);
                using(StreamWriter sw = new StreamWriter("default.model"))
                {
                    sw.Write(Json);
                };
            });
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            Games.SelectedItem = Games.Items[0];
        }

        private void TrainingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
