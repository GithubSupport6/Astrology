using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProject
{
    public partial class MainForm : Form
    {
        Physics mainPhysics;
        bool isBodyOnCreate = false;
        double currMouseX = 0;
        double currMouseY = 0;
        Body currBodyToDraw;
        float currK = 1;

        public MainForm()
        {
            InitializeComponent();
            PhysicsTimer.Interval = 1;
            mainPhysics = new Physics(1, 1, 40, new KeyValuePair<double, double>(MainPanel.Width / 2,MainPanel.Height / 2));
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            mainPhysics.NextStep(10, false);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            RedrawAll(G);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            PhysicsTimer.Enabled = !PhysicsTimer.Enabled;
            
            
        }

        private void MainPanel_Click(object sender, EventArgs e)
        {
            if (!isBodyOnCreate)
            {
                Body newBody = new Body(5, 20, (e as MouseEventArgs).X, (e as MouseEventArgs).Y);
                mainPhysics.AddBody(newBody);
                currBodyToDraw = newBody;
                PhysicsTimer.Enabled = false;
                isBodyOnCreate = true;
            }
            else
            {
                double dx = (mainPhysics.bodies.Last().X - currMouseX) / 100;
                double dy = (mainPhysics.bodies.Last().Y - currMouseY) / 100;

                Console.WriteLine((e as MouseEventArgs).X);
                Console.WriteLine((e as MouseEventArgs).Y);
                Console.WriteLine(currMouseX);
                Console.WriteLine(currMouseY);
                if (dx!=0)
                {
                    Console.WriteLine(dx);
                }
                mainPhysics.bodies.Last().Dx = dx;
                mainPhysics.bodies.Last().Dy = dy;
                PhysicsTimer.Enabled = true;
                isBodyOnCreate = false;
            }
        }

        public void RedrawAll(Graphics graphics)
        {
            graphics.Clear(Color.Black);
            foreach (var body in mainPhysics.bodies)
            {
                drawBody(graphics, body, Color.Blue);
            }
            drawBody(graphics, mainPhysics.mainStar, Color.Yellow);

            if (isBodyOnCreate)
            {
                graphics.DrawLine(Pens.Red, (float)currBodyToDraw.X, (float)currBodyToDraw.Y, (float)currMouseX, (float)currMouseY);
            }
        }

        private void drawBody(Graphics G, Body body, Color color)
        {
            G.DrawEllipse(new Pen(color), (float)(body.X - body.Radius) * currK, (float)(body.Y - body.Radius) * currK, (float)body.Radius * 2 * currK, (float)body.Radius * 2 * currK);
            G.FillEllipse(new SolidBrush(color), (float)(body.X - body.Radius) * currK, (float)(body.Y - body.Radius) * currK, (float)body.Radius * 2 * currK, (float)body.Radius * 2 * currK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(this.MainPanel, true, null);
            this.DrawTimer.Enabled = true;
            this.DrawTimer.Interval = 1;
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            currMouseX = e.X;
            currMouseY = e.Y;
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            MainPanel.Invalidate();
        }

        private bool checkIsGone(Body body)
        {
            return (body.X < 0 || body.X > MainPanel.Width || body.Y < 0 || body.Y > MainPanel.Width);
        }


    }
}
