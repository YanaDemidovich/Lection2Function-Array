// Метот и генератор случайных чисел

void FillArray(int[collection])
{
    int length = collection.Lenght;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position <count)
    {
        Console.WhriteLine(col[position]);
        position++;
    }
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);