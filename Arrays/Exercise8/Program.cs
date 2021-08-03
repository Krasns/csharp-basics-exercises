using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "randomly", "guesses", "strings", "separated", "elements", "access", "specific", "indexes" };
            Random rand = new Random();

            Console.WriteLine("Play game: yes or no");
            string answer = Console.ReadLine();

            while (answer != "no")
            {
                int number = rand.Next(0, words.Length);
                int wrong = 0;
                int right = 0;

                char[] word = words[number].ToCharArray();
                char[] wordWithUnderline = words[number].ToCharArray();

                string input;
                string Letters = "";
                string Letter = "";

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLetter(word[i]))
                    {
                        wordWithUnderline[i] = Convert.ToChar("_");
                    }
                }

                //Console.WriteLine(word); To see the answer uncomment
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                Console.Write("Word:\t");
                Console.WriteLine(wordWithUnderline);

                Console.Write("Inputs:\t");
                Console.WriteLine(Letters);

                Console.Write("Guess:\t");
                input = Console.ReadLine();

                do
                {
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                    foreach (var letter in word)
                    {
                        if (letter == Convert.ToChar(input))
                        {
                            for (int i = 0; i < word.Length; i++)
                            {
                                if (word[i] == Convert.ToChar(input))
                                {
                                    wordWithUnderline[i] = word[i];
                                }
                            }
                            right++;
                        }
                        else
                        {
                            Letter = input;
                        }
                    }
                    Console.WriteLine(wordWithUnderline);

                    Console.Write("Inputs:\t");
                    Letters += Letter.Substring(0, 1);
                    Console.WriteLine(Letters);

                    Console.Write("Guess:\t");
                    input = Console.ReadLine();

                    wrong++;
                } while (wrong != word.Length + 10 && right != word.Length);

                if (right == word.Length)
                    Console.WriteLine("YOU GOT IT!");
                else
                    Console.WriteLine("It's not coming home!");

                Console.WriteLine("Play game: yes or no");
                answer = Console.ReadLine();

                Console.ReadKey();
            }
        }
    }
}
