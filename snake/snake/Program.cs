using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 3, '*');
            p1.Draw();
            point p2 = new point(4, 5, '#');
            p2.Draw();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("   p1  ---> " + p1.x + "  " + p1.y);
            Console.WriteLine("   p2  ---> " + p2.x + "  " + p2.y);

            p1 = p2; // p2 = p1; <-- у автора

            Console.WriteLine(" ");
            Console.WriteLine("   p1=p2 p1 ---> " + p1.x + "  " + p1.y);
            Console.WriteLine("   p1=p2 p2 ---> " + p2.x + "  " + p2.y);

            p2.x = 8; // p1.x = 8; для экперемента можно и эти координаты
            p2.y = 8; // p2.y = 6; меняет координаты обоих Point

            Console.WriteLine(" ");
            Console.WriteLine("   new p2(8,8) p1 ---> " + p1.x + "  " + p1.y);
            Console.WriteLine("   new p2(8,8) p2 ---> " + p2.x + "  " + p2.y);

            p1.x = 3; // Не важно какие координаты менять х или у 1-ой или 2-ой Point 
            p2.y = 5; // меняется всё т.к. адрес тот же

            Console.WriteLine(" ");
            Console.WriteLine("   new p1.x = 3 p1 ---> " + p1.x + "  " + p1.y);
            Console.WriteLine("   new p2.y = 5 p2 ---> " + p2.x + "  " + p2.y);

            Console.ReadKey();
        }

    }
}
