using System;
using System.ComponentModel.DataAnnotations;

int isSym(int[] a) { 
    int len = a.Length;
    for (int i =0; i < len; i++) {
        // copmare first and last elemet
        if ((a[i] % 2)!=(a[len-1-i] % 2)) return 0;
    }
    return 1;
}

Console.WriteLine(isSym(new int[] {2, 7, 9, 10, 11, 5, 8}));