using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace Annotation{

// Custom Attribute to Cache Method Results
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class CacheResultAttribute : Attribute
{
    // This attribute doesn't need any properties for basic caching logic.
}

// Caching System to Store Method Results
public static class MethodCache
{
    private static readonly Dictionary<string, object> Cache = new Dictionary<string, object>();

    // Method to check cache and return the result if available
    public static object GetCachedResult(string cacheKey)
    {
        if (Cache.ContainsKey(cacheKey))
        {
            Console.WriteLine("Returning cached result.");
            return Cache[cacheKey];
        }
        return null;
    }

    // Method to store the result in the cache
    public static void CacheResult(string cacheKey, object result)
    {
        Console.WriteLine("Caching result.");
        Cache[cacheKey] = result;
    }

    // Generate a cache key based on the method parameters
    public static string GenerateCacheKey(string methodName, object[] parameters)
    {
        return methodName + "(" + string.Join(",", parameters.Select(p => p.ToString())) + ")";
    }
}

// Class containing computationally expensive methods
public class Computation
{
    // Method with CacheResult attribute for caching its output
    [CacheResult]
    public int ExpensiveComputation(int a, int b)
    {
        // Simulate a computationally expensive operation
        Console.WriteLine("Performing computation...");
        return a * b + 1000;
    }
}

// Cache Handling Logic to Intercept Method Calls and Apply Caching
public class CacheHandler
{
    public static object InvokeWithCache(object obj, string methodName, object[] parameters)
    {
        var method = obj.GetType().GetMethod(methodName);
        var cacheAttribute = method.GetCustomAttribute<CacheResultAttribute>();

        if (cacheAttribute != null)
        {
            // Generate a unique cache key based on method name and parameters
            string cacheKey = MethodCache.GenerateCacheKey(methodName, parameters);
            
            // Check if result is already cached
            object cachedResult = MethodCache.GetCachedResult(cacheKey);
            if (cachedResult != null)
            {
                return cachedResult;
            }

            // If not cached, invoke the method and store the result in the cache
            object result = method.Invoke(obj, parameters);
            MethodCache.CacheResult(cacheKey, result);
            return result;
        }
        else
        {
            // If no cache attribute is present, invoke the method normally
            return method.Invoke(obj, parameters);
        }
    }
}

class Program
{
    static void Main()
    {
        var computation = new Computation();

        // Simulating expensive method calls
        Console.WriteLine("First call:");
        var result1 = CacheHandler.InvokeWithCache(computation, "ExpensiveComputation", new object[] { 5, 10 });
        Console.WriteLine($"Result: {result1}");

        // Call the same method with the same parameters (should use cache)
        Console.WriteLine("\nSecond call:");
        var result2 = CacheHandler.InvokeWithCache(computation, "ExpensiveComputation", new object[] { 5, 10 });
        Console.WriteLine($"Result: {result2}");

        // Call with different parameters (should recompute and cache)
        Console.WriteLine("\nThird call with different parameters:");
        var result3 = CacheHandler.InvokeWithCache(computation, "ExpensiveComputation", new object[] { 10, 20 });
        Console.WriteLine($"Result: {result3}");

        // Call the same method again with the second set of parameters (should use cache)
        Console.WriteLine("\nFourth call with the second set of parameters:");
        var result4 = CacheHandler.InvokeWithCache(computation, "ExpensiveComputation", new object[] { 10, 20 });
        Console.WriteLine($"Result: {result4}");
    }
}}

