using System;

namespace DesignPatternPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            new StrategyPatternProvider().GetById("B").SayHi();
            Console.ReadLine();
        }
    }
}
