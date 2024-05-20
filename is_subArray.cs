using System;

int isSub (int[] a, int len) {
    // register the sum of the array
    int sum = a.Sum();
    foreach (int n in a)
    {   // sum not including the current number
        sum -= n;
        // if n not greater thatn sum => reutrn 0
        if (n <= sum) return 0;
    }
    return 1;

}

Console.WriteLine(isSub(new int[] {13, 6, 3, 2},
                        4));