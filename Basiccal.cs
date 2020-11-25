using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
	class Basiccal
	{
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;                  
            string operation;
            int answer;

            Console.Write("Enter first number equation: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number equation: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Select operation ( x , / , +, -) ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            
            else if (operation == "+")
            {
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect");     
                Console.ReadLine();
            }
        }
    }
}
}
