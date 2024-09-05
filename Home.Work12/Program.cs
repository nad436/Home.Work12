using System;
using System.ComponentModel;
using System.Reflection;

namespace HomeWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            ExecuteAttributes.EA("Nazar Kylnytskyi");

            var sample = new Sample();
            sample.SampleM();
            sample.AnotherMethod();
            Type type = typeof(Sample);



            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (var method in methods)
            {
                if (method.GetCustomAttributes(typeof(DocumentationAttribute), false) is DocumentationAttribute[] attributes)
                {

                    foreach (var attribute in attributes)
                    {
                        Console.WriteLine($"Author: {attribute.Author}\nVersion: {attribute.Version}\nDescription: {attribute.Description}");
                    }

                }
            }
            
        }
    }
}