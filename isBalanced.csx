using System;

int isBalanced(int[] a)
{
    List<int> check = new List<int>();
    foreach (var item in a)
    {
        if (check.Contains(-item))
            check.Remove(-item);
        else
            check.Add(item);
    }
    if (check.Count() == 0)
        return 1;
    else
        return 0;
}

Console.WriteLine(isBalanced(new int[]  {-2, 3, 2, -3}));
