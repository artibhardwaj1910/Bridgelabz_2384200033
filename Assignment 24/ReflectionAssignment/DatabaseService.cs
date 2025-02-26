using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace Reflection
{
    // Custom attribute to mark fields for injection
    [AttributeUsage(AttributeTargets.Field)]
    public class InjectAttribute : Attribute { }

    public class DatabaseService
    {
        public void Connect()
        {
            Console.WriteLine("Database connected.");
        }
    }

    public class UserService
    {
        [Inject]
        private DatabaseService _databaseService;

        public void GetUserData()
        {
            _databaseService.Connect();
            Console.WriteLine("Fetching user data...");
        }
    }

    public class SimpleDIContainer
    {
        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        public void Register<T>(T service)
        {
            _services[typeof(T)] = service;
        }

        public T Resolve<T>()
        {
            return (T)_services[typeof(T)];
        }

        public void InjectDependencies(object target)
        {
            var fields = target.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                if (field.GetCustomAttribute<InjectAttribute>() != null)
                {
                    var dependency = _services[field.FieldType];
                    field.SetValue(target, dependency);
                }
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new SimpleDIContainer();
            container.Register(new DatabaseService());

            var userService = new UserService();
            container.InjectDependencies(userService);

            userService.GetUserData();
        }
    }
}

