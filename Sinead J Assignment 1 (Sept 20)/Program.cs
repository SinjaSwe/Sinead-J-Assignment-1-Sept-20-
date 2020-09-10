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

            /*
            bool runMenu = true;
            do
            {
                Console.Clear();
                Console.Write("----menu----\nEnter Calculate to run the calculator.\nEnter Quit to exit program.\nSelection: ");

                double userInput = Console.ReadLine();

                switch (userInput)

                    case "Loop":
                    Loops();
                    break;

                case "quit":
                    runMenu = false;
                    break;

                default:
                    Console.WriteLine("This is not a valid input.");
                    break;

            }
                Console.WriteLine("press a key to continue.");
                Console.ReadLine();

        } while (runMenu);*/



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
                    result = comAddition(numberOne, numberTwo);
                    Console.WriteLine("Your answer is: " + result);
                     break;

                case '-':
                    result = comSubtraction(numberOne, numberTwo);
                    Console.WriteLine("Your answer is: " + result);
                    break;

                case '*':
                    result = comMultiply(numberOne, numberTwo);
                    Console.WriteLine("Your answer is:" + result);
                    break;

                case '/':
                    result = comDivide(numberOne, numberTwo);
                    Console.WriteLine("Your answer is:" + result);
                    break;
                    

                    /*default*/

            }

            // method for addition

            static double comAddition (double numberOne, double numberTwo)
                    {
                        double addition = numberOne + numberTwo;

                        return addition;

                     }

            // method for subtraction

            static double comSubtraction (double numberOne, double numberTwo)
                {
                double subtraction = numberOne - numberTwo;

                return subtraction;
                }


            //method for multiplication

            static double comMultiply (double numberOne, double numberTwo)
                {
                double multiplication = numberOne * numberTwo;

                return multiplication;
                }

            //method for division

            static double comDivide (double numberOne, double numberTwo)
                {
                double division = numberOne / numberTwo;

                return division;
                }




            }








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
 





