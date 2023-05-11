using System.Drawing;

namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {

            return num1 * num2 * num3;
        }

      static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

       //------------Exercise 1 ----------------------
            //Your Name
            //Your Name
            //Your Favorite Color
            //Your Favorite Animal
            //Your Favorite Band

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} - What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a awesome color, What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great, now what is your favorite band?");
            var band = Console.ReadLine();// Why does my terminal stopped printing from here and disappeared ???
                                          //And I need Console.ReadLine() so Terminial wont escape and print the rest codes.

            Console.WriteLine($"Thanks {userName}, Here is your profile.");
            Console.WriteLine("--------------------------");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band:{band}");

        }
    }

        }
