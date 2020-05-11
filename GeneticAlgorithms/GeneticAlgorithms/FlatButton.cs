using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithms
{
    class FlatButton : Button
    {
        Color curColor;
        Color backColor;
        public override Color BackColor { get => backColor; set => SetBackColor(value); }
        public Color HoverColor { get; set; }
        public Color ClickColor { get; set; }
        public FlatButton(Color backColor, Color hoverColor, Color clickColor)
        {
            BackColor = backColor;
            HoverColor = hoverColor;
            ClickColor = clickColor;
        }

        public FlatButton()
        {
            curColor = BackColor;
            Invalidate();
        }

        void SetBackColor(Color color)
        {
            base.BackColor = color;
            SetColor(color);
            backColor = color;
        }
        void SetColor(Color color)
        {
            curColor = color;
            Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            SetColor(HoverColor);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SetColor(BackColor);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            SetColor(ClickColor);
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            SetColor(HoverColor);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(curColor), new Rectangle(0, 0, Width, Height));
            if(BackgroundImage != null)
            {
                pevent.Graphics.DrawImage(BackgroundImage, new Rectangle(0, 0, Width, Height));
            }
            
        }
    }
}
