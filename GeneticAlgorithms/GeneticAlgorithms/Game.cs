using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    public abstract class Game
    {
        public Control Control { get; set; }
        public double Speed { get; set; }
        public bool IsActive { get; set; }
        public Dictionary<int, Keys> PredictionsToKeys { get; private set; }
        public abstract void RecieveKey(object sender, KeyEventArgs args);
        public abstract void Tick();
        public abstract Matrix<double> GetFeatures();
        public abstract double GetFitness();
        public enum Options
        {
            Default,
            Other
        }

        public Game(double speed)
        {
            Speed = speed;
        }
    }
}
