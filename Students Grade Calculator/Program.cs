using System;



namespace Student_Grade_Calculator
{
    internal class Program
    {
        public static void Grade()
        {   
            Console.WriteLine("Welcome To Student Grade Calculator !");
            Console.WriteLine("Enter Number Of Subjects");
            string Input1 = Console.ReadLine();
            int SubNum ;
            double mark = 0;
            double percentage = 0;
            string Input2;
            double total = 0;
            string grade = "Error";
            if (!int.TryParse(Input1, out SubNum))
            {
                Console.WriteLine("Enter A Valid Number In Numeric eg: (5,6,7)");
            }
            else
            {
                for (int i = 1; i <= SubNum; i++)
                {   while (true)
                    {
                        Console.WriteLine($"Enter The Mark Of Subject Number {i}");
                        Input2 = Console.ReadLine();
                        if (!double.TryParse(Input2, out mark) || mark > 100)
                        {
                            Console.WriteLine("Enter A Valid Mark");
                        }
                        else
                        {
                            total = total + mark;
                            break;
                        }
                    }
                }
                percentage = (total / (SubNum * 100)) * 100;
                if (percentage > 0 && percentage < 33)
                {
                     grade = "F";
                }
                else if (percentage >= 33 && percentage < 50)
                {
                    grade = "D";
                }
                else if (percentage >= 50 && percentage < 70)
                {
                    grade = "C";
                }
                else if (percentage >= 70 && percentage < 80)
                {
                    grade = "B";
                }
                else if (percentage >= 80 && percentage < 90)
                {
                    grade = "A";
                }
                else if (percentage >= 90 && percentage < 100)
                {
                    grade = "E";
                }
                else if (percentage == 100 )
                {
                    grade = "O";
                }
                

            }

            Console.WriteLine($"Your Total Mark Is {total} Out Of {SubNum * 100}");
            Console.WriteLine($"Your Total Percentage is {Math.Round(percentage,2)}% ");
            Console.WriteLine($"Your Got {grade}");
        }
        
        static void Main(string[] args)
        {
            string again;
            do
            {
                Grade();
                Console.WriteLine("Do You Want to CalCulate Another Student Result (yes/no)");
                again = Console.ReadLine().ToLower();

            }
            while (again == "yes");


        }
    }
}
