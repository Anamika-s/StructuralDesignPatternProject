using System;

namespace StructuralDesignPatternsDemo
{
    public class Client
    {
        private ITarget target;

        public Client(ITarget target)
        {
            this.target = target;
        }

        public void MakeRequest()
        {
            target.MethodA();
        }
    }

    public interface ITarget
    {
        void MethodA();
    }

    public class Adapter : Adaptee, ITarget
    {
        public void MethodA()
        {
            MethodB();
        }
    }

    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB() is called");
        }
    }
        class Program1
    {
       public static void Main(string[] args)
        {
            
            ITarget target = new Adapter();
            Client client = new Client(target);
            client.MakeRequest();
         }
    }
}
