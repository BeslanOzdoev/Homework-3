Console.Write("Для того, чтобы показать кубы всех чисел от 1 до N, задайте число N:");
int numberA = int.Parse(Console.ReadLine());
int count = 1;
int numberB = 1;
while (count <= numberA)
{
int numberC = numberB*numberB*numberB;
Console.WriteLine($"{numberC} является кубом числа {numberB}");
numberB++;
count++;
}
