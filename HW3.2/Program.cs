 
 int numberA = int.Parse(Console.ReadLine());
            int sum = 0;
            while (numberA > 0)
            {
                sum = sum + numberA % 10;
                numberA = numberA / 10 ;
            }

 Console.WriteLine(sum);
