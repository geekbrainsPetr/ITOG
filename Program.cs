/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
 лучше обойтись исключительно массивами.
*/



string[] array = new string[] { "djhdf", "55", "jk5", "473", "hf;;" };
string[] array1 = new string[array.Length];

void Filarray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }

}
void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"  {array[i]} ");

    }
    Console.WriteLine();

}
Filarray(array, array1);
PrintArray(array1);