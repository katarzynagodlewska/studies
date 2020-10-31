using System;

namespace ComputerProgrammingLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad5();
        }

        static void Zad1()
        {
            Console.WriteLine("Give input");
            var number = int.Parse(Console.ReadLine());
            var result = string.Empty;

            if (number % 3 == 0)
            {
                result += "A";
            }

            if (number % 5 == 0)
            {
                result += "B";
            }

            Console.WriteLine(result);
        }

        static void Zad2()
        {
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {
                    var result = i * j;
                    if (result.ToString().Length == 1)
                    {
                        Console.Write(result + "   ");
                    }
                    if (result.ToString().Length == 2)
                    {
                        Console.Write(result + "  ");
                    }
                    if (result.ToString().Length == 3)
                    {
                        Console.Write(result + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Zad3()
        {
            Console.WriteLine("What's your first name?");
            var firstName = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            var lastName = Console.ReadLine();
            bool parseResult;
            int age;
            do
            {
                Console.WriteLine("How old are you?");
                parseResult = int.TryParse(Console.ReadLine(), out age);
            }
            while (parseResult == false);

            Console.WriteLine($"{firstName} {lastName} {age}");
        }

        static void Zad4()
        {
            var a = 2 * 2 + 3;
            var b = Math.Pow(225, 0.5) - Math.Pow(3, 2);
            var c = Math.Abs(-(a / b));
            Console.WriteLine(c);
            var d = Math.Round(c, 2);
            Console.WriteLine(d);
        }

        static void Zad5()
        {
            for (int i = 1; ; i++)
            {
                if (i % 6 == 0)
                {
                    Console.WriteLine(i);
                    continue;
                }
                if (i >= 50)
                {
                    break;
                }
            }
        }
    }
}