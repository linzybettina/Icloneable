using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Rock : ICloneable
    {
        int _weight;
        bool _round;
        bool _mossy;

        public Rock(int weight, bool round, bool mossy)
        {
            this._weight = weight;
            this._round = round;
            this._mossy = mossy;
        }

        public object Clone()
        {
            return new Rock(this._weight, this._round, this._mossy);
        }

        public override string ToString()
        {
          return string.Format("weight = {0}, round = {1}, mossy = {2}",this._weight,this._round,this._mossy);
        }
    }

    class Program
    {
        static void Main()
        {
            Rock rock1 = new Rock(10, true, false);
            Rock rock2 = rock1.Clone() as Rock;

            Console.WriteLine("1. {0}", rock1);
            Console.WriteLine("2. {0}", rock2);
            Console.ReadLine();
        }
    }
}