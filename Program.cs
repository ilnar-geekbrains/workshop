
int[] array = new int[6];
void FillArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        var rnd = new Random().Next(1, 9);
        arr[i] = rnd;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

FillArray(array);
PrintArray(array);
int max = FindMax(array);
Console.WriteLine($"Max = {max}");