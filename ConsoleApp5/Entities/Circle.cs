using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    internal class Circle
    {
        public const double Pi = Math.PI;
        public double radius;

        public Circle()
        {
            Console.WriteLine("Radiusu daxil edin!");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public double CalculateArea()
        {
            return (radius * radius) * Pi;

        }
    }
}
