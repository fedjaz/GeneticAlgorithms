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
        public int GenerationNumber { get; }
        public Model Model { get; }

        public GenerationEventArgs(int generationNumber, Model model)
        {
            GenerationNumber = generationNumber;
            Model = model;
        }
    }
}
