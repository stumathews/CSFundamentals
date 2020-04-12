using Microsoft.VisualBasic.CompilerServices;

namespace CSFundamentals
{
    public class Searching
    {
        public static int? LinearSearch(int v, int[] array, out int checks)
        {
            checks = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                checks++;
                if (array[i] == v)
                    return i+1; // we want to be relative to 1
            }

            return null;
        }

        public static int? BinarySearch(int v, int[] array, out int checks)
        {
            // {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            checks = 1;
            var found = false;
            var lowerBoundIndex = 0;
            var midPoint = GetArrayMidPoint(lowerBoundIndex, array.Length);
            var midPointValue = ValueRelation(midPoint, array);
            do
            {
                switch (midPointValue)
                {
                    case 0: 
                        found = true; // found at midpoint
                        break;
                    case 1:
                        midPoint = GetArrayMidPoint(lowerBoundIndex, midPoint);  // discard higher
                        break;
                    case -1:
                        lowerBoundIndex = midPoint;
                        midPoint = GetArrayMidPoint(lowerBoundIndex, array.Length); // discard lower
                        break;
                }
                midPointValue = ValueRelation(midPoint, array);
                checks++;
            } while (!found);

            return midPoint;

            // Find the midpoint of the array
            int GetArrayMidPoint(int startIndex, int length) => (startIndex + length) / 2;
            

            int ValueRelation(int midPointValue, int[] b)
            {
                if (midPointValue == v) return 0; // 0 = exact match
                if (midPointValue > v) return 1; // 1 means is greater than value at midpoint
                return -1; // -1 means is less than value at midpoint
            }
        }
    }
}