static void Natural(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        Natural(m+1, n);
    }
    
}

static void SumNatural(int m, int n, int result)
{
    if (m < n+1)
    {
        result += m;
        m++;
        SumNatural(m, n, result);
    }
    else
    {
    Console.WriteLine($"{result} ");
    }
}

static int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return 0;
}


Console.WriteLine("Введите чило m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите чило n");
int n = int.Parse(Console.ReadLine());
int result = 0;
Console.WriteLine("все натуральнные числа в промежутке m n");
Natural(m,n);
Console.WriteLine();
Console.WriteLine("Сумма натуральных чисел m n");
SumNatural(m,n, result);
Console.WriteLine("Аккерман m n");
Console.WriteLine(Akkerman(m,n));