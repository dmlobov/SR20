using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = CircumFerence;
            myDelegate += CircumArea;
            myDelegate += BallVolume;
            myDelegate(r);
            Console.ReadKey();
        }
        static double CircumFerence(double r)
        {
            double rez = 2 * Math.PI * r;
            Console.WriteLine(rez);
            return rez;
        }
        static double CircumArea(double r)
        {
            double rez = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(rez);
            return rez;
        }
        static double BallVolume(double r)
        {
            double rez = 4.0 / 3 * Math.PI *Math.Pow(r, 3);
            Console.WriteLine(rez);
            return rez;
        }       
    }
}
