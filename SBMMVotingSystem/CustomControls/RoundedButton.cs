using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SBMMVotingSystem.CustomControls
{
    public class RoundedButton : Button
    {
        #region Private atributes
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColour = Color.DarkOrange;

        [Category("Custom control atributes")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Custom control atributes")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set 
            { 
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Custom control atributes")]
        public Color BorderColour
        {
            get
            {
                return borderColour;
            }
            set
            {
                borderColour = value;
                this.Invalidate();
            }
        }

        [Category("Custom control atributes")]
        public Color BackgroundColour
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        [Category("Custom control atributes")]
        public Color BTextColour
        {
            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;
            }
        }
        #endregion

        #region Constructor
        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Text = "";
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 50);
            this.BackColor = Color.DarkOrange;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }
        #endregion

        #region Private methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void Container_BackColourChanged(object sender, EventArgs e)
        {
            if (this.DesignMode) { this.Invalidate(); }
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (BorderRadius > this.Height)
                BorderRadius = this.Height;
        }
        #endregion

        #region Protected methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
            int smoothSize = 2;
            if (BorderSize > 0)
                smoothSize = BorderSize;
            if (BorderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - BorderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(BorderColour, BorderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (BorderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColour, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColourChanged);
        }
        #endregion
    }
}
