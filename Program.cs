
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
        Console.WriteLine(true);
        
    }
    else
    {
        Console.WriteLine(false);
        
    }
    return;
}
Console.WriteLine(summ());

   
   
   
