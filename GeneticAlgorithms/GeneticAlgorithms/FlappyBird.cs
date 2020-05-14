using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        int ticks = 0;
        double pipeSpacing;
        double firstGroundPos;
        Random r;
        Bitmap downPipe, upPipe, ground;
        Bitmap bird1, bird2, bird3, prevBird, curBird;
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
            rad = 25;
            minPosY = 50;
            maxPosY = ControlSize.Height + 50;
            pipeWidth = 60;
            pipeHeight = 100;
            pipeSpacing = 200;
            firstGroundPos = -ControlSize.Width / 2;
            ground = new Bitmap(Properties.Resources.FlappyBirdGround, 200, 100);
            downPipe = new Bitmap(Properties.Resources.Downpipe);
            upPipe = new Bitmap(Properties.Resources.Uppipe);
            float coef = (float)pipeWidth / downPipe.Width;
            downPipe = new Bitmap(downPipe, new Size((int)pipeWidth, (int)(downPipe.Height * coef)));
            upPipe = new Bitmap(upPipe, new Size((int)pipeWidth, (int)(upPipe.Height * coef)));
            curBird = new Bitmap(Properties.Resources.Bird2);
            coef = (float)rad / curBird.Height;
            curBird = new Bitmap(curBird, new Size((int)(curBird.Width * coef), (int)rad));
            bird1 = new Bitmap(Properties.Resources.Bird1, new Size((int)(Properties.Resources.Bird1.Width * coef), (int)rad));
            prevBird = curBird;
            bird2 = curBird;
            bird3 = new Bitmap(Properties.Resources.Bird3, new Size((int)(Properties.Resources.Bird3.Width * coef), (int)rad));
        }

        public override void Tick()
        {
            if(!IsActive)
            {
                return;
            }
            ticks++;
            if(ticks % 5 == 0 && !IsDead)
            {
                ChangePicture();
            }
            
            for(int i = 0; i < Math.Abs(velocity); i++)
            {
                posY += Speed * (Math.Abs(velocity) / velocity);
                CalculateCollisions();
            }

            if(!IsDead)
            {
                posX += Speed * 5;
            }
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
            if(firstGroundPos < posX - ControlSize.Width)
            {
                firstGroundPos += ground.Width;
            }
        }

        public override void PaintOnControl(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawImage(Properties.Resources.FlappyBirdBackground, 0, 0, ControlSize.Width, ControlSize.Height);
            if(pipes != null)
            {
                for(int i = Math.Max(0, score - 5); i < score + 5; i++)
                {
                    PointF p = pipes[i];
                    float x = p.X - (float)posX + ControlSize.Width / 2;
                    e.Graphics.DrawImage(downPipe, x, ControlSize.Height - p.Y);
                    e.Graphics.DrawImage(upPipe, x, ControlSize.Height - p.Y - upPipe.Height - (float)pipeHeight);
                }
            }
            float groundX = (float)firstGroundPos;
            while(groundX < posX + ControlSize.Width)
            {
                e.Graphics.DrawImage(ground, groundX - (float)posX, ControlSize.Height - (float)minPosY, ground.Width + 1, ground.Height);
                groundX += ground.Width;
            }
            e.Graphics.DrawImage(curBird, (float)(ControlSize.Width / 2 - rad), (float)(ControlSize.Height - posY - rad / 2));
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
                if(!IsDead)
                {
                    Up();
                }
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
            if(posY - rad / 2 < minPosY)
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
                IsDead = true;
            }
        }

        void Up()
        {
            if(posY < maxPosY)
                velocity = 8;
        }

        void ChangePicture()
        {
            if(curBird == bird1)
            {
                prevBird = bird1;
                curBird = bird2;
            }
            else if(curBird == bird3)
            {
                prevBird = bird3;
                curBird = bird2;
            }
            else
            {
                if(prevBird == bird1)
                {
                    curBird = bird3;
                }
                else
                {
                    curBird = bird1;
                }
                prevBird = bird2;
            }
        }

        List<PointF> GetPipes(int n, float startPos)
        {
            List<PointF> ans = new List<PointF>();
            ans.Add(new PointF(startPos + (float)pipeSpacing, r.Next((int)minPosY + 50, (int)maxPosY - 220)));
            for(int i = 1; i < n; i++)
            {
                ans.Add(new PointF(ans.Last().X + (float)pipeSpacing, r.Next((int)minPosY + 50, (int)maxPosY - 220)));
            }
            return ans;
        }
    }
}
