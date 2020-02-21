using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallist;

        public Walls(int mapWidth, int mapHeight)
        {
            wallist = new List<Figure>(); 
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');
            wallist.Add(upLine);
            wallist.Add(downLine);
            wallist.Add(leftLine);
            wallist.Add(rightLine);

        }

        public Walls(int x1, int x2, int y1, int y2, char symbol)
        {
            wallist = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(x1, x2, y1, symbol);
            HorizontalLine downLine = new HorizontalLine(x1, x2, y2, symbol);
            VerticalLine leftLine = new VerticalLine(y1, y2, x1, symbol);
            VerticalLine rightLine = new VerticalLine(y1, y2, x2, symbol);
            wallist.Add(upLine);
            wallist.Add(downLine);
            wallist.Add(leftLine);
            wallist.Add(rightLine);

        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

            public void Draw()
        {
            foreach (var wall in wallist)
            {
                wall.Draw();
            }
        }
    }
}
