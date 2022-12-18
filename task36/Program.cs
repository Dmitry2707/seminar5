//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//Диапазон любой, ввод зависит от пользователя. (размер, значения)
int[] array = new int [4];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 9);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна: {0}", Sumoddposition(array));
int Sumoddposition(int[] array)
{
int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if ((array.Length & 2) != 0)
        Sum += array[i];
}
return Sum;
}