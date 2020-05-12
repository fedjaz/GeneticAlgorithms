using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    public abstract class Game : ICloneable
    {
        public Size ControlSize { get; set; }
        public double Speed { get; set; }
        public bool IsActive { get; set; }
        public bool IsDead { get; set; }
        public Dictionary<int, Keys> PredictionsMapping { get; private set; }
        public abstract void RecieveKey(object sender, KeyEventArgs args);
        public abstract void Tick();
        public abstract void PaintOnControl(object sender, PaintEventArgs args);
        public abstract void SetDefaultOptions();
        public abstract Matrix<double> GetFeatures();
        public abstract double GetFitness();
        public abstract object Clone();
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
