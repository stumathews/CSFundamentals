namespace CSFundamentals
{
    public class Sorting
    {
        public static void InsertionSort(ref int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] < input[j])
                    {
                        var save = input[j];
                        input[j] = input[i];
                        input[i] = save;
                    }
                }
            }
        }

        public static void BubbleSort(ref int[] input)
        {
            int swapped;
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
            } while(swapped > 0);
        }
    }
}