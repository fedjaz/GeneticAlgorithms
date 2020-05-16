using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithms
{
    public class GenerationEventArgs : EventArgs
    {
        public int GenerationNumber { get; set; }
        public double Fitness { get; set; }
        public double MeanScore { get; set; }

        public GenerationEventArgs(int generationNumber, double fitness, double meanScore)
        {
            GenerationNumber = generationNumber;
            Fitness = fitness;
            MeanScore = meanScore;
        }
    }
}
