using System;

int[] fill(int[] arr, int k, int n)
{
    if (k == 0)
        return null;
    int[] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = arr[i % k];
        Console.WriteLine(result[i]);
    }
    return result;
}

fill(new int[] { 1, 2, 3, 5, 9, 12, -2, -1 }, 3, 10);
