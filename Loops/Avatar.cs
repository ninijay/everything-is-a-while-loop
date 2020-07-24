using System;

namespace Loops
{
    public class Avatar
    {
        private static string[] elements = new []{"wind", "water", "earth", "fire"};
        public static void RunAvatarForeach()
        {
            foreach (var element in elements)
            {
                Console.WriteLine("Aang learned " + element);
            }

        }

        public static void RunAvatarWhile()
        {
            var currentElement = 0;
            while (currentElement < elements.Length)
            {
                Console.WriteLine("Aang learned " + elements[currentElement++]);
            }
        }
    }
}