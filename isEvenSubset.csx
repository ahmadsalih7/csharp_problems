using System;

int isEvenSubset(int m, int n)
{
    for (int i = 2; i < m; i += 2)
    {
        if (m % i == 0 && n % i == 0)
            return 1;
    }
    return 0;
}

int isEvenSubset2(int m, int n)
{ 
    int div;
    for (int i = 2; i < Math.Sqrt(m); i++)
    {
        if (i%2== 0 && m % i == 0)
        {
            if (n % i != 0) return 0;
        }
        
        div = m / i;
        if (div%2==0)
        {
            if (n % div != 0) return 0;
        }
    }
    return 1;
}

Console.WriteLine(isEvenSubset2(18, 32));
