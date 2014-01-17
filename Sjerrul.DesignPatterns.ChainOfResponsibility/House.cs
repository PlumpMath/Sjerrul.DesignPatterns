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
        private static float _size = 25f;

        public int X { get; set; }
        public int Y { get; set; }
        public int Angle { get; set; }

        public House(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Angle = 0;
        }

        public void Draw()
        {
            GL.PushMatrix();
            {
                GL.Translate(X, Y, 0);
               // GL.Rotate(angle, 0, 0, 1);
                GL.Color4(0.7, 0.5, 0.2, 0.5);
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
                GL.Rotate(Angle, 0, 0, 1);
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
