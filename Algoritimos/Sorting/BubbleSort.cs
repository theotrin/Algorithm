namespace Algoritimos.Sorting;

internal class BubbleSort
{
    public void Execute(int[] array)
    {
        //Big O notation: 
        //Cenário        Complexidade
        //Melhor Caso    O(n)
        //Caso Médio     O(n²)
        //Pior Caso      O(n²)

        int n = array.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                // Troca os elementos se o da esquerda for maior que o da direita
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];        // Salva o valor do elemento atual
                    array[j] = array[j + 1];    // Substitui o valor atual pelo vizinho
                    array[j + 1] = temp;        // Coloca o valor salvo na posição vizinha
                }
            }
        }

    }
    public void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

