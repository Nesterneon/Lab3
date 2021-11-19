using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты прямоугольника");
            Console.WriteLine("Введите координаты x1, y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты x2, y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты x3, y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = 0;
            int y4 = 0;
            if (x1==x2)
            {
                if (y3 == y2)
                {
                    y4 = y1;
                    x4 = x3;
                }
                else if (y3 == y1)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else Console.WriteLine("стороны не параллельны координатным осям");
            }
            else Console.WriteLine("стороны не параллельны координатным осям");
            Console.WriteLine("х1={0}; y1={1}", x1, y1);
            Console.WriteLine("х2={0}; y2={1}", x1, y1);
            Console.WriteLine("х3={0}; y3={1}", x1, y1);
            Console.WriteLine("х4={0}; y4={1}", x1, y1);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
