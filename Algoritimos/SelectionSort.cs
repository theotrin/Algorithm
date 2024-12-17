namespace Algoritimos;
//A coach of a soccer team ordering the players from smallest to the largest
internal class SelectionSort
{
    public void Execute(int[] array)
    {
        int N = array.Length;
        for (int i = 0; i < N; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < N; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
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
