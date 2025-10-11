using System;

namespace Number_Guess_game
{
    internal class Program
    {
        public static void game()
        { Random random = new Random();
            int a = random.Next(1,101);
            int b;
            Console.WriteLine("Welcome To The Number Guessing Game ");
            Console.WriteLine("Please Guess The Number Between 0 and 100 ");
            int attempt = 0;
            do
            {
                attempt++;
                Console.WriteLine("Enter Your  guess");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out b))
                {
                    Console.WriteLine("Please Enter A valid Number");
                    attempt--;
                    
                }
                else
                  {
                    if (b > 100 || b < 1)
                    {
                        Console.WriteLine("Please Guess Between 0 to 100");
                        attempt--;
                    }
                    else if (a > b)
                    {
                        Console.WriteLine("The Actual Number Is Greater than Your guess");
                    }
                    else if (a < b)
                    {
                        Console.WriteLine("The Actual Number Is Smaller than Your guess");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulation! You Guessed The Number in {attempt} attempt");
                    }
                    
                }
            } while (b != a);
            
        }
        static void Main(string[] args)
        {
            string playagain;
            
            do
            {
                game();
                Console.WriteLine("Do You Want To Play Again (yes/no) ");
                playagain = Console.ReadLine().ToLower();
            }
            while (playagain == "yes");
        }
    }
}
