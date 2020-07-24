using System;

namespace Loops
{
    public class Naruto
    {
        public static int GetAmnt()
        {
            Console.WriteLine("Please enter the amount of shadow clones:");
            return Int32.Parse(Console.ReadLine());
        }

        public static void RunNarutoFor()
        {
            var amnt = GetAmnt();
            for (int i = 0; i < amnt; i++)
            {
                Console.WriteLine("Created shadow clone nr " + (i+1));
            }
        }

        public static void RunNarutoWhile()
        {
            var amnt = GetAmnt();
            var i = 0;
            while (i < amnt)
            {
                Console.WriteLine("Created shadow clone nr " + (i+1));
                i++;
            }
        }
    }
}