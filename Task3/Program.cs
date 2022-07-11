// Найдите разницу между максимальным и минимальным элементами массива.

Console.Write("n: ");
   
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
   
Random rand = new Random();
for(int i=0; i<array.Length; i++) 
{
  array[i] =rand.Next()%100-50;
}
   
Console.Write("Массив: ");
for(int i=0; i<array.Length; i++) 
{
  Console.Write(array[i] +" ");
}
Console.WriteLine(" ");
   
int imin=0, imax=0;
   
for(int i=0; i<array.Length; i++) 
{
  if(array[i] >array[imax]) imax=i;
  if(array[i] <array[imin]) imin=i;
}
Console.WriteLine("min : array["+imin+"] = "+array[imin]);
Console.WriteLine("max : array["+imax+"] = "+array[imax]);
   
Console.WriteLine($"max - min = {array[imax] -array[imin]}");