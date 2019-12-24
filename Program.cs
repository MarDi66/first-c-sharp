using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ! Please, write your first number :");
            string num1 = Console.ReadLine();
            bool isNum1Integer = false;

            while (!isNum1Integer)
            {
                if (Int32.TryParse(num1, out int number))
                {
                    isNum1Integer = true;
                }
                else
                {
                    Console.WriteLine("Please, enter a numeric input !");
                    num1 = Console.ReadLine();
                }
            }

            Console.WriteLine("Write your second number :");
            string num2 = Console.ReadLine();
            bool isNum2Integer = false;

            while (!isNum2Integer)
            {
                if (Int32.TryParse(num2, out int number))
                {
                    isNum2Integer = true;
                }
                else
                {
                    Console.WriteLine("Please, enter a numeric input !");
                    num2 = Console.ReadLine();
                }
            }

            Console.WriteLine("Alright ! Now, enter your operator :");
            int convertedNum1 = Convert.ToInt32(num1);
            int convertedNum2 = Convert.ToInt32(num2);
            string operat = Console.ReadLine();
            bool validOperator = false;

            while (!validOperator)
            {
                if(operat.ToLower() == "+" || operat.ToLower() == "add")
                {
                    int add = convertedNum1 + convertedNum2;
                    Console.WriteLine(string.Format("{0} {1} {2} = {3}", convertedNum1, operat.ToLower(), convertedNum2, add));
                    validOperator = true;
                }
                else if(operat.ToLower() == "-" || operat.ToLower() == "substract")
                {
                    int substract = convertedNum1 - convertedNum2;
                    Console.WriteLine(string.Format("{0} {1} {2} = {3}", convertedNum1, operat.ToLower(), convertedNum2, substract));
                    validOperator = true;
                }
                else if(operat.ToLower() == "*" || operat.ToLower() == "multiply")
                {
                    int multiply = convertedNum1 * convertedNum2;
                    Console.WriteLine(string.Format("{0} {1} {2} = {3}", convertedNum1, operat.ToLower(), convertedNum2, multiply));
                    validOperator = true;
                }
                else if(operat.ToLower() == "/" || operat.ToLower() == "divide")
                {
                    int divide = convertedNum1 / convertedNum2;
                    Console.WriteLine(string.Format("{0} {1} {2} = {3}", convertedNum1, operat.ToLower(), convertedNum2, divide));
                    validOperator = true;
                }
                else
                {
                    Console.WriteLine("Please, enter a valid operator :");
                    operat = Console.ReadLine();
                }


                /*switch (operat.ToLower())
                {
                    case "+":
                    case "add":
                        Console.WriteLine(num1 + operat.ToLower() + num2 + " = " + (convertedNum1 + convertedNum2));
                        validOperator = true;
                        break;

                    case "-":
                    case "substract":
                        Console.WriteLine(num1 + " " + operat.ToLower() + " " + num2 + " = " + (convertedNum1 - convertedNum2));
                        validOperator = true;
                        break;

                    case "*":
                    case "multiply":
                        Console.WriteLine(num1 + " " + operat.ToLower() + " " + num2 + " = " + (convertedNum1 * convertedNum2));
                        validOperator = true;
                        break;

                    case "/":
                    case "divide":
                        Console.WriteLine(num1 + " " + operat.ToLower() + " " + num2 + " = " + (convertedNum1 / convertedNum2));
                        validOperator = true;
                        break;

                    default:
                        Console.WriteLine("Please, enter a valid operator");
                        operat = Console.ReadLine();
                        break;
                }*/
            }
        }
    }
}
