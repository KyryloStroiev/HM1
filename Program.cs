
//- 6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15 x ^ 3 + 5 * x ^ 2 - 10 * x + 15
{
    Console.WriteLine("Пiдставте X до формули: -6*x^3+5*x^2-10*x+15 ");
    Console.WriteLine("Ведiть число Х");
    int a = 0;
    string stringA = Console.ReadLine();
    a = Convert.ToInt32(stringA);
    double b = (-6 * (Math.Pow(a, 3)) + 5 * (Math.Pow(a, 2)) - 10 * a + 15 * (Math.Pow(a, 3)) + 5 * (Math.Pow(a, 2)) - 10 * a + 15);
    Console.WriteLine($"Результат: {b}  ");
}

// abs(x) * sin(x)
{
    Console.WriteLine("Дiзнатись число Х в формулi: abs(x)*sin(x) ");
    Console.WriteLine("Ведiть число Х");
    int a = 0;
    string stringA = Console.ReadLine();
    a = Convert.ToInt32(stringA);
    decimal b = Math.Abs(a);
    decimal c = (decimal)Math.Sin(a);
    decimal d = b * c;
    Console.WriteLine($"Результат {d}");

}

// 2 * pi * x 
{
    Console.WriteLine("Ведiть радiус кола");
    int radius = 0;
    string stringRadius = Console.ReadLine();
    radius = Convert.ToInt32(stringRadius);
    double circumference = 2 * Math.PI * radius;
    Console.WriteLine($"Окружнiсть кола: {circumference}");

}

// max(x, y)
{
    Console.WriteLine("Яке з чисел бiльше?");
    Console.WriteLine("Ведiть перше число:");
    int a = 0;
    string stringA = Console.ReadLine();
    a = Convert.ToInt32(stringA);
    Console.WriteLine("Ведiть друге число:");
    int b = 0;
    string stringB = Console.ReadLine();
    b = Convert.ToInt32(stringB);
    int c = Math.Max(a, b);
    Console.WriteLine($"Бiльше число: {c} ");

}

{

    DateTime dateNow = (DateTime.Now);
    DateTime dateNewYear = new DateTime(2023, 01, 01, 00, 00, 01);
    DateTime dateLastNewYear = new DateTime(2022, 01, 01, 00, 00, 01);
    Console.WriteLine($"До Нового року залишилось: {dateNewYear.Subtract(dateNow)}");
    Console.WriteLine($"Новий рiк був: {dateNow.Subtract(dateLastNewYear)}");
}
Console.ReadKey();
