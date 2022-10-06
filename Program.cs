
Console.WriteLine("Ведiть два числа.");
int numb1, numb2;
string stringNumb1 = Console.ReadLine();
numb1 = Convert.ToInt32(stringNumb1);
string stringNumb2 = Console.ReadLine();
numb2 = Convert.ToInt32(stringNumb2);

if (numb1 < numb2)
{
    int summ = 0;
    for (int i = numb1 ; i <= numb2; i++)
    {
        summ += i;
    }
    Console.WriteLine(summ);
}
else if (numb1 > numb2)
{
    int summ = 0;
    for (int i = numb2; i <= numb1; i++)
    {
        summ += i;
    }
    Console.WriteLine(summ);
}
else if (numb1 == numb2)
{
    Console.WriteLine(numb1);
}









