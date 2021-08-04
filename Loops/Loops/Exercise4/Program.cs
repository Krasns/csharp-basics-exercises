namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            for (int i = 0; i < vowels.Length; i++)
            {
                System.Console.Write(vowels[i] + " ");
            }
            System.Console.WriteLine();
            foreach (var item in vowels)
            {
                System.Console.Write(item + " ");
            }

            System.Console.ReadKey();
        }
    }
}
