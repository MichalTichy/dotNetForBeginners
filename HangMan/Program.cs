using System;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangman =new Hangman();

            var hangmanLives = hangman.lives;
            for (int i = 0; i <= hangmanLives; i++)
            {
                hangman.Draw();
                hangman.RemoveOneLive();
            }

            Console.WriteLine("Tak kopni do tý bedny, ať panstvo nečeká jsou dlouhý schody do nebe a štreka daleká.");

            Console.ReadKey();
        }
    }
}
