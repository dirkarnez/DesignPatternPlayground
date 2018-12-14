using System;

namespace DesignPatternPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            var sth = new StrategyPatternProvider().GetById("B");
            Console.WriteLine(sth.Name);
            // sth.Name = "Arbitary set"; // is blocked.
            sth.SayHi();
            Console.ReadLine();
        }
    }
}
