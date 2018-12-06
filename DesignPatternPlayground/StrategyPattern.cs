using System;
using System.Linq;
using System.Collections.Generic;

namespace DesignPatternPlayground
{
    public class StrategyPatternProvider
    {
        private ICollection<StrategyPattern> _strategyPatterns;

        public StrategyPattern GetById(string Id)
        {
            LoadData();
            return _strategyPatterns.SingleOrDefault(sp => sp.Id == Id);
        }

        private void LoadData()
        {
            if (_strategyPatterns != null)
            {
                return;
            }

            _strategyPatterns = new List<StrategyPattern>()
            {
                new StrategyPatternA(),
                new StrategyPatternB()
            };
        }
    }

    public abstract class StrategyPattern : IEquatable<StrategyPattern>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public abstract void SayHi();

        public bool Equals(StrategyPattern other)
        {
            return other != null && Id == other.Id;
        }
    }

    public class StrategyPatternA : StrategyPattern
    {
        public StrategyPatternA()
        {
            Id = "A";
            Name = "StrategyPatternA";
        }

        public override void SayHi()
        {
            Console.WriteLine($"{Name} is speaking");
        }
    }

    public class StrategyPatternB : StrategyPattern
    {
        public StrategyPatternB()
        {
            Id = "B";
            Name = "StrategyPatternB";
        }

        public override void SayHi()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}
