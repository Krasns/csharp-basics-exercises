using System;

namespace Exercise5_PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter letter from a to z: ");
            string letters = Console.ReadLine().ToLower();
            char[] isLetter = letters.ToCharArray();

            for (int i = 0; i < isLetter.Length; i++) {

            if (char.IsLetter(isLetter[i]))
            {
                    switch (isLetter[i])
                    {
                        case 'a': case 'b': case 'c':
                            Console.WriteLine(2);
                            break;
                        case 'd': case 'e': case 'f':
                            Console.WriteLine(3);
                            break;
                        case 'g': case 'h': case 'i':
                            Console.WriteLine(4);
                            break;
                        case 'j': case 'k': case 'l':
                            Console.WriteLine(5);
                            break;
                        case 'm': case 'n': case 'o':
                            Console.WriteLine(6);
                            break;
                        case 'p': case 'q': case 'r': case 's':
                            Console.WriteLine(7);
                            break;
                        case 't': case 'u': case 'v':
                            Console.WriteLine(8);
                            break;
                        case 'w': case 'x': case 'y': case 'z':
                            Console.WriteLine(9);
                            break;
                        default:
                            Console.WriteLine("You have chousen a good letter!");
                            break;
                    }
            }
            else
                Console.WriteLine("Next time enter number from 2 to 9!");

            Console.ReadKey();

        }
    }
}
}
