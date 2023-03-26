// Поиск заданного числа в массиве
int[] array = { 11, 21, 31, 41, 1115, 61, 127, 11, 18, 19 };

int n = array.Length;
int find = 11;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        // вводим break чтобы наядя первое число больше не искал
        break;
    }
    //index = index+1;
    index++;
}