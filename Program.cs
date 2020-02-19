using System;
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

            //Рамка:
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            rightLine.Draw();      
            //.Рамка

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '*');
            Point food = foodCreator.CreateFood();
            food.Draw();
            try
            {
                while (true)
                {
                    if (snake.Eat(food))
                    {
                        food = foodCreator.CreateFood();
                        food.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }
                    Thread.Sleep(100);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();      //считываем клавишу
                        snake.HandleKey(key.Key);
                    }
                }
            }
            catch(ArgumentOutOfRangeException) 
            { 
                Console.WriteLine("Вы ударились в стену. Игра окончена!");
                Console.ReadKey();
            }
        }
    }
}