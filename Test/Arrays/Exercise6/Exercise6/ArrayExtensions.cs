using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class ArrayExtensions
    {
        private int[] _firstArray;
        private int[] _secondArray;
        public ArrayExtensions()
        {
        }
        public void FillTenRandomNumbers(Random r, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 100);
            }
                return;
        }
        public void CopyArray(int[] firstArray, int[] secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }
            return;
        }
        public void ChangeLastValue(int[] firstArray)
        {
            firstArray[firstArray.Length - 1] = -7;
            return;
        }
        public void Display(int[] firstArray, int[] secondArray)
        {
            Console.Write("Array 1:");
            foreach (var number in firstArray)
            {
                Console.Write($" {number}");
            }

            Console.WriteLine();
            Console.Write("Array 2:");
            foreach (var number in secondArray)
            {
                Console.Write($" {number}");
            }
        }
    }
}
