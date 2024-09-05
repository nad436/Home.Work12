using System.Reflection;

namespace HomeWork
{
    public class ExecuteAttributes
    {
        public static void EA(string authorName)
        {
            Type type = typeof(Sample);
            var instance = Activator.CreateInstance(type);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            foreach (var method in methods)
            {
                var attributes = method.GetCustomAttributes(typeof(DocumentationAttribute), false) as DocumentationAttribute[];

                foreach (var attribute in attributes)
                {
                    if (attribute.Author == authorName)
                    {
                        Console.WriteLine($"Executing method: {method.Name} by {attribute.Author}");
                        method.Invoke(instance, null);
                    }
                }
            }
        }
    }
}