using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszyProjekt
{
    internal class Shape
    {
        public int x { set; get; }
        public int y { set; get; }
        public virtual void Draw()//virtual pozwala nadpisac metode w klasach pochodnych czyli takich co dziedzicza te klase
        {
            Console.WriteLine("drawing Shape");
        }
    }
    class Circle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Drawning Circle");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawning Rectangle");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawning Triangle");
        }
    }
}
