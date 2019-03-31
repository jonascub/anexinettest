using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnexinetTechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stay = true;

            while (stay == true)
            {
                Console.WriteLine("Test Exercises:");
                Console.WriteLine("\n1. Write a function that computes (Pi).");
                Console.WriteLine("2. Angle between hours and minutes.");
                Console.WriteLine("3. *Converts integer to roman numeral.");
                Console.WriteLine("4. Validate anagrams between given words.");
                Console.WriteLine("5. Basic string compression.");
                Console.WriteLine("6. Swap two integers without using a temporary variable.");
                Console.WriteLine("7. *If an element in an MxN matrix is 0.");
                Console.Write("\nSelect the option to test: ");

                string op = Console.ReadLine();
                int iop = int.Parse(op);

                Console.WriteLine("");

                switch (iop)
                {
                    case 1:
                        {
                            Console.WriteLine("The result is: {0}", ExerciseFunctions.Pi());
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Give the hours (in a range of 0 to 12): ");
                            int hours = int.Parse(Console.ReadLine());

                            if (hours < 0 || hours > 12)
                            {
                                Console.WriteLine("Hours out of range");
                                System.Threading.Thread.Sleep(2000);
                                return;
                            }

                            Console.Write("Give the minutes (in a range of 0 to 60): ");
                            int minutes = int.Parse(Console.ReadLine());

                            if (minutes < 0 || minutes > 60)
                            {
                                Console.WriteLine("Minutes out of range");
                                System.Threading.Thread.Sleep(2000);
                                return;
                            }

                            int angle = ExerciseFunctions.GetAngle(hours, minutes);
                            Console.WriteLine("The angle between \"{0}\" hours and \"{1}\" minutes is \"{2}\"", hours, minutes, angle);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Under construction.");
                        break;
                    case 4:
                        {
                            Console.Write("Give the first word: ");
                            string firstWord = Console.ReadLine();

                            Console.Write("Give the second word: ");
                            string secondWord = Console.ReadLine();

                            bool isAnagram = ExerciseFunctions.ValidateAnagrams(firstWord, secondWord);

                            if (isAnagram)
                                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", firstWord, secondWord);
                            else
                                Console.WriteLine("No! Words \"{0}\" and \"{1}\" aren't Anagrams", firstWord, secondWord);

                        }
                        break;
                    case 5:
                        {
                            Console.Write("Give the string: ");
                            string str = Console.ReadLine();

                            Console.WriteLine("The result is: {0}", ExerciseFunctions.StringCompress(str));
                        }
                        break;
                    case 6:
                        {
                            Console.Write("Give the first number (x): ");
                            int firstNumber = int.Parse(Console.ReadLine());

                            Console.Write("Give the second number (y): ");
                            int secondNumber = int.Parse(Console.ReadLine());

                            firstNumber = firstNumber + secondNumber;
                            secondNumber = firstNumber - secondNumber;
                            firstNumber = firstNumber - secondNumber;

                            Console.WriteLine("After swapping, your first number (x) is \"{0}\" and your second number (y) \"{1}\"", firstNumber, secondNumber);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Under construction.");
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }

                Console.WriteLine("");
                Console.Write("would like to leave? (y/n): ");
                string leave = Console.ReadLine();

                stay = (leave == "y") ? false : true; Console.Clear();
            }
        }
    }
}
