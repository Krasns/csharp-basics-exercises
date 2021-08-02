using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words ={ "randomly", "guesses", "strings", "separated", "elements", "access", "specific", "indexes" };
            Random rand = new Random();
            int number = rand.Next(0, words.Length);
            int rong = 0;
            int right = 0;
            char[] word = words[number].ToCharArray();
            string input;
            string rightLeter = "";
            string rongLetters = "";
            Console.WriteLine(word);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Console.Write("Word:\t");
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i].ToString().Replace(word[i].ToString(), "_") + " ");
            }
            Console.WriteLine();

            Console.Write("Misses:\t");
            Console.WriteLine(rongLetters);

            Console.Write("Guess:\t");
            input = Console.ReadLine();

            do
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                
                    if (word.ToString().Contains(input))
                        rightLeter += input;
                

                for (int i = 0; i < word.Length; i++)
                {
                        if (word[i].ToString().Contains(rightLeter[i]))
                        {
                        Console.Write(word[i].ToString().Replace(word[i].ToString(), rightLeter) + " ");
                        right++;
                        }
                    else
                    {
                        Console.Write(word[i].ToString().Replace(word[i].ToString(), "_") + " ");
                    }
                }
                Console.WriteLine();

                Console.Write("Misses:\t");
                if (word.ToString().IndexOf(input) == -1)
                {
                    rongLetters += input;
                }
                Console.WriteLine(rongLetters);

                Console.Write("Guess:\t");
                input = Console.ReadLine();

                rong++;
            } while (rong != word.Length + 10 || right == word.Length);

            if (right == word.Length)
                Console.WriteLine("YOU GOT IT!");
            else
                Console.WriteLine("It's not coming home!");

            Console.ReadKey();
        }
    }
}
