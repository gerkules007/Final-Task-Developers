void PrintArray(int[] inputArr)
{
    foreach (int n in inputArr) Console.Write(n + " ");
    Console.WriteLine();
}

int FindEvenNumbers(int[] inputArr)
{
    return inputArr.Where(e => e % 2 == 0).Count();
}

void ReverseFillEvenNewArray(int[] inputArr, int[] changedArr)
{
    for (int i = inputArr.Length - 1, leng = changedArr.Length - 1; i >= 0; i--) 
      if (inputArr[i] % 2 == 0) changedArr[leng--] = inputArr[i];
}

int[] currArr = { 0, 7, 8, 4, -14 };
int[] newArr = new int [FindEvenNumbers(currArr)];
ReverseFillEvenNewArray(currArr, newArr);
PrintArray(newArr);