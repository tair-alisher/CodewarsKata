using System;

namespace WhoLikesIt
{
    public class Kata
    {
        public static string Likes (string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return String.Format("{0} likes this", name[0]);
                case 2:
                    return String.Format("{0} and {1} like this", name[0], name[1]);
                case 3:
                    return String.Format("{0}, {1} and {2} like this", name[0], name[1], name[2]);
                default:
                    return String.Format("{0}, {1} and {2} others like this", name[0], name[1], name.Length - 2);
            }
        }
    }
}
