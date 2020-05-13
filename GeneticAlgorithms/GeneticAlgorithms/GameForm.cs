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
    public partial class GameForm : FlatForm
    {
        Game game;
        Form parent;
        public GameForm(Form parent, Game game)
        {
            InitializeComponent();
            this.parent = parent;
            ConfigureGame(game);
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
            if(game.IsDead)
            {
                GameBox.Paint -= game.PaintOnControl;
                KeyDown -= game.RecieveKey;
                ConfigureGame(game.Clone() as Game);
            }
            if(game.IsActive)
            {
                game.Tick();
            }
            GameBox.Invalidate();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
