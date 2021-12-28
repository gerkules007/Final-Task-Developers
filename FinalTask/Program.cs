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

// TEST
// Random Test
// void RandomArray(int[] inputArr)
// {
//     for (int i = 0; i < inputArr.Length; i++) inputArr[i] = new Random().Next(-10,11);
// }
// int[] currArr = new int [new Random().Next(15)];
// RandomArray(currArr);
// PrintArray(currArr);

int[] currArr = { 0, 7, 1, -14, 4 }; // Массив с 0 и отрицательным числом
// int[] currArr = { 1, 7, 1, 9 }; // Все нечетные
// int[] currArr = new int [0]; // Пустой массив

int[] newArr = new int [FindEvenNumbers(currArr)];
ReverseFillEvenNewArray(currArr, newArr);
PrintArray(newArr);