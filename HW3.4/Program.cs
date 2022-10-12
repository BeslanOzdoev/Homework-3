Console.Write("Задайте диапазон чисел: ");

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
int numberD = int.Parse(Console.ReadLine());
int numberE = int.Parse(Console.ReadLine());

int[] array = new int[] {numberA, numberB, numberC, numberD, numberE};
int i=0;
double pow=Math.Pow(array[i],3);
for(i=0;i<array.Length;i++)
 
    if((array[i] % 2) == 0) 
    {
    pow=Math.Pow(array[i],3);
    System.Console.WriteLine($"{pow}");
    }
 
 
else
{
    System.Console.WriteLine("Число заканчивается на нечетную цифру");
}