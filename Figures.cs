using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabWork1
{
    class ListArr
    {
        public static List<Figure> list = new List<Figure>()
            {
            new Hexagon(15, 20, 25, 30),
            new Rhombus(12,18,22,26),
            new Rectangle(10,20,30,40),
            new Star(5,15,25,35),
            new Square(15,20,25,30),
            new Triangle(10,15,20,30)
            };
    }

    class Figure
    {
        public double x1 { get; }
        public double x2 { get; }
        public double y1 { get; }
        public double y2 { get; }
        public string fname { get; }


        public Figure(double x1, double x2, double y1, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.fname = this.GetType().Name;

        }

        public double getx1()
        {
            return x1;
        }
        public double getx2()
        {
            return x2;
        }
        public double gety1()
        {
            return y1;
        }
        public double gety2()
        {
            return y2;
        }

        public string getname()
        {
            return fname;
        }

        public virtual void Print()
        {
            Console.WriteLine($"({getx1()}, {getx2()}, {gety1()}, {gety2()}) - {getname()}");
        }
    }

}
