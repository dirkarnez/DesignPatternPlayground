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
        public abstract string Id { get; protected set; }
        public abstract string Name { get; protected set; }

        public abstract void SayHi();

        public bool Equals(StrategyPattern other)
        {
            return other != null && Id == other.Id;
        }
    }

    public class StrategyPatternA : StrategyPattern
    {
        public override string Id { get { return "A"; } protected set { } }
        public override string Name { get { return "StrategyPatternA"; } protected set { } }

        public override void SayHi()
        {
            Console.WriteLine($"{Name} is speaking");
        }
    }

    public class StrategyPatternB : StrategyPattern
    {
        public override string Id { get { return "B"; } protected set { } }
        public override string Name { get { return "StrategyPatternB"; } protected set { } }

        public override void SayHi()
        {
            Console.WriteLine($"{Name} is walking");
        }
    }
}
