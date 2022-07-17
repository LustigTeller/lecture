void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int lenght = col.Length;
    int pos = 0;
    while (pos < lenght)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int IndexOf(int[] collection, int find)
{
    int lenght = collection.Length;
    int index = 0;
    int pos = -3;
    while (index < lenght)
    {
        if (collection[index] == find)
        {
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}
int pos = IndexOf(array, 3);
Console.WriteLine(pos);