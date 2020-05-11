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
    public partial class MainMenuForm : Form
    {

        bool isDown;
        int lastPosY = -1, lastPosX = -1;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            lastPosY = e.Y;
            lastPosX = e.X;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(!isDown)
            {
                return;
            }
            int deltaX = e.X - lastPosX;
            int deltaY = e.Y - lastPosY;
            Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }
    }
}
