using System;
using System.Linq;
using NUnit.Framework;

namespace CSFundamentals
{
    public class Tests
    {
        private readonly Sorting _sorting = new Sorting();

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestBinarySearch()
        {
            int[] input = { 1,2,3,4,5,6,7,8,9, 10 }; // input must be sorted
            const int expectedFindAtIndex = 9;

            Assert.That(Searching.BinarySearch(21, new int[] { 1, 21, 34, 47, 58, 61, 73, 84, 91, 101 }, out var binarySearchChecks1) == 2);
            Assert.That(Searching.BinarySearch(expectedFindAtIndex, input, out var binarySearchChecks2) == expectedFindAtIndex);
            Assert.That(Searching.BinarySearch(expectedFindAtIndex, input, out var binarySearchChecks3) == expectedFindAtIndex);
            Assert.That(Searching.BinarySearch(expectedFindAtIndex, input, out var binarySearchChecks) == expectedFindAtIndex);
            Assert.That(Searching.LinearSearch(expectedFindAtIndex, input, out var linearSearchChecks) == expectedFindAtIndex);
            Assert.That(binarySearchChecks < linearSearchChecks );
            Console.WriteLine($"Linear checks = {linearSearchChecks}, binary checks = {binarySearchChecks}");
        }

        [Test]
        public void TestBubbleSort()
        {
            int[] input = {1, 6, 8, 5, 3};
            int[] expected = {1, 3, 5, 6, 8};

            Sorting.BubbleSort(ref input);

            Assert.That(input.Intersect(expected).Count() == 5);

        }

        [Test]
        public void TestLinearSearch()
        {
            int[] input = { 1, 6, 8, 5, 3 };

            var resultPos = Searching.LinearSearch(5, input, out var checks);
            Assert.That(checks == 4);
            Assert.That(resultPos == 4);
        }

        [Test]
        public void TestInsertionSort()
        {
            int[] input = { 1, 6, 8, 5, 3 };
            int[] expected = { 1, 3, 5, 6, 8 };
            Sorting.InsertionSort(ref input);

            Assert.That(IsSame(input, expected));
        }


        [Test]
        public void TestInsertionSort2()
        {
            int[] input2 = { 1, 6, 8, 5, 3, 8, 5, 22, 1 };
            int[] expected2 = { 1, 1, 3, 5, 5, 6, 8, 8, 22 };
            Sorting.InsertionSort(ref input2);

            Assert.That(IsSame(input2, expected2));
        }

        public bool IsSame(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != b[i]) 
                    return false;
            }
            return true;
        }
    }
}