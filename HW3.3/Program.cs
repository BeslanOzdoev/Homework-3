Console.Write("Для того, чтобы вычислить произведение чисел от 1 до N, задайте число N:");
int numberA = int.Parse(Console.ReadLine());
int count = 1;
int prod = 1;
while (numberA > 0 && count <= numberA)
            {
                prod = prod * count;
                count = count + 1;
            }

 Console.WriteLine(prod);