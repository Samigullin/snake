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


            List<Point> pList = new List<Point>();      // объявляем лист с точками и заполняем:
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            //выведем все точки в консоль:
            foreach (var p in pList)
            {
                p.Draw();
            }

            //добавим отступ:
            Console.WriteLine();

            List<char> cList = new List<char>();    // объявляем лист с символами и заполняем:
            cList.Add('*');
            cList.Add('|');
            cList.Add('+');
            cList.Add('=');

            //выведем все символы в консоль:
            for (var c = 0; c < cList.Count; c++)
            {
                Console.Write(cList[c] + " ");
            }

            Console.ReadKey();
        }
    }
}