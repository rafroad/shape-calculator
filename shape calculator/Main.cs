using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using shape_calculator;


namespace shape_calculator
{

    public class Main
    {
        calculation c = new calculation();
        list L = new list();
        input I = new input();
        public void main_prg()
        {
            string MI = I.main_input();
            switch (MI)
            {
                case "circle":
                    circle_prg();
                    break;
                case "square":
                    square_prg();
                    break;
                case "debug":
                    I.debug();
                    break;
                default:
                    Console.Clear();
                    I.incorrect_input();
                    main_prg();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
            }
        }
        public void circle_prg()
        {
            string cd = I.circle_decision();
            switch (cd)
            {
                case "area":
                    Console.Clear();
                    Console.Write("input diameter: ");
                    string ci_area = Console.ReadLine();
                    float circle_input = float.Parse(ci_area);
                    float cc = c.circle_area(circle_input);
                    Console.WriteLine("result: " + cc);
                    break;
                case "circumference":
                    Console.Clear();
                    Console.Write("input diameter: ");
                    string cic = Console.ReadLine();
                    float circle_input_circum = float.Parse(cic);
                    float ccc = c.circle_circum(circle_input_circum);
                    Console.WriteLine("result: " + ccc);
                    break;
                case "return":
                    Console.Clear();
                    main_prg();
                    break;
                default:
                    Console.Clear();
                    I.incorrect_input();
                    circle_prg();
                    break;
            }
        }
        public void square_prg()
        {
            string sd = I.square_decision();
            switch (sd)
            {
                case "area":
                    Console.Write("input side: ");
                    string sqr_ar_str = Console.ReadLine();
                    float sqr_ar = float.Parse(sqr_ar_str);
                    float sqr_ar_fnl = c.sqr_area(sqr_ar);
                    Console.WriteLine("result: " + sqr_ar_fnl);
                    break;
                case "perimeter":
                    Console.Write("input side: ");
                    string sqr_pr_str = Console.ReadLine();
                    float sqr_pr = float.Parse(sqr_pr_str);
                    float sqr_pr_fnl = c.sqr_area(sqr_pr);
                    Console.WriteLine("result: " + sqr_pr_fnl);
                    break;
                case "return":
                    Console.Clear();
                    main_prg();
                    break;
                default:
                    Console.Clear();
                    I.incorrect_input();
                    square_prg();
                    break;
            }
        }
    }
}
