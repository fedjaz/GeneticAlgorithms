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

        public void StartGame(Game game)
        {
            string JSON;
            using(StreamReader sr = new StreamReader("default.model"))
            {
                JSON = sr.ReadToEnd();
            }
            GameForm gameForm = new GameForm(this, game, JsonConvert.DeserializeObject<Model>(JSON));
            gameForm.Visible = true;
            Visible = false;
        }

        private void BreakoutButton_Click(object sender, EventArgs e)
        {

        }

        private void FlappyBirdButton_Click(object sender, EventArgs e)
        {
            StartGame(new FlappyBird(0.5, new Random(), true));
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
