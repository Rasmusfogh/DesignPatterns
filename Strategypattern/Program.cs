using System;

namespace Strategypattern
{
    public interface IStrategy
    {
        void doSomething();
    }

    public class Strategy1 : IStrategy
    {
        public void doSomething()
        {
        }
    }

    public class Strategy2 : IStrategy
    {
        public void doSomething()
        {
        }
    }

    public class Strategy3 : IStrategy
    {
        public void doSomething()
        {
        }
    }

    public interface IContext
    {
        void doAction();
    }

    public class Context : IContext
    {
        private IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void doAction()
        {
            _strategy.doSomething();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Context _context;

            var input = Console.ReadKey();
            char key = input.KeyChar;

            switch (key)
            {
                case 'a':
                    _context = new Context(new Strategy1());
                    break;
                case 'b':
                    _context = new Context(new Strategy2());
                    break;
                case 'c':
                    _context = new Context(new Strategy3());
                    break;
            }
        }
    }
}
