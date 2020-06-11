using System;

namespace Factory_pattern
{
    public interface IObject
    {
        void execute();
    }


    public class ConcreteBusinessObject1 : IObject
    {
        public ConcreteBusinessObject1(string name)
        {

        }

        public void execute()
        {

        }
    }

    public class ConcreteBusinessObject2 : IObject
    {
        public ConcreteBusinessObject2(string name)
        {

        }

        public void execute()
        {

        }
    }

    public static class Factory
    {
        public static IObject Create()
        {
            if (true)
                return new ConcreteBusinessObject1("name");
            else
            {
                return new ConcreteBusinessObject2("name2");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myObject = Factory.Create();

            myObject.execute();
        }
    }
}
