using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.OpenTk.Cube
{
    class Salesman
    {
        public int X { get; set; }
        public int Y { get; set; }
        public House Target { get; set; }

        public Salesman()
        {
            this.X = 0;
            this.Y = 0;
        }

        public void Update(double elapsedTime)
        {
            if (Target != null)
            {
                if (X < Target.X)
                {
                    X++;
                }
                else
                {
                    X--;
                }

                if (Y < Target.Y)
                {
                    Y++;
                }
                else
                {
                   Y--;
                }
            }
        }

        public void Draw()
        {
            GL.PushMatrix();
            {
                GL.Translate(X, Y, 0);
                // GL.Rotate(angle, 0, 0, 1);
                GL.Color4(Color.Blue);
                GL.Begin(PrimitiveType.Quads);
                {
                    GL.Vertex2(-10, -10);
                    GL.Vertex2(10, -10);
                    GL.Vertex2(10, 10);
                    GL.Vertex2(-10, 10);
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
                    GL.Vertex2(-10, -10);
                    GL.Vertex2(10, -10);
                    GL.Vertex2(10, 10);
                    GL.Vertex2(-10, 10);
                }
                GL.End();
            }
            GL.PopMatrix();
        }
    }
}
