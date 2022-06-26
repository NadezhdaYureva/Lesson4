// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции

void PrintArray(int[] r)
{
    for (int i = 0; i < r.Length; i++)
    {
        System.Console.Write(r[i] + " ");
    }
}
int[] array;
array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);

}
PrintArray(array);