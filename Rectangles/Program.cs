using System;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 0;
            int width = 0;
            RectangleArea(lenght, width);
            Console.ReadLine();

        }
        static void RectangleArea(int lenght , int width)
        {
            int area;
            Console.WriteLine("We will calculate the rectangle area.");
            Console.WriteLine("Please insert the lenght on the rectangle.");
            lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the width of the rectangle");
            width = Convert.ToInt32(Console.ReadLine());
            area = lenght * width;
            Console.WriteLine("The area of the rectangle is " + area + ".");

        }
    }
}
