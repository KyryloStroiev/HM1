using System;


int a = 6, b = 8;

int max()
{
    return Math.Max(a, b);
}
Console.WriteLine($"Максимальне число {max()}");
int min()
{
    return Math.Min(a, b);
}
Console.WriteLine($"Мiнiмальне число {min()}");


bool summ()
{
   
    int summ = 0;
    if (a < b)
    {

        for (int i = a; i <= b; i++)
        {
            summ += i;
        }

    }
    else if (a > b)
    {

        for (int i = b; i <= a; i++)
        {
            summ += i;
        }
    }
    if (summ % 2 == 0)
    {
        return (true);
    }
    else
    {
        return (false);
    }
}
Console.WriteLine(summ());

public class Test
{
    int a = 3, b = 5;
    int max()
    {
        return Math.Max(a, b);
        Console.WriteLine($"Максимальне число {max()}");
    }
    int max(int c = 4, int d = 5)
    {
        return Math.Max(Math.Max(a,b), Math.Max(c,d));
        Console.WriteLine($"Максимальне число {max()}");
    }
  
    int min()
    {
        return Math.Max(a, b);
        Console.WriteLine($"Максимальне число {max()}");
    }
    int min(int c = 7, int d = 9)
    {
        return Math.Max(Math.Max(a, b), Math.Max(c, d));
        Console.WriteLine($"Максимальне число {max()}");
    }




}
