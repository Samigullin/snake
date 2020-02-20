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
