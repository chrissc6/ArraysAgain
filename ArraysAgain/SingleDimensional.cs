using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAgain
{
    class SingleDimensional
    {
        public void SdArray()
        {
            Console.WriteLine("Single Dimensional Array of ints");

            //creation of array
            int[] numbers = new int[4];
            numbers[0] = 25;
            numbers[1] = 50;
            numbers[2] = 75;
            numbers[3] = 100;

            //loop and print
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public void SdArray2()
        {
            string[] names = new string[] { "Chris", "John", "Bill" };

            foreach (var i in names)
            {
                Console.WriteLine(i);
            }
        }

        public void SdArray3()
        {
            bool[] George = new bool[] { true, false, true };

            foreach (var i in George)
            {
                Console.WriteLine(i);
            }
        }

        public void SdArray4()
        {
            string[] colors = new string[] { "Red", "Blue", "Green" };
            PrintArrayMethod(colors);
        }

        public void SdArray4B()
        {
            string[] colors = new string[] { "Red2", "Blue2", "Green2" };
            PrintArrayMethod(colors);
        }

        private void PrintArrayMethod(string[] colors)
        {
            foreach (var i in colors)
            {
                Console.WriteLine(i);
            }
        }

        public void GetSdArray5()
        {
            int[] numbers = SdArray5();
            PrintArrayMethod2(numbers);

        }

        private int[] SdArray5() //return type is an array
        {
            int[] numbers = { 1000, 1250, 1500, 1750 };
            return numbers;
        }

        private void PrintArrayMethod2(int[] numbers)
        {
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
        }

        public void SdArrayMethods()
        {
            string[] letters = { "abc", "def", "ghi" };

            foreach (var i in letters)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(letters);

            foreach (var i in letters)
            {
                Console.WriteLine(i);
            }

        }
    }
}
