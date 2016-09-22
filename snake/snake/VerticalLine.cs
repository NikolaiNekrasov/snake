using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<point> pList;

        public VerticalLine(int yLeft, int yReight, int x, char sym)
        {
            pList = new List<point>();
            for (int y = yLeft; y <= yReight; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);

            }

        }
        public void Drow()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }

        }
    }
}
