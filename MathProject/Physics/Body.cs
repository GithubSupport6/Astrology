using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProject
{
    class Body
    {
        public double Radius
        {
            set;
            get;
        }

        public double Mass
        {
            get;
            set;
        }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public double Dx
        {
            get;
            set;
        }

        public double Dy
        {
            get;
            set;
        }



        public Body(double r, double m, double x, double y)
        {
            Radius = r;
            Mass = m;
            this.X = x;
            this.Y = y;
        }

        public Body(Body body)
        {
            this.Mass = body.Mass;
            this.X = body.X;
            this.Y = body.Y;
            this.Radius = body.Radius;
            this.Dx = body.Dx;
            this.Dy = body.Dy;
        }

        //Возвращает элемент, который был присоединен к другому
        public Body Merge(Body body)
        {
            var Mass = body.Mass + this.Mass;

            var x = (body.X * body.Mass + this.X * this.Mass) / Mass;
            var y = (body.Y * body.Mass + this.Y * this.Mass) / Mass;

            var dx = (body.Dx * body.Mass + this.Dx * this.Mass) / Mass;
            var dy = (body.Dy * body.Mass + this.Dy * this.Mass) / Mass;

            var radius = Math.Pow(Mass,1/3) / 2;

            Body toReturn = body.Mass > this.Mass ? this : body;

            Body toChange = body.Mass > this.Mass ? body : this;

            toChange.X = x;
            toChange.Y = y;
            toChange.Dx = dx;
            toChange.Dy = dy;
            toChange.Mass = Mass;
            toChange.Radius += radius;

            return toReturn;
        }

    }
}
