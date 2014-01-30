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
        IList<Salesman> salesmen = new List<Salesman>();

        private Random random = new Random();

		public Program()
			: base(800, 600, GraphicsMode.Default, "Hello OpenTK")
		{
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    House house = new House(i , j, 5 + random.Next(3));
                    houses.Add(house);
                }
                
            }

            Salesman salesman = new Salesman();
            salesman.SetTarget(GetNextHouse());
            salesmen.Add(salesman);

            for (int i = 0; i < 5; i++)
            {
                Salesman next = new Salesman();
                next.SetTarget(GetNextHouse());
                salesmen.Last().nextSalesman = next;
                salesmen.Add(next);
            }
    
			Keyboard.KeyDown += new EventHandler<KeyboardKeyEventArgs>(Keyboard_KeyDown);
		}

		void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
		{
			if (e.Key == Key.Escape)
				Exit();
            if (e.Key == Key.Enter)
            {

            }
                //salesMan.Target = houses.Last();
            
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
            foreach (House house in houses)
            {
                house.Update(e.Time);
            }

            foreach (Salesman salesman in salesmen)
            {
                salesman.Update(e.Time);
                if (salesman.Target.VisitTime <= 0)
                {
                    salesman.Selling = false;
                    salesman.Target.BeingVisisted = false;
                    salesman.SetTarget(GetNextHouse());
                }
            }
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

            foreach (Salesman salesman in salesmen)
            {
                salesman.Draw();
            }
            

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

        private House GetNextHouse()
        {
            return this.houses.FirstOrDefault(x => x.BeingVisisted == false && x.VisitTime > 0);
        }
	}
}

