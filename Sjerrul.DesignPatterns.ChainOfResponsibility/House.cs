using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.OpenTk.Cube
{
    class House
    {
        private static int _size = 25;
        private static int _padding = 5;

        public int X { get; set; }
        public int Y { get; set; }
        public bool BeingVisisted { get; set; }
        public double VisitTime { get; set; }

        public House(int x, int y, double visitTime)
        {
            this.X = (x * _size) + _padding;
            this.Y = (y * _size) + _padding;

            this.BeingVisisted = false;
            this.VisitTime = visitTime;
        }

        public void Update(double elapsedTime)
        {
            if (BeingVisisted && VisitTime >= 0)
            {
                VisitTime -= elapsedTime;
            }
        }

        public void Draw()
        {
            GL.PushMatrix();
            {
                GL.Translate(X, Y, 0);
                double color = 1f / (1 + VisitTime);
                GL.Color4(color, 0.5, 0.2, 0.5);
                GL.Begin(PrimitiveType.Quads);
                {
                    GL.Vertex2(-_size, -_size);
                    GL.Vertex2(_size, -_size);
                    GL.Vertex2(_size, _size);
                    GL.Vertex2(-_size, _size);
                }
                GL.End();
            }
            GL.PopMatrix();

            GL.PushMatrix();
            {
                GL.Translate(X, Y, 0);
                GL.Color4(Color.Black);
                GL.Begin(PrimitiveType.LineLoop);
                {
                    GL.Vertex2(-_size, -_size);
                    GL.Vertex2(_size, -_size);
                    GL.Vertex2(_size, _size);
                    GL.Vertex2(-_size, _size);
                }
                GL.End();
            }
            GL.PopMatrix();
        }
    }
}
