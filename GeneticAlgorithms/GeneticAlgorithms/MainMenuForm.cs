using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            GameForm gameForm = new GameForm(this, game);
            gameForm.Visible = true;
            Visible = false;
        }

        private void BreakoutButton_Click(object sender, EventArgs e)
        {

        }

        private void FlappyBirdButton_Click(object sender, EventArgs e)
        {
            StartGame(new FlappyBird(0.5, new Random()));
        }

        private void DinoButton_Click(object sender, EventArgs e)
        {

        }

        private void TrainButton_Click(object sender, EventArgs e)
        {

        }
    }
}
