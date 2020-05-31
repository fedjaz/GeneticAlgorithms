using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using System.Runtime.InteropServices.WindowsRuntime;

namespace GeneticAlgorithms
{
    //class Dino : Game
    //{
    //    double posY, posX;
    //    double minPosY;
    //    int score;
    //    double velocity;
    //    SizeF size;
    //    SizeF smallCactus, bigCactus;
    //    List<RectangleF> cactuses;
    //    int ticks;
    //    Random r;
    //    Bitmap cactus1, cactus2, ground;
    //    Bitmap dino1, dino2, dino3, curDino;

    //    public Dino(double speed, Random r, bool enableGraphics)
    //               : base(speed, new Keys[] { Keys.Space}, enableGraphics)
    //    {
    //        IsDead = false;
    //        this.r = r;
    //    }

    //    public override void SetDefaultOptions()
    //    {
    //        if(ControlSize == null)
    //        {
    //            throw new InvalidOperationException("Control doesn't set.");
    //        }

    //        posY = ControlSize.Height * 0.2;
    //        minPosY = posY;
    //        size.Height = ControlSize.Height * 0.4f;
    //        size.Width = size.Height * 0.8f;
    //        smallCactus.Height = size.Height * 0.8f;
    //        smallCactus.Width = smallCactus.Height * 1.5f;
    //        bigCactus.Height = size.Height * 1.2f;
    //        bigCactus.Width = bigCactus.Height * 2;

    //        if(EnableGraphics)
    //        {
    //            SetPictures();
    //        }
    //    }

    //    void SetPictures()
    //    {
    //        curDino = dino1;
    //    }

    //    public override void Tick()
    //    {
    //        if(!IsActive)
    //        {
    //            return;
    //        }
    //        if(cactuses == null)
    //        {
    //            //
    //        }

    //        if(EnableGraphics)
    //        {
    //            ticks++;
    //            if(posY > minPosY)
    //            {
    //                curDino = dino1;
    //            }
    //            else if(ticks % 5 == 0)
    //            {
    //                if(curDino == dino2)
    //                {
    //                    curDino = dino3;
    //                }
    //                else
    //                {
    //                    curDino = dino2;
    //                }
    //            }
    //        }

    //        posY = Math.Min(velocity + posY, minPosY);
    //        velocity = Math.Min(0, velocity - Speed);
    //        posX += Speed * 5;
    //        CalculateCollisions();
    //        //add cactuses generation
    //    }

    //    public override void PaintOnControl(object sender, PaintEventArgs e)
    //    {
    //        //prototype
    //        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
    //        //e.Graphics.FillRectangle()
    //    }

    //    public override double GetFitness()
    //    {
    //        return posX;
    //    }

    //    public override int GetScore()
    //    {
    //        return score;
    //    }

    //    public override object Clone()
    //    {
    //        Game game = new Dino(Speed, r, EnableGraphics)
    //        {
    //            ControlSize = ControlSize,
    //            size = size,
    //            minPosY = minPosY,
    //            bigCactus = bigCactus,
    //            smallCactus = bigCactus
    //        };
    //        if(EnableGraphics)
    //        {
    //            (game as Dino).SetPictures();
    //        }
    //        return game;
    //    }

    //    void CalculateCollisions()
    //    {
    //        RectangleF player = new RectangleF((float)posX, (float)posY, size.Width, size.Height);

    //    }
    //}
}
