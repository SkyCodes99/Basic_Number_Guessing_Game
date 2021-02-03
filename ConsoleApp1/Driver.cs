using System;

namespace Number_Guessing_Game
{
    class Driver
    {
        private bool numCheck;
        public static Driver check = new Driver();
        public bool parseChecker(bool check)
        {
            if(check == false)
            {
                Console.WriteLine("Invalid Response");
            }
            else
            {
                check = true;
            }
            return check;
        }
        public int LowNum(int lowNum)
        {
            bool methodCaller;
            do
            {
                    string lowNumString = Console.ReadLine();
                    methodCaller = int.TryParse(lowNumString, out lowNum);
                    numCheck = check.parseChecker(methodCaller);
            } while (numCheck == false);
            return lowNum;
        }

        public int HighNum(int highNum)
        {
            do
            {
                string highNumString = Console.ReadLine();
                bool methodCaller = int.TryParse(highNumString, out highNum);
                numCheck = check.parseChecker(methodCaller);
            } while (numCheck == false);
            return highNum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter low number: ");
            int minNum = 0;
            minNum = check.LowNum(minNum);
            Console.WriteLine("Enter high number: ");
            int highNum = 0;
            highNum = check.HighNum(highNum);
            Random guessNum = new Random();
            int finalNum = guessNum.Next();
            Console.WriteLine($"Guess a number between {minNum}-{highNum}");
        }
    }
}
