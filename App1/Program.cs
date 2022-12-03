using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = CircumFerence;
            double l = myDelegate(r);
            Console.WriteLine(l);
            myDelegate = CircumArea;
            double s = myDelegate(r);
            Console.WriteLine(s);
            myDelegate = BallVolume;
            double v = myDelegate(r);
            Console.WriteLine(v);
            Console.ReadKey();
        }
        static double CircumFerence(double r) => (2 * Math.PI * r);
        static double CircumArea(double r) => (Math.PI * r*r);
        static double BallVolume(double r) => (4.0/3*Math.PI * r*r*r);
    }
}
