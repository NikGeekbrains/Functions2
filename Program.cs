int[] mas = new int[10];
void metod()
{
    for(int i = 0; i < mas.Length; i++)
    {
    var chislo = new Random();
    mas[i] = chislo.Next(100, 1000);
    }
    
    int count = 0;
    for (int j = 0; j < mas.Length; j++)
    {
    if (mas[j] % 2 == 0)
    {
      count ++;
    }
    }

for (int j = 0; j < mas.Length; j++)
    {
    Console.Write(mas[j] + " ");
    }
    Console.WriteLine();
    Console.WriteLine(count);
}

metod();

int sum = 0;
void metod2()
{
    for(int i = 0; i < mas.Length; i++)
    {
    var chislo = new Random();
    mas[i] = chislo.Next();
    }

    for (int j = 0; j < mas.Length; j++)
    {
    if (j % 2 != 0)
    {
      sum += mas[j];
    }
    }

    for (int j = 0; j < mas.Length; j++)
    {
    Console.Write(mas[j] + " ");
    }
    Console.WriteLine();
    Console.WriteLine(sum);
}

metod2();

double [] mas2 = new double[10];
void metod3()
{
    for(int i = 0; i < mas2.Length; i++)
    {
    var newfloat = new Random();
    mas2[i] = newfloat.NextDouble();
    }

    double min = mas2[0];
    double max = mas2[0];
    for (int j = 0; j < mas2.Length; j++)
    {       
           if (mas2[j] < min)
           {
            min = mas2[j];
           } 

           if (mas2[j] > max)
           {
            max = mas2[j];
           } 
    }

    double rez = max - min;

    for (int j = 0; j < mas2.Length; j++)
    {
    Console.Write(mas2[j] + " ");
    }
    Console.WriteLine();
    Console.WriteLine(rez);
}

metod3();
