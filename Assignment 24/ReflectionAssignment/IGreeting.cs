using System;
using System.Reflection;
namespace Reflection
{
    public interface IGreeting
    {
        void SayHello(string name);
    }

    public class Greeting : IGreeting
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }

    public class LoggingProxy : IGreeting
    {
        private readonly IGreeting _greeting;

        public LoggingProxy(IGreeting greeting)
        {
            _greeting = greeting;
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Method 'SayHello' is being called with argument: {name}");
            _greeting.SayHello(name);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IGreeting greeting = new Greeting();
            IGreeting loggingProxy = new LoggingProxy(greeting);

            loggingProxy.SayHello("John");
        }
    }
}

