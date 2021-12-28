void PrintArray(int[] inputArr)
{
    foreach (int n in inputArr) Console.Write(n + " ");
    Console.WriteLine();
}

int FindEvenNumbers(int[] inputArr)
{
    return inputArr.Where(e => e % 2 == 0).Count();
}

// int[] a = { 1, 2, 3, 4, 5 };
// System.Console.WriteLine(FindEvenNumbers(a));