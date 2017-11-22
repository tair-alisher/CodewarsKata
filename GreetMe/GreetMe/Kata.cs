using System;

namespace GreetMe
{
    public class Kata
    {
        public static string Greet (string name)
        {
            return String.Format("Hello {0}!", Char.ToUpper(name[0]) + name.Substring(1));
        }
    }
}
