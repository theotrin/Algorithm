namespace Algoritimos.Sorting;

internal class MergeSort
{
    public void Execute(int[] array)
    {
        if (array.Length < 1)
            return;

        int mid = array.Length / 2;//dividir o array em 2
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        
        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        //Chamada recursiva
        Execute(left);
        Execute(right);
    }

    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        // Mesclar enquanto houver elementos em ambas as metades
        while( i < left.Length && i < right.Length)
        {
            if (left[i] <= right[j])
                array[k++] = left[i++];
            else
                array[k++] = right[j++];
            
        }
        // Adicionar elementos restantes da metade esquerda (se houver)
        while (i < left.Length)
            array[k++] = left[i++];

        // Adicionar elementos restantes da metade direita (se houver)
        while (j < right.Length)
            array[k++] = right[j++];
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
