using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perceptron
{
    public class Sample
    {
        double x1;
        double x2;
        double cls;

        public Sample(double x1, double x2, int cls)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.cls = cls;
        }

        public double X1
        {
            get { return x1; }
            set { this.x1 = value; }
        }

        public double X2
        {
            get { return x2; }
            set { this.x2 = value; }
        }

        public double Class
        {
            get { return cls; }
            set { this.cls = value; }
        }
    }
}
