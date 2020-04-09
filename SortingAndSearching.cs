using System;
using System.Linq;
using NUnit.Framework;

namespace CSFundamentals
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBubbleSort()
        {
            int[] input = {1, 6, 8, 5, 3};
            int[] expected = {1, 3, 5, 6, 8};

            BubbleSort(ref input);

            Assert.That(input.Intersect(expected).Count() == 5);

        }

        [Test]
        public void TestLinearSearch()
        {
            int[] input = { 1, 6, 8, 5, 3 };

            var resultPos = LinearSearch(5, input, out var checks);
            Assert.That(checks == 4);
            Assert.That(resultPos == 3);
        }
        
        int? LinearSearch(int v, int[] array, out int checks)
        {
            checks = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                checks++;
                if (array[i] == v)
                {
                    return i;
                }
            }

            return null;
        }
            
        [Test]
        public void TestInsertionSort()
        {
            int[] input = { 1, 6, 8, 5, 3 };
            int[] expected = { 1, 3, 5, 6, 8 };
            InsertionSort(ref input);

            Assert.That(IsSame(input, expected));
        }


        [Test]
        public void TestInsertionSort2()
        {
           
            int[] input2 = { 1, 6, 8, 5, 3, 8, 5, 22, 1 };
            int[] expected2 = { 1, 1, 3, 5, 5, 6, 8, 8, 22 };
            InsertionSort(ref input2);

            Assert.That(IsSame(input2, expected2));
        }

        public bool IsSame(int[] arraya, int[] arrayb)
        {
            for (int i = 0; i < arraya.Length - 1; i++)
            {
                if (arraya[i] != arrayb[i]) 
                    return false;
            }
            return true;
        }

        public void InsertionSort(ref int[] input)
        {
            //  1, 6, 8, 5, 3, 8, 5, 22, 1
            //  1, 5, 6, 8, 3, 8, 5, 22, 1
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int save;
                    if (input[i] < input[j])
                    {
                        save = input[j];
                        input[j] = input[i];
                        input[i] = save;
                    }
                }
            }
        }

        public void BubbleSort(ref int[] input)
        {
            int swapped = 0;
            do
            {
                swapped = 0;
                for (int i = 0; i < input.Length-1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped++;
                    }
                }
            }while(swapped > 0);
        }
    }
}