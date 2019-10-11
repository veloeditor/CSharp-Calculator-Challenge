using System;

namespace CalculatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //user has to choose which option they want, start counter at -1 since 0 is taken for exit:
            int userChoice = -1;

            //while loop set condition to not equal to zero to allow user to keep picking calculator options until they finally choose 0 - exit
                Console.WriteLine("Welcome to Calculatron 3000!");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Here's what we're going to do:");
                Console.WriteLine("1 Add two numbers");
                Console.WriteLine("2 Subtract two numbers");
                Console.WriteLine("3 Multiply two numbers");
                Console.WriteLine("4 Divide two numbers");
                Console.WriteLine("0 Exit");
                Console.WriteLine();

            while (userChoice != 0) {
                //wrap all math options in a try to catch when they do not enter a number
                try {
                    Console.Write("Make a choice> ");
                    Console.WriteLine();
                

                    userChoice = Int32.Parse(Console.ReadLine());
                    Calculator calculator = new Calculator();

                    //1. Add
                    if (userChoice == 1) {
                        Console.WriteLine("1 Let's add two numbers:");
                        Console.Write("Please enter the first number> ");

                        int getAddNumberOne = Int32.Parse(Console.ReadLine());

                        Console.Write("Please enter the second number> ");
                        int getAddNumberTwo = Int32.Parse(Console.ReadLine());

                        int AddAnswer = calculator.Add(getAddNumberOne, getAddNumberTwo);
                        Console.WriteLine($"The result of adding {getAddNumberOne} and {getAddNumberTwo} is {AddAnswer}");
                        Console.WriteLine();
                    }
                    
                    if (userChoice == 2 ) {
                        //Subtract
                        Console.WriteLine("2 Let's subtract two numbers:");
                        Console.Write("Please enter the first number> ");
                        int getSubNumberOne = Int32.Parse(Console.ReadLine());

                        Console.Write("Please enter the second number> ");
                        int getSubNumberTwo = Int32.Parse(Console.ReadLine());

                        int SubAnswer = calculator.Subtract(getSubNumberOne, getSubNumberTwo);
                        Console.WriteLine($"The result of subtracting {getSubNumberOne} and {getSubNumberTwo} is {SubAnswer}");
                        Console.WriteLine();
                    }

                    if (userChoice == 3) {
                        //Multiply
                        Console.WriteLine("3 Let's multiply two numbers:");
                        Console.Write("Please enter the first number> ");
                        int getMultNumberOne = Int32.Parse(Console.ReadLine());

                        Console.Write("Please enter the second number> ");
                        int getMultNumberTwo = Int32.Parse(Console.ReadLine());

                        int MultAnswer = calculator.Multiply(getMultNumberOne, getMultNumberTwo);
                        Console.WriteLine($"The result of multiplying {getMultNumberOne} and {getMultNumberTwo} is {MultAnswer}");
                        Console.WriteLine();
                    }

                    if (userChoice == 4) {
                        //Divide
                        Console.WriteLine("3 Let's divide two numbers:");
                        Console.Write("Please enter the first number> ");
                        int getDivNumberOne = Int32.Parse(Console.ReadLine());

                        Console.Write("Please enter the second number> ");
                        int getDivNumberTwo = Int32.Parse(Console.ReadLine());

                            try {
                                int DivAnswer = calculator.Divide(getDivNumberOne, getDivNumberTwo);
                                Console.WriteLine($"The result of dividing {getDivNumberOne} and {getDivNumberTwo} is {DivAnswer}");
                                Console.WriteLine();
                                }

                            catch (DivideByZeroException)
                                {
                                    Console.WriteLine($"You cannot divide by zero.");
                                } 
                    }
                }
                catch 
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
                Console.WriteLine("You're done, thanks for playing Calculatron 3000! Now go get a cooler");

        }
    }
}
