using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exercises
{

    internal class Class1
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Please select a number from 1 - 50");
            choice = int.Parse(Console.ReadLine());
            switch (choice) {
                    case 1:
                    UserInputPrint();
                    break;
                    case 2:
                    AddTwoNumbers();
                    break;
                    case 3:
                    evenOddFinder();
                    break;
                    case 4:
                    interestCalculator();
                    break;
                    case 5:
                    letterCounting();
                    break;
                    case 6:
                    fineCalculator();
                    break;
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:                      
                    case 16:                        
                    case 17:
                    case 18:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:  
                    case 28:
                    case 29:
                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                    break;
                default: Console.WriteLine("No valid input");
                    break;
            }

        }

        static void UserInputPrint() {
            int number;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your entered : {0}", number);
            Console.ReadLine();
        }

        static void AddTwoNumbers() { 
        int number1, number2, sum;
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2;
            Console.WriteLine("Your total is: {0}",sum);

        }

        static void interestCalculator() {
            int p, t;
            float r, si;
            Console.WriteLine("Enter Amount");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter duration");
            t = int.Parse(Console.ReadLine());
            si = p * r * t / 100;
            Console.WriteLine("Interest is : {0}", si);
            Console.ReadKey();
            Console.WriteLine();
           

        }
        static void evenOddFinder() {
            int n;
            Console.Write("Enter an integer: ");
            n = Int32.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} is an even number", n);
            }
            else {
                Console.WriteLine("{0} is an odd number", n);
            }

        }

        static void letterCounting() {
            Console.WriteLine("Enter sentence to count letters");
        string myString = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < myString.Length; i++) {
                if (!char.IsWhiteSpace(myString[i])) { 
                count++;
                }
            }
            Console.WriteLine("Total letters: " + count);
        }

        static void fineCalculator() {
            int days;
            float fine = 0;
            Console.Write("Enter checkout duration in days");
            days = Convert.ToInt32(Console.ReadLine());

            if (days <= 5)
            {
                fine = 0;
            }
            else if (days > 5 && days <= 10)
            {
                fine = (days - 5) * 0.5f;
            }
            else if (days > 5 && days <= 10)
            {
                fine = (days - 5) * 0.5f;
            }
            else if (days > 10 && days <= 30)
            {
                fine = 5 * 0.5F + (days - 10) * 1;
            }
            else {
                fine = 5 * 0.5F + 20 * 1 + (days - 30) * 1.5F;
                Console.WriteLine("Canceled your Membership");
            }
            Console.WriteLine("Your fine:" + fine);

            Console.ReadLine();
        }

    }
}
