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


    }
}
