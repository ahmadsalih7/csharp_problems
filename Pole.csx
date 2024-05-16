int f(int[] a)
{
    int[] sumRight = new int[a.Length];
    int[] sumLeft = new int[a.Length];

    sumLeft[0] = a[0];
    sumRight[0] = a[a.Length - 1];
    for (int i = 1; i < a.Length; i++)
    {
        sumLeft[i] = sumLeft[i - 1] + a[i];
        sumRight[i] = sumRight[i - 1] + a[a.Length - 1 - i];
    }
    for (int i = 1; i < a.Length; i++)
    {
        if (sumLeft[i - 1] == sumRight[a.Length - 2 - i])
        {
            try
            {
                Console.WriteLine($"There is a pole and its {i}");
                break;
            }
            catch (System.Exception ex)
            {
                break;
            }

        }
    }
    //     foreach (var item in sumLeft)
    //     {
    //         Console.WriteLine(item);
    //     }
    //     foreach (var item in sumRight)
    //     {
    //         Console.WriteLine(item);
    //     }
    return 0;
}

int[] b = { 2, 1, 1, 1, 2, 1, 7 };
f(b);
