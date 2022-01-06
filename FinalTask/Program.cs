void PrintArray(int[] inputArr)
{
    foreach (int n in inputArr) Console.Write(n + " ");
    Console.WriteLine();
}

int[] FindEvenNumbers(int[] inputArr)
{
    return inputArr.Where(e => e % 2 == 0).ToArray();
}

int[] currArr = { 0, 1, 4, -14, 9 };
int[] newArr = FindEvenNumbers(currArr);
PrintArray(newArr);