using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 1, '*');
            Point p2 = new Point(2, 2, '#');
            Point p3 = new Point(3, 3, '$');
            Point p4 = new Point(4, 4, '&');

            HorizontalLine hLine = new HorizontalLine(1, 15, 8, '=');
            hLine.DrawAll();

            VerticalLine vLine = new VerticalLine(1, 15, 8, '|');
            vLine.DrawAll();




            Console.ReadKey();
        }
    }
}