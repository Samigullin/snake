using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure        //змея наследует фигуру
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)      //конструктор класса змея
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);

            }
        }

        internal void Move()                        //движение змейки 
        {
            Point tail = pList.First();             
            pList.Remove(tail);                     //удаляем хвост из массива
            Point head = GetNextPoint();            
            pList.Add(head);                        //добавляем новую голову в массив
            tail.Clear();                           //стираем хвост с консоли
            head.Draw();                            //рисуем бошку в консоли
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i])) 
                {
                    return true;
                }
            }
            return false;
        }

        public Point GetNextPoint()                 //смещение головы змейки на одну точку вперед
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }

        public void HandleKey (ConsoleKey key)      //смена направления по нажатию на стрелки
        {
            if (key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow && direction != Direction.LEFT)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow && direction != Direction.DOWN)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow && direction != Direction.UP)
                direction = Direction.DOWN;
        }
    }
}
