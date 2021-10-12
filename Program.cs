using System;

namespace minigame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int returnvalue = random.Next(1, 100);

            Console.WriteLine(" Gissa en nummer mellan 1 - 100");
            int response = Convert.ToInt32(Console.ReadLine());

            while (response > returnvalue)
            {
                Console.WriteLine($"Wrong the number is lower than {response} try again !");
                response = Convert.ToInt32(Console.ReadLine());
            }

            while (response < returnvalue)
            {
                Console.WriteLine($"Wrong the number is higher than {response} try again !");
                response = Convert.ToInt32(Console.ReadLine());
            }

            while (response != returnvalue)
            {
                Console.WriteLine($" Wrong answer {response} is not the good response try again !");
                response = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Bingo ! Its  {returnvalue}");

        }
    }
}