using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendOrFoe
{
    public class Kata
    {
        public static string[] FriendOrFoe (string[] names)
        {
            return names.Where(name => name.Length == 4).ToArray();
        }
    }
}
