using System;

namespace _3_1P9_MyHedgehog
{
    public class Hedgehog
    {
        int needle_count;

        public int Needle_count
        {
            get { return this.needle_count; }
            set 
            {
                Console.WriteLine(this.needle_count + " - " + value);
                if (value <= 25)
                    if (Dead != null)
                        Dead(this);
                this.needle_count = value; 
            }
        }
        public delegate void DeadDelegate(Hedgehog hedgehog);
        public event DeadDelegate Dead;
        public Hedgehog(int needle_count)
        {
            this.needle_count = needle_count;
        }
    }

    struct Point
    {
        int x;
        int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hedgehog hedgehog = new Hedgehog(26);
            hedgehog.Dead += happy;
            needle_delete(hedgehog);
            Console.ReadKey();
        }
        static void needle_delete(Hedgehog hedgehog)
        {
            while(hedgehog.Needle_count > 25)
                hedgehog.Needle_count--;
        }

        static void happy(Hedgehog hedgehog)
        {
            Console.WriteLine("Happy");
        }
    }
}
