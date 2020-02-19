﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            upLine.DrawAll();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.DrawAll();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            leftLine.DrawAll();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            rightLine.DrawAll();

            

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            snake.DrawAll();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);




            Console.ReadKey();
        }
    }
}