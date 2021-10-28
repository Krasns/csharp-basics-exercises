using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = new int[10];
            var secondArray = new int[10];

            var arrayObject = new ArrayExtensions();

            Random r = new Random();
            arrayObject.FillTenRandomNumbers(r, firstArray);

            arrayObject.CopyArray(firstArray, secondArray);

            arrayObject.ChangeLastValue(firstArray);

            arrayObject.Display(firstArray, secondArray);

            Console.ReadKey();
        }
    }
}
