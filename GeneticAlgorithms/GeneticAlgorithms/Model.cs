using Newtonsoft.Json;
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
            Other
        }

        public NeuralNetwork NeuralNetwork { get; set; }
        public Games GameType { get; }
        public double Fitness { get; set;  }
        public double MeanScore { get; set; }


        public Model(NeuralNetwork neuralNetwork, Games game)
        {
            this.NeuralNetwork = neuralNetwork;
            GameType = game;
        }

        public void Predict(Game game)
        {
            Matrix<double> prediction = NeuralNetwork.Predict(game.GetFeatures());
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
                newGame.IsActive = true;
                newGame.IsDead = false;
                while(!newGame.IsDead && newGame.GetScore() < maxScore)
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
            foreach(Matrix<double> layer in mutated.NeuralNetwork.HiddenLayers)
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
            for(int i = 0; i < mutated.NeuralNetwork.OutputLayer.Rows; i++)
            {
                for(int j = 0; j < mutated.NeuralNetwork.OutputLayer.Cells; j++)
                {
                    if((double)r.Next(0, 10001) / 1000 <= mutationProbability)
                    {
                        mutated.NeuralNetwork.OutputLayer[i, j] += (double)r.Next(-1000, 10001) / 1000 * mutationRate;
                    }
                }
            }
            for(int i = 0; i < mutated.NeuralNetwork.OutputLayer.Cells; i++)
            {
                if((double)r.Next(0, 10001) / 1000 <= mutationProbability)
                {
                    mutated.NeuralNetwork.OutputLayer[0, i] += (double)r.Next(-1000, 10001) / 1000 * mutationRate;
                }

            }
            return mutated;
        }

        public void Reset(Random r)
        {
            for(int i = 0; i < NeuralNetwork.HiddenLayers.Count; i++)
            {
                NeuralNetwork.HiddenLayers[i] = new Matrix<double>(NeuralNetwork.HiddenLayers[i].Rows,
                                                                   NeuralNetwork.HiddenLayers[i].Cells,
                                                                   () => (double)r.Next(-1000, 1001) / 1000);
            }
            NeuralNetwork.OutputLayer = new Matrix<double>(NeuralNetwork.OutputLayer.Rows,
                                                           NeuralNetwork.OutputLayer.Cells,
                                                           () => (double)r.Next(-1000, 1001) / 1000);
            NeuralNetwork.Bias = new Matrix<double>(NeuralNetwork.Bias.Rows, NeuralNetwork.Bias.Cells,
                                                    () => (double)r.Next(-1000, 1001) / 1000);
        }

        public object Clone()
        {
            return new Model(NeuralNetwork.Clone() as NeuralNetwork, GameType);
        }
    }
}
