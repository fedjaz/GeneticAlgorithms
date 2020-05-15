using System;
using System.Configuration;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithms
{
    public class NeuralNetwork : ICloneable
    {
        public List<Matrix<double>> HiddenLayers { get; set; }
        public Matrix<double> OutputLayer { get; set; }
        public Matrix<double> Bias { get; set; }
        int inputSize;

        public NeuralNetwork()
        {

        }

        public NeuralNetwork(int input, IEnumerable<int> hidden, int output, Random r)
        {
            inputSize = input;
            int lastSize = input;
            HiddenLayers = new List<Matrix<double>>();
            foreach(int s in hidden)
            {
                lastSize = s;
                HiddenLayers.Add(new Matrix<double>(lastSize, s, () => (double)r.Next(-1000, 1001) / 1000));
            }
            OutputLayer = new Matrix<double>(lastSize, output, () => (double)r.Next(-1000, 1001) / 1000);
            Bias = new Matrix<double>(1, output, () => (double)r.Next(-1000, 1001) / 1000);
        }

        public NeuralNetwork(List<Matrix<double>> hiddenLayers, Matrix<double> outputLayer, Matrix<double> bias)
        {
            HiddenLayers = hiddenLayers;
            OutputLayer = outputLayer;
            Bias = bias;
        }

        public static Matrix<double> Relu(Matrix<double> input)
        {
            Matrix<double> ans = input.Clone() as Matrix<double>;
            for(int i = 0; i < input.Rows; i++)
            {
                for(int j = 0; j < input.Cells; j++)
                {
                    ans[i, j] = Math.Max(0, ans[i, j]);
                }
            }
            return ans;
        }

        public static Matrix<double> Sigmoid(Matrix<double> input)
        {
            Matrix<double> ans = input.Clone() as Matrix<double>;
            for (int i = 0; i < input.Rows; i++)
            {
                for (int j = 0; j < input.Cells; j++)
                {
                    ans[i, j] = 1 / (1 + Math.Exp(-ans[i, j]));
                }
            }
            return ans;
        }
        public Matrix<double> Predict(Matrix<double> input)
        {
            foreach(Matrix<double> h in HiddenLayers)
            {
                input *= h;
                input = Relu(input);
            }
            return Sigmoid(input * OutputLayer + Bias);
        }

        public object Clone()
        {
            List<Matrix<double>> hidden = new List<Matrix<double>>();
            foreach(Matrix<double> layer in HiddenLayers)
            {
                hidden.Add(layer.Clone() as Matrix<double>);
            }
            return new NeuralNetwork(hidden, OutputLayer.Clone() as Matrix<double>,
                                     Bias.Clone() as Matrix<double>);
        }
    }
}
