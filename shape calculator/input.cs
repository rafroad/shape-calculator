using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator
{
    public class input
    {
        list L = new list();
        calculation c = new calculation();
        public string main_input()
        {
            Console.WriteLine("shape calculator");
            Console.WriteLine("please pick a shape");
            string s_list = L.shape_list();
            Console.WriteLine(s_list);
            Console.Write(":");
            string main_input = Console.ReadLine();
            return main_input;
        }


        public string circle_decision()
        {
            Console.Clear();
            Console.WriteLine("pick type");
            Console.WriteLine(L.input_s_L());
            Console.Write(":");
            string cd = Console.ReadLine();
            return cd;
        }
        public string square_decision()
        {
            Console.Clear();
            Console.WriteLine("pick type");
            Console.WriteLine(L.input_s_L());
            Console.Write(":");
            string sd = Console.ReadLine();
            return sd;
        }
        public void debug()
        {
            Console.Clear();
            float test_value = 13;
            Console.WriteLine("shape list: " + Environment.NewLine + L.shape_list());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("square list: " + Environment.NewLine + L.input_s_L());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("test value: " + test_value);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("circle circum: " + c.circle_circum(test_value));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("cicle area: " + c.circle_area(test_value));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("square area: " + c.sqr_area(test_value));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("square perimeter: " + c.sqr_pr(test_value));
        }
        public void incorrect_input()
        {
            Console.WriteLine("INCORRECT INPUT PLEASE REINPUT");
        }
    }
}
