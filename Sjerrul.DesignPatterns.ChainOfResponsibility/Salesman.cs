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
        private static int _size = 5;
        private static int _speed = 1;

        public int X { get; set; }
        public int Y { get; set; }
        public House Target { get; set; }
        public Salesman nextSalesman { get; set; }

        public bool Selling { get; set; }

        public Salesman()
        {
            this.X = 0;
            this.Y = 0;
        }

        public void Update(double elapsedTime)
        {
            if (Target != null && this.Selling == false)
            {
                if (X != Target.X)
                {
                    if (X < Target.X)
                    {
                        X += _speed;
                    }
                    else
                    {
                        X -= _speed;
                    }  
                }

                if (Y != Target.Y)
                {
                    if (Y < Target.Y)
                    {
                        Y += _speed;
                    }
                    else
                    {
                        Y -= _speed;
                    }
                }

                if (Target.X == this.X && Target.Y == this.Y)
                {
                    this.Selling = true;
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

        public void SetTarget(House house)
        {
            Target = house;
            house.BeingVisisted = true;
        }
    }
}
