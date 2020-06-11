using System;
using Microsoft.VisualBasic;

namespace Template_Method_pattern
{
    public interface IFrameworkClass
    {
        void TemplateMethod();
    }

    public abstract class FrameworkClass : IFrameworkClass
    {
        public void TemplateMethod() 
        {
            step1();
            step2();
            step3();
        }

        protected abstract void step1();
        protected abstract void step2();
        private void step3()
        {
        }
    }

    public class AppClass1 : FrameworkClass
    {
        protected override void step1()
        {
        }

        protected override void step2()
        {
        }
    }

    public class Appclass2 : FrameworkClass
    {
        protected override void step1()
        {
        }

        protected override void step2()
        {
        }
    }

    public interface IContext
    {
        void DoTemplateMethod();
    }

    public class Context : IContext
    {
        private IFrameworkClass _framework;
        public Context(IFrameworkClass framework)
        {
            _framework = framework;
        }

        public void DoTemplateMethod()
        {
            _framework.TemplateMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IContext context = 
                new Context(new AppClass1());
            context.DoTemplateMethod();
        }
    }
}
