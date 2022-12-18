//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//Диапазон любой, ввод зависит от пользователя. (размер, значения)
int[] array = new int [4];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-9, 9);
}
Console.WriteLine(string.Join(",", array));

 Console.WriteLine(SumPositive(array));
 string SumPositive(int[] array)
 {
   string text = "";
    for(int i = 0; i < array.Length / 3; i++)
    {
       text = text + (array[1] + array[3]); 
    }
    return text;
 }

