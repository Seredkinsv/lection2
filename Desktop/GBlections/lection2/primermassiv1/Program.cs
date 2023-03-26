// Ищем позицию четверки - на 51 строке написано int pos = IndexOf(array, 4);
// если числа которое ищем нет в массиве - выводится -1
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    
        return position;
} 

int[] array = new int[10];

FillArray(array);
// принудительно добавляем четверки для теста, break - обрубает дальше поиск после нахождения первого искомого числа.
array[8] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);