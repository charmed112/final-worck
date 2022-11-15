﻿int n = 4;
int size = 10;
string[] arrayOne = new string[size];
FillRandArr(arrayOne);
if (GetSizeOfSecondArray(arrayOne) == 0){Console.WriteLine("искомых элементов строкового масива для переноса в новый массив - нет");}
else
{   
    Console.Clear();
    Console.WriteLine($"Перед вами стр  оковый массив, заполненный рандомными занчениями, и новый массив, впитавщий в себя элементы предудещего массива, длина которых равна трём или менее символов:");
    Console.WriteLine();
    string[] arrayTwo = RotateElemOfArr(arrayOne);
    Console.WriteLine($"[{String.Join(", ", arrayOne)}] -> [{String.Join(", ", arrayTwo)}]");
    Console.WriteLine();
}
void FillRandArr(string[] arr)
{
    Random rand = new Random();
    string AllSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int randElemSize = rand.Next(1,8);
        for (int j = 0; j < randElemSize; j++)
        {
            arr[i] += AllSymbols[rand.Next(0,AllSymbols.Length)];
        }        
    }
}
int GetSizeOfSecondArray(string[] arr)
{   
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length < n)
        {
            secondSize++;
        }
    }
    return secondSize;
}
string[] RotateElemOfArr(string[] arr)
{
    string[] arrayTwo = new string[GetSizeOfSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if(arr[i].Length < n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}