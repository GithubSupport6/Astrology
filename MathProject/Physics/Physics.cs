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

        public Physics(double G, double T, double starMass, KeyValuePair<double,double> center, double starRadius = 5)
        {
            this.G = G;
            this.T = T;
            mainStar = new Body(starRadius, starMass,center.Key,center.Value);
            bodies = new List<Body>();
        }

        public void AddBody(Body body)
        {
            bodies.Add(body);
        }

        public void NextStep(double dt, bool isRadiusEqualMass = true)
        {
            List<KeyValuePair<Body,Body>> mergedBodies = new List<KeyValuePair<Body, Body>>();

            foreach (var body1 in bodies)
            {
                RungeCutta(body1);
                //foreach (var body2 in bodies)
                //{
                //    if (!body1.Equals(body2))
                //    {
                //        doubleInteract(body1, body2);
                //        if (isCrossing(body1, body2))
                //        {
                //            mergedBodies.Add(new KeyValuePair<Body, Body>(body1, body2));
                //        }
                //    }
                //}
                //doubleInteract(body1, mainStar);
                //OneSidedInteract(body1, mainStar);            
            }

            foreach (var body1 in bodies)
            {
                foreach (var body2 in bodies)
                {
                    if (!body1.Equals(body2) && isCrossing(body1,body2))
                    {
                        mergedBodies.Add(new KeyValuePair<Body, Body>(body1, body2));
                    }
                }
                if (isCrossing(body1,mainStar))
                {
                    mergedBodies.Add(new KeyValuePair<Body, Body>(body1, mainStar));
                }
            }

            foreach (var body in mergedBodies)
            {
                var toDelete = body.Key.Merge(body.Value);
                bodies.Remove(toDelete);
            }

        }

        private void OneSidedInteract(Body body1, Body body2)
        {
            var res = Interact(ref body1, body2);
            resetBodyCoords(body1, res.Key, res.Value);
        }

        private void doubleInteract(Body body1, Body body2)
        {
            Body temp = new Body(body1);
            var res = Interact(ref body1,body2);
            resetBodyCoords(body1, res.Key, res.Value);
            res = Interact(ref body2, temp);
            resetBodyCoords(body2, res.Key, res.Value);
        }

        private KeyValuePair<double,double> Interact(ref Body changed, Body changing)
        {
            double r = Math.Sqrt(Math.Pow(changed.X - changing.X, 2) + Math.Pow(changed.Y - changing.Y, 2));
            double ax = G * changing.Mass * (mainStar.X - changing.X) / Math.Pow(r, 3);
            double ay = G * changing.Mass * (mainStar.Y - changing.Y) / Math.Pow(r, 3);
            return new KeyValuePair<double, double>(ax, ay);
        }

        private void resetBodyCoords(Body body, double ax, double ay)
        {
            body.Dx = body.Dx + ax * T;
            body.Dy = body.Dy + ay * T;
            body.X += body.Dx;
            body.Y += body.Dy;

        }
        
        private void RungeCutta(Body body)
        {
            var k1 = T * this.fX(body,body.X);
            var q1 = T * body.Dx;

            var k2 = T * this.fX(body,body.X + q1 / 2);
            var q2 = T * (body.Dx + k1 / 2);

            var k3 = T * this.fX(body,body.X + q2 / 2);
            var q3 = T * (body.Dx + k2 / 2);

            var k4 = T * this.fX(body,body.X + q3);
            var q4 = T * (body.Dx + k3);

            body.Dx += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
            body.X += (q1 + 2 * q2 + 2 * q3 + q4) / 6;

            k1 = T * this.fY(body, body.Y);
            q1 = T * body.Dy;

            k2 = T * this.fY(body, body.Y + q1 / 2);
            q2 = T * (body.Dy + k1 / 2);

            k3 = T * this.fY(body, body.Y + q2 / 2);
            q3 = T * (body.Dy + k2 / 2);

            k4 = T * this.fY(body, body.Y + q3);
            q4 = T * (body.Dy + k3);

            body.Dy += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
            body.Y += (q1 + 2 * q2 + 2 * q3 + q4) / 6;


        }

        private double fX(Body body, double lx)
        {
            double a = 0;
            double r = 0;
            foreach (var elem in bodies)
            {
                if (!elem.Equals(body))
                {
                     r = Math.Sqrt(Math.Pow(elem.X - lx, 2) + Math.Pow(elem.Y - body.Y, 2));
                    a += elem.Mass * (elem.X - lx) / Math.Pow(r,3);
                }
            }
            r = Math.Sqrt(Math.Pow(mainStar.X - lx, 2) + Math.Pow(mainStar.Y - body.Y, 2));
            a += mainStar.Mass * (mainStar.X - lx) / Math.Pow(r, 3);

            return a;
        }

        private double fY(Body body, double ly)
        {
            double a = 0;
            double r = 0;
            foreach (var elem in bodies)
            {
                if (!elem.Equals(body))
                {
                    r = Math.Sqrt(Math.Pow(elem.X - body.X, 2) + Math.Pow(elem.Y - ly, 2));
                    a += elem.Mass * (elem.Y - ly) / Math.Pow(r, 3);
                }
            }
            r = Math.Sqrt(Math.Pow(mainStar.X - body.X, 2) + Math.Pow(mainStar.Y - ly, 2));
            a += mainStar.Mass * (mainStar.Y - ly) / Math.Pow(r, 3);

            return a;
        }

        public bool isCrossing(Body body1, Body body2)
        {
            return Math.Sqrt(Math.Pow(body1.X - body2.X, 2) + Math.Pow(body1.Y - body2.Y, 2)) <= body1.Radius + body2.Radius;
        }
    }
}
