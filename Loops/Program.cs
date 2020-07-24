using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to run?");
            Console.WriteLine("1) Owl while");
            Console.WriteLine("2) Avatar foreach");
            Console.WriteLine("3) Avatar while");
            Console.WriteLine("4) Naruto for");
            Console.WriteLine("5) Naruto while");
            Console.WriteLine("6) B2TF if");
            Console.WriteLine("7) B2TF while");

            var run = Int32.Parse(Console.ReadLine());
            switch (run)
            {
                case 1:
                    Owl.RunOwl();
                    break;
                case 2:
                    Avatar.RunAvatarForeach();
                    break;
                case 3:
                    Avatar.RunAvatarWhile();
                    break;
                case 4:
                    Naruto.RunNarutoFor();
                    break;
                case 5:
                    Naruto.RunNarutoWhile();
                    break;
                case 6:
                    BackToTheFuture.RunIF();
                    break;
                case 7:
                    BackToTheFuture.RunWhile();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }
        }
    }
}