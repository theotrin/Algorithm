namespace Algoritimos;
//Imagine you are organizing playing cards in your hand. At first, the cards arrive in a mess.
//Then, you take one card at a time and put them in the right place, respecting the ascending (or descending) order.

internal class InsertionSort
{
    public void Execute(int[] array)
    {
        int N = array.Length;
        for(int i = 1; i < N; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    public void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
