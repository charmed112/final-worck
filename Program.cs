int n = 3;
int size  = 6;
string[] arrayOne = new string[size];
Console.WriteLine("Введите 6 раз значение для массива");
FillArray(arrayOne);
Console.Clear();
PrintArray(arrayOne);
Console.WriteLine("новый массив->");
if (Secondarray(arrayOne) == 0)
    {
        Console.WriteLine("Искомых элементов  строкового массива для переноса в новый массив - нет");
    }
else
{
    string[] arrayTwo = TransferElements(arrayOne);
    PrintArray(arrayTwo);
}
void FillArray(string[]arr)
{  
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    int arrLeng = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrLeng; i++)
    {
    Console.Write(arr[i] + " ");
    }
    Console.Write("] ");
}

int Secondarray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if(arr[i].Length <= n)
        {
        secondSize++;
        }
    }  
    return secondSize; 
}

string[] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[Secondarray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
     if(arr[i].Length <= n)
     {
        arrayTwo[j] = arr[i];
        j++;
     }
    }
    return arrayTwo;
}
