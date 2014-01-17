using System;
using System.Linq;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Sjerrul.OpenTk.Cube;
using System.Collections.Generic;

namespace Sjerrul.DesignPatterns.ChainOfResponsibility
{
	class Program : GameWindow
    {
        const int InitialWidth = 1024;
        const int InitialHeight = 768;

        IList<House> houses = new List<House>();
        Salesman salesMan = new Salesman();

		public Program()
			: base(800, 600, GraphicsMode.Default, "Hello OpenTK")
		{
            for (int i = 0; i < 10; i++)
            {
                House house = new House(50*i, 50*i);
                houses.Add(house);
            }
            
       
			Keyboard.KeyDown += new EventHandler<KeyboardKeyEventArgs>(Keyboard_KeyDown);
		}

		void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
		{
			if (e.Key == Key.Escape)
				Exit();
            if (e.Key == Key.Enter)
                salesMan.Target = houses.Last();
            
		}

		protected override void OnLoad(EventArgs e)
		{
            base.OnLoad(e);

            GL.ClearColor(Color.CornflowerBlue);
            GL.Enable(EnableCap.Blend);
            GL.Disable(EnableCap.DepthTest);

            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, this.Width, this.Height, 0, -1, 1);
			
		}

		protected override void OnUpdateFrame(FrameEventArgs e)
		{
            double elapsedTime = e.Time;

            foreach (House house in houses)
            {
                house.Angle += 5;
            }

            salesMan.Update(e.Time);
		}

		protected override void OnResize(EventArgs e)
		{
			// Standard OpenTK code for window resize
			base.OnResize(e);
			GL.Viewport(0, 0, Width, Height);
			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadIdentity();
            GL.Ortho(0, this.Width, this.Height, 0, -1, 1);
		}

		protected override void OnRenderFrame(FrameEventArgs e)
		{
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(350, 350, 0f);


            foreach (House house in houses)
            {
                house.Draw();
            }

            salesMan.Draw();

            SwapBuffers();
		}

        

		[STAThread]
		public static void Main()
		{
			using (Program p = new Program())
			{
				p.Run(80f);
			}
		}

		
	}
}

