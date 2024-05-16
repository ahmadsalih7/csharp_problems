using System;

bool hasKSmallFactors(int k, int n)
{
    if (k < 0 || n < 0 || (k - 1) * (k - 1) < n)
        return false;
    
    for (int i = 1; i < k; i++)
    {
        if (n % i == 0 && n / i < k) 
            return true;
    }
    return false;
}

hasKSmallFactors(10,20);
