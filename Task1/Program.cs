// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GetArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for(int i=0; i < size; i++)
  { 
    array[i] = new Random().Next(minValue, maxValue+1);
  } 
  return array;
}
void PrintArray(int[] array)
{
  Console.WriteLine(string.Join(", ", array));
}
int[] array=GetArray(7, 0, 1000);
PrintArray(array);
int count=0;
for( int i=0; i<array.Length; i++) 
{
  if(array[i] %2==0) count++;        
}
Console.Write($"Количество четных элементов в массиве равно: {count}");    
Console.ReadLine();