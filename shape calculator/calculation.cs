using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator
{
    public class calculation
    {
        float pi=3.14F;
        public float circle_area(float diameter)
        {
            float hod = diameter / 2;
            float main = pi * hod * hod;
            return main;
        }
        public float circle_circum(float diameter)
        {
            float main = 2 * pi * diameter;
            return main;
        }
        public float sqr_area(float s1)
        {
            float sf = s1 * s1;
            return sf;
        }
        public float sqr_pr(float s1)
        {
            float sa = 4 * s1;
            return sa;
        }
    }
}
