int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}


void ShowArray(int[] array)
{
    Console.WriteLine("Случайно заданный массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void ReducedArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i <= 2; i++)
    {
       Console.Write(array[i] + " ");
    }
    
}

Console.WriteLine("Введите число от 5 до 100: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = RandomArray(a, min, max);
ShowArray(myArray);
Console.WriteLine();
ReducedArray(myArray);