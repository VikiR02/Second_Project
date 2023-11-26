using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //задание 1
            string fullName = "Ivanov Ivan Ivanovich"; 
            int years = 25;
            string email = "IvanIvanov@gmail.com";
            decimal markInРrogramming = 90.8m;
            decimal markInMathematics = 85;
            decimal markInPhysics = 90.3m;
            string inf = "F.I.O : {0} \nYears : {1} \nEmail : {2} \nMark in programming : {3} \nMark in mathematics : {4} \nMark in physics : {5}";
            Console.WriteLine(inf,
                fullName, 
                years,
                email,
                markInРrogramming,
                markInMathematics, 
                markInPhysics);

            //задание 2
            decimal summ = 0;
            summ += markInMathematics;
            summ += markInPhysics;
            summ += markInPhysics;
            Console.WriteLine("\nArithmetic average :{0:0.0}",summ/3);

            Console.ReadKey();

        }
    }
}
