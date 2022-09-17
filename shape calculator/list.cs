using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator
{
    public class list
    {
        public string shape_list()
        {
            var shape_list = new List<string>
            { 
              "circle",
              "square",
              //"debug",
              "exit"
            };
            string main_list = string.Join(Environment.NewLine, shape_list.ToArray());
            return main_list;
        }
        public string input_s_L()
        {
            var cl = new List<string>
            {
               "perimeter",
               "area",
               "return"
            };
            string circle_list = string.Join(Environment.NewLine, cl.ToArray());
            return circle_list;
        }

        public string main_list()
        {
            var ml = new List<string>
            {
                "circle",
                "square",
                "debug",
                "area",
                "perimeter",
                "circumference"
            };
            string Main_list = string.Join(Environment.NewLine, ml.ToArray());
            return Main_list;
        }
    }
}
