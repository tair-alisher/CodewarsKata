using System.Linq;
using System.Reflection;

namespace ReflectionGiveMeAllMethods
{
    public class Kata
    {
        public static string[] GetMethodNames (object TestObject)
        {
            if (TestObject == null) return new string[0];

            MethodInfo[] objectMethods = TestObject.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            return objectMethods.Select(method => method.Name).ToArray();
        }
    }
}
