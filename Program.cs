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
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();
            int speed = 200;
            try
            {
                while (true)
                {
                    if (walls.IsHit(snake))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Walls ramka = new Walls(18, 57, 11, 13, '#');
                        ramka.Draw();
                        Console.SetCursorPosition(20, 12);
                        Console.WriteLine("Вы ударились в стену. Игра окончена!");
                        Console.ReadLine();

                        break;
                    }
                    if (snake.IsHitTail())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Walls ramka = new Walls(18, 62, 11, 13, '#');
                        ramka.Draw();
                        Console.SetCursorPosition(20, 12);
                        Console.WriteLine("Вы ударились в свой хвост. Игра окончена!");
                        Console.ReadLine();
                        break;
                    }
                    if (snake.Eat(food))
                    {
                        speed -= 10;
                        food = foodCreator.CreateFood();
                        food.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }
                    Thread.Sleep(speed);

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
                Console.ReadLine();
            }
        }
    }
}