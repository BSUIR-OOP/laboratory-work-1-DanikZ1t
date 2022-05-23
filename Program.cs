using System;

namespace LabWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (Figures ourfigures in Figures.flist) {
                ourfigures.Print();                
            }
        }
    }
}
