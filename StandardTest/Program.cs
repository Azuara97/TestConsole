using System;

namespace StandardTest
{
    class Program
    {
        static void SearchForCommonWords(string[] array1, string[] array2)
        {
            //Array to save the common words
            string[] commonWords = new string[array1.Length + array2.Length];

            //Compare all the words
            for(int j = 0; j < array1.Length; j++)
            {
                for(int i = 0; i < array2.Length; i++)
                {
                    if (array1[j] == array2[i])
                    {
                        commonWords[j] = array1[j];
                    }
                }
            }

            //Print the final array
            for(int i = 0; i < commonWords.Length; i++)
            {
                if (commonWords[i] != null)
                {
                    Console.WriteLine(commonWords[i]);
                }
            }
        }

        static void SwapMinimumMaximumNumber(int[] array)
        {
            //Variables to save the value and place in the array
            int minimumValue = 1000;
            int maximumValue = -1;
            int minimumIndex = 1000;
            int maximumIndex = -1;

            //Search for the minimum and the maximum numbers
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < minimumValue)
                {
                    minimumValue = array[i];
                    minimumIndex = i;
                }
                else if (array[i] > maximumValue)
                {
                    maximumValue = array[i];
                    maximumIndex = i;
                }
            }

            //Swap the minimum and the maximum
            int temp = array[minimumIndex];
            array[minimumIndex] = array[maximumIndex];
            array[maximumIndex] = temp;

            //Print the array
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void Main(string[] args)
        {
            string[] words1 = { "Hello", "world" };
            string[] words2 = { "hello", "world", "Good", "Morning" };

            //SearchForCommonWords(words1, words2);

            int[] numbersExample1 = { 3, 1, 0, 3, 5 };
            int[] numbersExample2 = { 3, 12, 10, 3 };

            SwapMinimumMaximumNumber(numbersExample2);
        }
    }
}
