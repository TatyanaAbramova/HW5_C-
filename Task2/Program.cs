// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for(int i=0; i<size; i++)
  { 
    array[i] =new Random().Next(minValue, maxValue+1);
  } 
  return array;
}
void PrintArray(int[] array)
{
  Console.WriteLine(string.Join(", ", array));
}
int[] array = GetArray(7, 0, 1000);
PrintArray(array);
int odd=0;
 
  for(int i=0; i<array.Length; i++)
  {
    if (i %2 ==1) odd+= array[i];
      }

Console.WriteLine($"Сумма элементов нечетных позиций равна: {odd}"); 