using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlorAmarilla
{
    public partial class FlorAmarilla : Form
    {
        public FlorAmarilla()
        {
            InitializeComponent();
            this.Size = new Size(400, 400);
            this.Paint += new PaintEventHandler(DibujarFlor);
        }

        private void DibujarFlor(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Centro de la flor
            Point centro = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            // Pétalos
            int numPetalo = 12;
            float angulo = 0;
            float incrementoAngulo = 360 / numPetalo;

            for (int i = 0; i < numPetalo; i++)
            {
                // Crear un pétalo individual
                GraphicsPath petalo = new GraphicsPath();
                petalo.AddCurve(new Point[] {
                new Point(Convert.ToInt32(centro.X + 150 * (float)Math.Cos(angulo * Math.PI / 180)), Convert.ToInt32(centro.Y + 150 * (float)Math.Sin(angulo * Math.PI / 180))),
                new Point(Convert.ToInt32(centro.X + 200 * (float)Math.Cos((angulo + 20) * Math.PI / 180)), Convert.ToInt32(centro.Y + 200 * (float)Math.Sin((angulo + 20) * Math.PI / 180))),
                new Point(Convert.ToInt32(centro.X + 250 * (float)Math.Cos((angulo + 40) * Math.PI / 180)), Convert.ToInt32(centro.Y + 250 * (float)Math.Sin((angulo + 40) * Math.PI / 180))),
                new Point(Convert.ToInt32(centro.X + 200 * (float)Math.Cos((angulo + 60) * Math.PI / 180)), Convert.ToInt32(centro.Y + 200 * (float)Math.Sin((angulo + 60) * Math.PI / 180))),
                new Point(Convert.ToInt32(centro.X + 150 * (float)Math.Cos((angulo + 80) * Math.PI / 180)), Convert.ToInt32(centro.Y + 150 * (float)Math.Sin((angulo + 80) * Math.PI / 180))),
            });

                // Rellenar el pétalo con un gradiente de color
                Brush brush = new LinearGradientBrush(new Point(centro.X, centro.Y), new Point(centro.X + 200, centro.Y + 200), Color.Yellow, Color.Orange);
                g.FillPath(brush, petalo);

                // Agregar un borde al pétalo
                Pen pen = new Pen(Color.Black, 2);
                g.DrawPath(pen, petalo);

                angulo += incrementoAngulo;
            }

            // Centro de la flor
            g.FillEllipse(Brushes.Yellow, centro.X - 30, centro.Y - 30, 60, 60);

            // Agregar un borde al centro de la flor
            Pen penCentro = new Pen(Color.Black, 2);
            g.DrawEllipse(penCentro, centro.X - 30, centro.Y - 30, 60, 60);
        }


    }
}
