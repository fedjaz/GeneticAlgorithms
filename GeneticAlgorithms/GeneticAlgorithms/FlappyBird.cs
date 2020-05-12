using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    public class FlappyBird : Game
    {
        double posY, posX;
        double minPosY, maxPosY;
        int score;
        double velocity;
        double rad;
        double pipeWidth, pipeHeight;
        List<PointF> pipes;
        int lastAddScore = 0;
        double pipeSpacing;
        Random r;
        public FlappyBird(double speed, Random r) : base(speed)
        {
            IsDead = false;
            this.r = r;
        }

        public override void SetDefaultOptions()
        {
            if(ControlSize == null)
            {
                throw new InvalidOperationException("Control doesn't set.");
            }

            posY = ControlSize.Height / 2;
            rad = 20;
            minPosY = 10;
            maxPosY = ControlSize.Height + 50;
            pipeWidth = 60;
            pipeHeight = 75;
            pipeSpacing = 250;
        }

        public override void Tick()
        {
            if(!IsActive || IsDead)
            {
                return;
            }
            for(int i = 0; i < Math.Abs(velocity); i++)
            {
                posY += Speed * (Math.Abs(velocity) / velocity);
                CalculateCollisions();
            }
            
            posX += Speed * 5;
            if(velocity >= -10)
                velocity -= Speed;

            CalculateCollisions();

            if(posX > pipes[score].X + pipeWidth / 2)
                score++;

            if(score % 5 == 0 && score >= 10 && lastAddScore != score)
            {
                pipes.AddRange(GetPipes(5, pipes.Last().X));
                lastAddScore = score;
            }
        }

        public override void PaintOnControl(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), 0, 0, ControlSize.Width, ControlSize.Height);
            if(pipes != null)
            {
                for(int i = Math.Max(0, score - 5); i < score + 5; i++)
                {
                    PointF p = pipes[i];
                    float x = p.X - (float)posX + ControlSize.Width / 2;
                    e.Graphics.FillRectangle(new SolidBrush(Color.Green), x, ControlSize.Height - p.Y, (float)pipeWidth, ControlSize.Height);
                    e.Graphics.FillRectangle(new SolidBrush(Color.Green), x, -p.Y - (float)pipeHeight, (float)pipeWidth, ControlSize.Height);
                }
            }
            RectangleF rect = new RectangleF((float)(ControlSize.Width / 2 - rad), (float)(ControlSize.Height - posY - rad / 2), (float)rad, (float)rad);
            e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), rect);
            e.Graphics.DrawString(score.ToString(), new Font("Lobster", 16), new SolidBrush(Color.White), 20, 20);
        }

        public override void RecieveKey(object sender, KeyEventArgs args)
        {
            if(IsDead)
            {
                return;
            }
            if(args.KeyCode == Keys.Space)
            {
                if(!IsActive)
                {
                    pipes = GetPipes(20, ControlSize.Width / 2);
                    IsActive = true;
                }
                Up();
            }
        }

        public override double GetFitness()
        {
            return posX;
        }

        public override Matrix<double> GetFeatures()
        {
            Matrix<double> output = new Matrix<double>(1, 4);
            output[0, 0] = posY / maxPosY;
            PointF pipe = pipes[score];
            PointF nextPipe = pipes[score + 1];
            if(score > 0 && pipes[score - 1].X + pipeWidth + rad > posX)
            {
                pipe = pipes[score - 1];
                nextPipe = pipes[score];
            }

            output[0, 0] = velocity / 10;
            output[0, 1] = (pipe.X + pipeWidth + rad / 2 - posX) / pipeSpacing;
            output[0, 2] = (posY - pipe.Y) / maxPosY;
            output[0, 3] = (pipe.Y - nextPipe.Y) / maxPosY;

            return output;
        }

        public override object Clone()
        {
            Game game = new FlappyBird(Speed, r) 
            {
                ControlSize = ControlSize,
                posY = posY,
                rad = rad,
                minPosY = minPosY,
                maxPosY = maxPosY,
                pipeWidth = pipeWidth,
                pipeHeight = pipeHeight,
                pipeSpacing = pipeSpacing
            };
            return game;
        }

        void CalculateCollisions()
        {
            if(posY < minPosY)
            {
                IsActive = false;
                IsDead = true;
            }

            RectangleF player = new RectangleF((float)(posX - rad / 2), (float)(posY - rad / 2), (float)rad, (float)rad);
            RectangleF curDown = new RectangleF(pipes[score].X, 0, (float)pipeWidth, pipes[score].Y);
            RectangleF prevDown = new RectangleF(pipes[Math.Max(0, score - 1)].X, 0, (float)pipeWidth, pipes[Math.Max(0, score - 1)].Y);
            RectangleF curUp = new RectangleF(pipes[score].X, pipes[score].Y + (float)pipeHeight, (float)pipeWidth, (float)maxPosY);
            RectangleF prevUp = new RectangleF(pipes[Math.Max(0, score - 1)].X, pipes[Math.Max(0, score - 1)].Y + (float)pipeHeight, (float)pipeWidth, (float)maxPosY);
            if(curDown.IntersectsWith(player) || prevDown.IntersectsWith(player) ||
                curUp.IntersectsWith(player) || prevUp.IntersectsWith(player))
            {
                IsActive = false;
                IsDead = true;
            }
        }

        public void Up()
        {
            if(posY < maxPosY)
                velocity = 8;
        }

        List<PointF> GetPipes(int n, float startPos)
        {
            List<PointF> ans = new List<PointF>();
            ans.Add(new PointF(startPos + (float)pipeSpacing, r.Next((int)minPosY + 100, (int)maxPosY - 150)));
            for(int i = 1; i < n; i++)
            {
                ans.Add(new PointF(ans.Last().X + (float)pipeSpacing, r.Next((int)minPosY + 100, (int)maxPosY - 150)));
            }
            return ans;
        }
    }
}
