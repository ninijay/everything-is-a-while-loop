using System;

namespace Loops
{
    public class BackToTheFuture
    {
        public static bool GetUserInput()
        {
            Console.WriteLine("Does Marty make his parents kiss? (y/n)");
            var input = Console.ReadLine();
            return input != null && (input.ToUpper() == "Y" ? true : false);
        }

        public static void RunIF()
        {
            var martyMakesHisParentKiss = GetUserInput();
            if (martyMakesHisParentKiss)
            {
                Console.WriteLine("Marty is alive");
            }
            else
            {
                Console.WriteLine("Marty is dead");
            }
        }

        public static void RunWhile()
        {
            var martyMakesHisParentKiss = GetUserInput();
            var calls = 0;
            // if
            while (martyMakesHisParentKiss && calls == 0)
            {
                Console.WriteLine("Marty is alive");
                calls++;
            }
            // else
            while (!martyMakesHisParentKiss && calls == 0)
            {
                Console.WriteLine("Marty is dead");
                calls++;
            }
        }
    }
}