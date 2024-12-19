using Algoritimos.Sorting;

//Bubble Sort
//{
//    BubbleSort bubbleSort = new();
//    int[] numbers = { 5, 3, 8, 4, 2 };

//    Console.WriteLine("Array original:");
//    bubbleSort.PrintArray(numbers);

//    bubbleSort.Execute(numbers);

//    Console.WriteLine("\nArray ordenado:");
//    bubbleSort.PrintArray(numbers);
//}

//Selection Sort
//{
//    int[] array = { 64, 25, 12, 22, 11 };
//    SelectionSort selection = new ();
//    Console.WriteLine("Array original:");
//    selection.PrintArray(array);

//    selection.Execute(array);

//    Console.WriteLine("\nArray ordenado:");
//    selection.PrintArray(array);
//}

//Insertion Sort
{
    int[] array = { 7, 3, 5, 2, 4, 1 };
    InsertionSort insertion = new();

    Console.WriteLine("Array original: ");
    insertion.PrintArray(array);

    insertion.Execute(array);

    Console.WriteLine("\nArray ordenado: ");
    insertion.PrintArray(array);
}

