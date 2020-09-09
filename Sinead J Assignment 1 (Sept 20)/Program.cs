using System;
using System.Dynamic;

namespace Sinead_J_Assignment_1__Sept_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world's best calculator!");

            char opSelected;
            double numberOne;
            double numberTwo;
            double result;

            // create menu page

            // create method to capture double 1 and 2 and operator      

            Console.Write("Please enter first number: ");
            numberOne = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Please enter a second number: ");
            numberTwo = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Select maths operator (+, -, *, /): ");
            opSelected = (char)Console.Read();

             
            // create switch calculator 

                switch (opSelected)
                {
             
                case '+':
                    result = numberOne + numberTwo;
                    Console.WriteLine("Your answer is: " + result);
                     break;



            // create method - how to add method to my case?

                    static double comAddition (double numberOne, double numberTwo)
                    {
                        double addition = numberOne + numberTwo;

                        return addition;


                        }

                        /* case '-':
                            result = completeSubtraction;
                            break;


                           case '*':
                            Result: numberOne* numberTwo;
                                break;


                            case '/':
                            Result: numberOne / numberTwo;
                                break;

                            default

                }

                // create method for each calculation

                static double completeAddition(double numberOne, double numberTwo)
                    {
                        double addition = numberOne + numberTwo;

                        return addition;
                    }

                    static double completeSubtraction(double numberOne, double numberTwo)
                    {
                        double subtraction = numberOne - numberTwo;

                        return subtraction;
                    }
    */





                        /*
                        bool runMenu = true;
                        do  

                        {//menu 

                            Console.Clear();
                            Console.Write("----menu----\nEnter calculate to start the calculator.\nEnter quit to exit the program.\nSelection: ");

                            string userInput = Console.ReadLine();

                            switch (userInput)
                            {
                                case "calculate":
                                    Loops();
                                    break;

                                case "quit":
                                    runMenu = false;
                                    break;

                                default:
                                    Console.WriteLine("not a valid input)");
                                    break;

                            }

                            Console.WriteLine("Press a key to continue");
                            Console.ReadKey();

                        } while (runMenu);

                            */



                    }
        }
    }
}




