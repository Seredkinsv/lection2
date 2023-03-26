// Поиск заданного числа в массиве
int[] array = { 11, 21, 31, 41, 1115, 61, 127, 18, 19 };

int n = array.Length;
int find = 18;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index+1;
    index++;
}