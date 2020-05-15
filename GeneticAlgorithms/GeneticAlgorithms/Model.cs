using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    public class Model : ICloneable
    {
        public enum Games
        {
            FlappyBird,
            Dino,
            Breakout,
            Other
        }

        NeuralNetwork neuralNetwork;
        public Games GameType { get; }
        public double Fitness { get; private set;  }
        public double MeanScore { get; private set; }

        public Model(NeuralNetwork neuralNetwork, Games game)
        {
            this.neuralNetwork = neuralNetwork;
            GameType = game;
        }

        public void Predict(Game game)
        {
            Matrix<double> prediction = neuralNetwork.Predict(game.GetFeatures());
            for(int i = 0; i < prediction.Cells; i++)
            {
                if(prediction[0, i] >= 0.5)
                {
                    game.RecieveKey(this, new KeyEventArgs(game.KeysMap[i]));
                }
            }
        }

        public double Test(Game etalonGame, int gamesCount, int maxScore)
        {
            double fitness = 0;
            double meanScore = 0;
            for(int i = 0; i < gamesCount; i++)
            {
                Game newGame = etalonGame.Clone() as Game;
                while(!newGame.IsDead && newGame.GetScore() <= maxScore)
                {
                    newGame.Tick();
                    Predict(newGame);
                }
                fitness += newGame.GetFitness();
                meanScore += newGame.GetScore();
            }
            Fitness = fitness / gamesCount;
            MeanScore = meanScore / gamesCount;
            return Fitness;
        }

        public Model Mutate(double mutationRate, double mutationProbability, Random r)
        {
            Model mutated = Clone() as Model;
            foreach(Matrix<double> layer in mutated.neuralNetwork.HiddenLayers)
            {
                for(int i = 0; i < layer.Rows; i++)
                {
                    for(int j = 0; j < layer.Cells; j++)
                    {
                        if((double)r.Next(0, 10001) / 1000 <= mutationProbability)
                        {
                            layer[i, j] += (double)r.Next(-1000, 10001) / 1000 * mutationRate;
                        }
                    }
                }
            }
            for(int i = 0; i < mutated.neuralNetwork.OutputLayer.Rows; i++)
            {
                for(int j = 0; j < mutated.neuralNetwork.OutputLayer.Cells; j++)
                {
                    if((double)r.Next(0, 10001) / 1000 <= mutationProbability)
                    {
                        mutated.neuralNetwork.OutputLayer[i, j] += (double)r.Next(-1000, 10001) / 1000 * mutationRate;
                    }
                }
            }
            for(int i = 0; i < mutated.neuralNetwork.OutputLayer.Cells; i++)
            {
                if((double)r.Next(0, 10001) / 1000 <= mutationProbability)
                {
                    mutated.neuralNetwork.OutputLayer[0, i] += (double)r.Next(-1000, 10001) / 1000 * mutationRate;
                }

            }
            return mutated;
        }

        public object Clone()
        {
            return new Model(neuralNetwork.Clone() as NeuralNetwork, GameType);
        }
    }
}
