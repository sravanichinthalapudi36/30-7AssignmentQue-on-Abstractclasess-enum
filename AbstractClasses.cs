using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace consoleFirstApp
{
    abstract class Quadralateral
    {
        public int length;
        public Quadralateral(int _length)
        {
            length = _length;
        }
        public void Dispaly()
        {
            Console.WriteLine("jbkk");
        }
        public abstract int Area();
        
    }
    class Square : Quadralateral
    {
        public Square(int _len) : base(_len)
        {

        }
        public override int Area()
        {
            int r = length * length;
            return r;
        }
    }
    class Rectangle : Quadralateral
    {
        int breadth;
        public Rectangle(int _breadth,int _length) : base(_length)
        {
            breadth = _breadth;
        }
        public override int Area()
        {
            int t = breadth * length;
            return t;
        }

    }
    class Que1
    {
        static void Main()
        {
            Square sq = new Square(4);
            Console.WriteLine("square area is:"+sq.Area());
            Quadralateral q = new Rectangle(4, 5);
            Console.WriteLine("rectangle area is:"+q.Area());

            if (sq.Area() > q.Area())
            {
                Console.WriteLine("Square area is greater than Rectangle area");
            }
            else
            {
                Console.WriteLine("Rectancle area is greater than square area");
            }
            Console.Read();
        }
    }
}
