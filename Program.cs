using System;

namespace mopa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNumb = rand.Next(1, 101);
            int tries = 1;

            while(true){
                Console.Write("--> Gissa ett heltal ; ");
                string guess = Console.ReadLine();
                int guessNumber;
                if(int.TryParse(guess, out guessNumber) == false){
                    Console.WriteLine("Det där var inte ett heltal!");
                    continue;
                }

                if(guessNumber == randNumb){
                    break;
                }
                else if(guessNumber > randNumb){
                    Console.WriteLine("Du gissade för höööögt!");
                }
                else{
                    Console.WriteLine("Du gissade för låååågt!");
                }
                tries++;
            }

            Console.Write("Congrats! Du gissade rätt. Det tog ");
            Console.Write(tries);
            Console.WriteLine(" försök :)");
            
            

        }
    }
}
