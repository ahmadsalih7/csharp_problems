using System;

int isTwinoid(int[] a)
{
    int twinoid = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0)
        {
            if (a[i + 1] % 2 == 0)
            {
                twinoid = 1;
                i++;
            }
            else
                return 0;
        }
    }
    return twinoid;
}

Console.WriteLine(isTwinoid(new int[] {3, 8, 5, 7, 3} ));
