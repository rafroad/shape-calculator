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
        //"debug"
            };
            string main_list = string.Join(Environment.NewLine, shape_list.ToArray());
            return main_list;
        }
        public string circle_list()
        {
            var cl = new List<string>
            {
        "circumference",
        "area"
            };
            string circle_list = string.Join(Environment.NewLine, cl.ToArray());
            return circle_list;
        }
        public string sqr_list()
        {
            var sl = new List<string>
            {
                "area",
                "perimeter"
            };
            string square_list=string.Join(Environment.NewLine, sl.ToArray());
            return square_list;
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
