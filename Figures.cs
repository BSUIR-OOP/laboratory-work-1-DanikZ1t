using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabWork1
{
    class Figures
    {
       

       public static ArrayList flist = new ArrayList()
        {
        new hexagon(15, 20, 25, 30),
        new Rhombus(12,18,22,26),
        new Rectangle(10,20,30,40),
        new Star(5,15,25,35),
        new Square(15,20,25,30),
        new Triangle(10,15,20,30)
        };

        private double x1;
        private double x2;
        private double y1;
        private double y2;
        private string fname;


        public Figures(double x1, double x2, double y1, double y2)
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
