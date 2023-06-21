using System;
using System.IO;
using System.Linq;

namespace Lab03Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
            Challenge6();
            Challenge7();
            Challenge8();
            Challenge9();
        }

        public static void Challenge1()
        {
            Console.WriteLine("Challenge 1: Product of 3 Numbers\n");

            Console.WriteLine("Please enter 3 numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            double result = 1;

            for (int i = 0; i < 3; i++)
            {
                if (i < numbers.Length && double.TryParse(numbers[i], out double number))
                {
                    result *= number;
                }
                else
                {
                    result *= 1;
                }
            }

            Console.WriteLine($"The product of these 3 numbers is: {result}\n");
        }

        public static void Challenge2()
        {
            Console.WriteLine("Challenge 2: Average of Random Numbers\n");

            Console.WriteLine("Please enter a number between 2-10:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int count) && count >= 2 && count <= 10)
            {
                double sum = 0;

                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i} of {count} - Enter a number:");
                    string numberInput = Console.ReadLine();

                    if (double.TryParse(numberInput, out double number) && number >= 0)
                    {
                        sum += number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        i--;
                    }
                }

                double average = sum / count;

                Console.WriteLine($"The average of these {count} numbers is: {average}\n");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 2-10.\n");
            }
        }

        public static void Challenge3()
        {
            Console.WriteLine("Challenge 3: Console Design\n");

            for (int i = 1; i <= 5; i++)
            {
                string stars = new string('*', 2 * i - 1);
                string spaces = new string(' ', 5 - i);

                Console.WriteLine(spaces + stars);
            }

            for (int i = 4; i >= 1; i--)
            {
                string stars = new string('*', 2 * i - 1);
                string spaces = new string(' ', 5 - i);

                Console.WriteLine(spaces + stars);
            }

            Console.WriteLine();
        }

        public static void Challenge4()
        {
            Console.WriteLine("Challenge 4: Most Frequent Number\n");

            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            int mostFrequent = numbers
                .GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            Console.WriteLine($"The most frequent number is: {mostFrequent}\n");
        }

        public static void Challenge5()
        {
            Console.WriteLine("Challenge 5: Maximum Value\n");

            int[] numbers = { 5, 25, 99, 123, 78, 96, 555, 108, 4 };

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"The maximum value is: {max}\n");
        }

        public static void Challenge6()
        {
            Console.WriteLine("Challenge 6: Save Word to File\n");

            Console.WriteLine("Please enter a word:");
            string word = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("words.txt", true))
            {
                writer.WriteLine(word);
            }

            Console.WriteLine("The word has been saved to the file.\n");
        }

        public static void Challenge7()
        {
            Console.WriteLine("Challenge 7: Read File Contents\n");

            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine();
        }

        public static void Challenge8()
        {
            Console.WriteLine("Challenge 8: Remove Word from File\n");

            Console.WriteLine("Please enter a word to remove:");
            string word = Console.ReadLine();

            string[] lines = File.ReadAllLines("words.txt");

            using (StreamWriter writer = new StreamWriter("words.txt"))
            {
                foreach (string line in lines)
                {
                    if (line != word)
                    {
                        writer.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("The word has been removed from the file.\n");
        }

        public static void Challenge9()
        {
            Console.WriteLine("Challenge 9: Word Lengths\n");

            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            string[] wordLengths = words.Select(word => $"{word}: {word.Length}").ToArray();

            Console.WriteLine("Word Lengths:");

            foreach (string wordLength in wordLengths)
            {
                Console.WriteLine(wordLength);
            }

            Console.WriteLine();
        }
    }
}