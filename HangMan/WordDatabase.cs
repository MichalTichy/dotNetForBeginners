using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    public class WordDatabase
    {
        protected string[] Words = new string[] {"Car", "Rocket", "Motorbike", "Skateboard"};
        protected Random randomGenerator=new Random();
        public string GetRandomWord()
        {
            return Words[randomGenerator.Next(0, Words.Length)];
        }

    }
}
