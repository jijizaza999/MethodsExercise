using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)


        {
            //   Your Name
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
            var band = Console.ReadLine();
        }
    }
}
