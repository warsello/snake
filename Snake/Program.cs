﻿using System;
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
            Point p1 = new Point();
            p1.x = 1; p1.y = 3; p1.sym = '*';
            p1.Draw();
           /* int x1 = 1, y1 = 3;
            char sym1 = '*';
            Draw(x1,y1,sym1);*/
            Point p2 = new Point();
            p2.x = 3; p2.y = 5; p2.sym = '#';
            p2.Draw();

/*            int x2 = 3, y2= 5;
            char sym2 = '#';
            Draw(x2,y2,sym2);*/
            Console.ReadLine();
        }
           /* static void Draw(int x, int y, char sym)
            {
               Console.SetCursorPosition(x, y);
               Console.Write(sym);

            }*/
    }
}
