using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithms
{
    public class Trainer
    {
        public event EventHandler<int> ModelTested;
        public event EventHandler<GenerationEventArgs> GenerationPassed;
        public Model Train(Model defaultModel, Game etalonGame,
                                  int generationSize, int proceedToNext,
                                  int maxGenerations, int maxScore, int gamesToPlay,
                                  double mutationProbability, double mutationRate, Random r)
        {
            List<Model> models = new List<Model>();
            for(int i = 0; i < generationSize; i++)
            {
                Model newModel = defaultModel.Clone() as Model;
                newModel.Reset(r);
                models.Add(newModel);
            }
            for(int generation = 0; generation < maxGenerations; generation++)
            {
                for(int i = 0; i < models.Count; i++)
                {
                    models[i].Test(etalonGame, gamesToPlay, maxScore);
                    ModelTested?.Invoke(this, i);
                }
                models.Sort((x, y) => y.Fitness.CompareTo(x.Fitness));
                List<Model> newGeneration = models.GetRange(0, proceedToNext);
                int newCopies = (int)Math.Ceiling((double)(generationSize - proceedToNext) / proceedToNext);
                for(int i = 0; i < proceedToNext; i++)
                {
                    newCopies = Math.Min(newCopies, generationSize - newGeneration.Count);
                    for(int j = 0; j < newCopies; j++)
                    {
                        newGeneration.Add(newGeneration[i].Mutate(mutationRate, mutationProbability, r));
                    }
                }
                GenerationPassed?.Invoke(this, new GenerationEventArgs(generation + 1,
                                               newGeneration[0].Fitness,
                                               newGeneration[0].MeanScore));
                if(newGeneration[0].MeanScore == maxScore)
                {
                    return newGeneration[0];
                }
                models = newGeneration;
            }
            return models[0];
        }
    }
}
