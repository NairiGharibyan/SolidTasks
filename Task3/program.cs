using SolidTask1.InnerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTask1
{
    public  class Program
    {
        static void Main(string[] args)
        {

            var circle = new Circle();
            var circle_area = circle.Calculate_Area();
            Console.WriteLine(circle_area);

            var square = new Square();
            square.Calculate_Area();
            var square_area = square.Calculate_Area();
            Console.WriteLine(square_area);

            Console.Read();
        }
    }
}

