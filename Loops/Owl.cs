using System;

namespace Loops
{
    public class Owl
    {
        public static void RunOwl()
        {
            var owlText =
                "Hoo hoot! Link... Look up here! It appears that the time has finally come for you to start your adventure! You will encounter many hardships ahead... That is your fate. Don't feel discouraged, even during the toughest times! Go straight this way and you will see Hyrule Castle. You will meet a princess there... If you are lost and don't know which way to go, look at the Map. The areas you have explored will be shown on the map. Press START to enter the subscreens and Z or R to find the map. On the map subscreen, you will also see a flahing dot showing you which way to go next. Did you get all that Yes/No?";
            var okText = "Alright then, I'll see you around! Hoot Hoot Hoot Ho!";
            // no always makes him repeat
            var playerChoseNo = true;
            while (playerChoseNo)
            {
                Console.WriteLine(owlText);
                var answer = Console.ReadLine();
                if (answer.ToUpper().StartsWith("Y"))
                {
                    playerChoseNo = false;
                }
                else
                {
                    playerChoseNo = true;
                }
            }
            Console.WriteLine(okText);
        }
    }
}