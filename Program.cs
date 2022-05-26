using System;

namespace LabWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (Figure ourfigures in ListArr.list) {
                ourfigures.Print();                
            }
        }
    }
}
