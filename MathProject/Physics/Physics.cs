using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProject
{
    class Physics
    {

        double G = 0;
        double T = 0;

        public List<Body> bodies
        {
            get;
        }
        public Body mainStar
        {
            get;
        }

        public Physics(double G, double T, double starMass, KeyValuePair<double,double> center)
        {
            this.G = G;
            this.T = T;
            mainStar = new Body(30, starMass,center.Key,center.Value);
            bodies = new List<Body>();
        }

        public void AddBody(Body body)
        {
            bodies.Add(body);
        }

        public void NextStep(double dt, bool isRadiusEqualMass = true)
        {
            List<Body> mergedBodies = new List<Body>();

            foreach (var body in bodies)
            {
                if (isRadiusEqualMass)
                {
                    body.Radius = body.Mass;
                    mainStar.Radius = mainStar.Mass;
                }


               double r = Math.Sqrt(Math.Pow(body.X - mainStar.X, 2) + Math.Pow(body.Y - mainStar.Y, 2));
               double ax = G * mainStar.Mass * (mainStar.X - body.X) / Math.Pow(r, 3);
               double ay = G * mainStar.Mass * (mainStar.Y - body.Y) / Math.Pow(r, 3);
               body.Dx = body.Dx + ax * T;
               body.Dy = body.Dy + ay * T;
               body.X += body.Dx;
               body.Y += body.Dy;
               if (isCrossing(mainStar,body))
               {
                  mergedBodies.Add(body);
               }
            }

            foreach (Body body in mergedBodies)
            {
                bodies.Remove(body);
                if (isRadiusEqualMass)
                {
                    mainStar.Mass += body.Mass;
                }
            }
        }


        public bool isCrossing(Body body1, Body body2)
        {
            return Math.Sqrt(Math.Pow(body1.X - body2.X, 2) + Math.Pow(body1.Y - body2.Y, 2)) <= body1.Radius + body2.Radius;
        }
    }
}
