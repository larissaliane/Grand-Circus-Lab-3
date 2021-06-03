using System;

namespace Grand_Circus_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput = "yes";

            while (userInput == "yes")

            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter an integer between 1 and 100!");
                var scoreOne = Console.ReadLine();

                var canBeParsed = int.TryParse(scoreOne, out int score);


                if (canBeParsed)
                {
                    if (score % 2 == 0 && score >= 2 && score <= 25)
                    {
                        Console.WriteLine($"{name} the answer is even and less than 25");
                    }
                    else if (score % 2 == 0 && score >= 26 && score <= 60)
                    {
                        Console.WriteLine($"{name} the answer is Even");
                    }
                    else if (score % 2 == 0 && score >= 60 && score <= 100)
                    {
                        Console.WriteLine($"{name} the answer is {score} Even");
                    }
                    else if (score % 2 != 0 && score >= 1 && score <= 100)
                    {
                        Console.WriteLine($"{name} the answer is {score}  Odd");
                    }
                    else if (score % 2 != 0 && score >= 60 && score <= 100)
                    {
                        Console.WriteLine($"{name} the answer is {score}  Odd");
                    }
                    else
                    {
                        Console.WriteLine("Please only enter a number between 1 and 100");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Please enter a number");
                }


                while (true)
                {
                    Console.WriteLine("Would you like to do another? yes/no");
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "no")
                    {
                        Console.WriteLine("bye!");
                        break;
                    }
                    if (userInput == "yes")
                    {
                        break;
                    }
                }
               
                               
            }
            
        }
    }
}


////tryparse
//Console.WriteLine("Please enter a number");
//var userResponse = Console.ReadLine();

//var canBeParsed = int.TryParse(userResponse, out int result);
//if (canBeParsed)
//{
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("you didn't give me a number");
//}