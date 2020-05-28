using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    public partial class TrainingForm : FlatForm
    {
        Form parent;
        Thread thread;
        Model model;
        List<double> scoreHistory;
        float posX = 15, posY = 15;
        float scale = 1;
        float lastPosX, lastPosY;
        bool isDown;
        public TrainingForm(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
            VisualizationBox.MouseWheel += (obj, e) =>
            {
                scale += e.Delta * 0.00075f;
                VisualizationBox.Invalidate();
            };
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            int generationSize, proceedToNext, generations, maxScore, gamesToPlay;
            double mutationProbability, mutationRate;
            if(!int.TryParse(GenerationSize.Text, out generationSize) || generationSize < 1)
            {
                MessageBox.Show("Generation size must be positive integer.");
                return;
            }
            if(!int.TryParse(ProceedToNext.Text, out proceedToNext) || proceedToNext < 1)
            {
                MessageBox.Show("Proceed to next size must be positive integer.");
                return;
            }
            if(!int.TryParse(GenerationsCount.Text, out generations) || generations < 1)
            {
                MessageBox.Show("Maximum count of generations must be positive integer.");
                return;
            }
            if(!int.TryParse(MaxScore.Text, out maxScore) || maxScore < 1)
            {
                MessageBox.Show("Maximum score must be positive integer.");
                return;
            }
            if(!int.TryParse(GamesToPlay.Text, out gamesToPlay) || gamesToPlay < 1)
            {
                MessageBox.Show("Games to play must be positive integer.");
                return;
            }
            if(!double.TryParse(MutationProbability.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out mutationProbability) || mutationProbability <= 0 || mutationProbability > 1)
            {
                MessageBox.Show("Mutation probability must be value between 0 and 1.");
                return;
            }
            if(!double.TryParse(MutationRate.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out mutationRate) || mutationRate <= 0)
            {
                MessageBox.Show("Mutation rate must be positive value");
                return;
            }
            string[] splittedNeurons = HiddenNeurons.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> hiddenNeurons;
            try
            {
                hiddenNeurons = splittedNeurons.Select(x => int.Parse(x)).ToList();
                hiddenNeurons.ForEach(x =>
                {
                    if(x < 1)
                    {
                        MessageBox.Show("Neurons count in hidden layers must be positive integer");
                        return;
                    }
                });
            }
            catch
            {
                MessageBox.Show("Neurons count in hidden layers must be positive integer");
                return;
            }
            scoreHistory = new List<double>();
            GenerationProgress.Maximum = generationSize;
            Random r = new Random();
            Model defaultModel;
            Game etalonGame;
            if(GamesComboBox.SelectedItem == GamesComboBox.Items[0])
            {
                defaultModel = new Model(new NeuralNetwork(4, hiddenNeurons, 1, r), Model.Games.FlappyBird);
                etalonGame = new FlappyBird(1, r, false);
            }
            else
            {
                MessageBox.Show("Other games are not done yet.");
                return;
            }
            etalonGame.ControlSize = GameForm.ControlSize;
            etalonGame.SetDefaultOptions();
            Trainer trainer = new Trainer(defaultModel, etalonGame, generationSize,
                                          proceedToNext, generations, maxScore,
                                          gamesToPlay, mutationProbability, mutationRate, r);
            trainer.ModelTested += (obj, value) =>
            {
                GenerationProgress.Invoke((MethodInvoker)(() =>
                {
                    GenerationProgress.Value = value;
                }));
            };
            trainer.GenerationPassed += GenerationPassed;
            TrainButton.Enabled = false;
            TrainingParameters.Enabled = false;
            thread = new Thread(() => Train(trainer));
            thread.Start();
        }

        void Train(Trainer trainer)
        {
            model = trainer.Train();
            Invoke((MethodInvoker)(() =>
            {
                SaveButton.Enabled = true;
                TrainingParameters.Enabled = true;
                TrainButton.Enabled = true;
            }));
        }

        void GenerationPassed(object sender, GenerationEventArgs args)
        {
            scoreHistory.Add(args.Model.MeanScore);
            model = args.Model;
            Invoke((MethodInvoker)(() =>
            {
                richTextBox1.AppendText($"Generation {args.GenerationNumber}. Best fitness - {args.Model.Fitness}, best mean score - {args.Model.MeanScore}\n");
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                GraphsBox.Invalidate();
                VisualizationBox.Invalidate();
            }));
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            GamesComboBox.SelectedItem = GamesComboBox.Items[0];
        }

        private void TrainingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread?.Abort();
            parent.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string JSON = JsonConvert.SerializeObject(model);
                using(StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(JSON);
                }
            }    
        }

        private void GraphsBox_Paint(object sender, PaintEventArgs e)
        {
            if(scoreHistory == null || scoreHistory.Count < 2)
            {
                return;
            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float startX = GraphsBox.Width * 0.1f, startY = GraphsBox.Height * 0.1f;
            float endX = GraphsBox.Width - startX, endY = GraphsBox.Height - startY;
            List<PointF> lines = new List<PointF>();
            double maxVal = scoreHistory.Max();
            for(int i = 0; i < scoreHistory.Count; i++)
            {
                float x = startX + (endX - startX) / (scoreHistory.Count - 1) * i;
                float y;
                if(maxVal == 0)
                {
                    y = endY;
                }
                else
                {
                    y = (float)(GraphsBox.Height - (startY + (endY - startY) / maxVal * scoreHistory[i]));
                }
                lines.Add(new PointF(x, y));
            }
            e.Graphics.DrawLine(new Pen(Color.White, 4), startX, endY, startX, startY);
            e.Graphics.DrawLine(new Pen(Color.White, 4), startX, endY, endX, endY);
            Font font = new Font(Font.Name, 15, Font.Style);
            SizeF ySize = e.Graphics.MeasureString(maxVal.ToString(), font);
            SizeF xSize = e.Graphics.MeasureString(scoreHistory.Count.ToString(), font);
            SizeF zeroSize = e.Graphics.MeasureString("0", font);
            e.Graphics.DrawString(maxVal.ToString(), font, new SolidBrush(Color.White), new PointF(startX - ySize.Width, startY));
            e.Graphics.DrawString(scoreHistory.Count.ToString(), font, new SolidBrush(Color.White), new PointF(endX - xSize.Width, endY));
            e.Graphics.DrawString("0", font, new SolidBrush(Color.White), new PointF(startX - zeroSize.Width, endY));
            e.Graphics.DrawLines(new Pen(Color.Green, 4), lines.ToArray());
        }

        private void VisualizationBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            lastPosX = e.X;
            lastPosY =  e.Y;
        }

        private void VisualizationBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void VisualizationBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(!isDown)
            {
                return;
            }
            posX += (e.X - lastPosX);
            posY += (e.Y - lastPosY);
            lastPosX = e.X;
            lastPosY = e.Y;
            VisualizationBox.Invalidate();
        }

        private void VisualizationBox_Paint(object sender, PaintEventArgs e)
        {
            if(model == null)
            {
                return;
            }
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            float rad = 25 * scale;
            float center = VisualizationBox.Height / 2 * scale;
            float startPos = 50 * scale;
            List<List<PointF>> layers = new List<List<PointF>>();
            foreach(Matrix<double> layer in model.NeuralNetwork.HiddenLayers)
            {
                layers.Add(GetPoints(layer.Rows, center, rad, startPos));
                startPos += rad * 3;
            }
            layers.Add(GetPoints(model.NeuralNetwork.OutputLayer.Rows, center, rad, startPos));
            startPos += rad * 3;
            layers.Add(GetPoints(model.NeuralNetwork.OutputLayer.Cells, center, rad, startPos));

            for(int layer = layers.Count - 1; layer > 0; layer--)
            {
                Matrix<double> cur;
                if(layer == layers.Count - 1)
                {
                    cur = model.NeuralNetwork.OutputLayer;
                }
                else
                {
                    cur = model.NeuralNetwork.HiddenLayers[layer - 1];
                }
                for(int i = 0; i < layers[layer].Count; i++)
                {
                    for(int j = 0; j < layers[layer - 1].Count; j++)
                    {
                        double weight = cur[j, i];
                        Color color;
                        if(weight >= 0)
                        {
                            weight = Math.Min(Math.Abs(weight), 1);
                            color = Color.FromArgb(127 + (int)(weight * 128), 0, 0);
                        }
                        else
                        {
                            weight = Math.Min(Math.Abs(weight), 1);
                            color = Color.FromArgb(0, 0, 127 + (int)(weight * 128));
                        }
                        PointF point1 = new PointF(layers[layer][i].X + posX, layers[layer][i].Y + posY);
                        PointF point2 = new PointF(layers[layer - 1][j].X + posX, layers[layer - 1][j].Y + posY);
                        e.Graphics.DrawLine(new Pen(color, 1), point1, point2);
                    }
                }
            }
            foreach(List<PointF> layer in layers)
            {
                foreach(PointF point in layer)
                {
                    e.Graphics.FillEllipse(new SolidBrush(Color.White), point.X + posX - rad / 2, point.Y + posY - rad / 2, rad, rad);
                }
            }
        }

        List<PointF> GetPoints(int count, float center, float rad, float startPosX)
        {
            List<PointF> points = new List<PointF>();
            for(int i = 0; i < count; i++)
            {
                points.Add(new PointF(startPosX, (rad + rad * 0.5f) * i));
            }
            float delta;
            if(count % 2 == 0)
            {
                delta = center - (points[count / 2 - 1].Y + points[count / 2].Y) / 2;
            }
            else
            {
                delta = center - points[count / 2].Y;
            }
            for(int i = 0; i < count; i++)
            {
                points[i] = new PointF(points[i].X, VisualizationBox.Height -(points[i].Y + delta));
            }
            return points;
        }
    }
}
