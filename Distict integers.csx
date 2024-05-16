/*
Write a function to return an array containing 
all elements common to two given arrays containing distinct positive integers. 
You should not use any inbuilt methods. You are allowed to use any number of arrays.
The signature of the function is:
int[] f(int[] first, int[] second)
*/
using System;


int[] f(int[] first, int[] second)
{
    if (first == null || second == null) return null;
    
    int[] arrM = new int[4];
    int counter = 0;
    Array.Sort(first);
    Array.Sort(second);
    for (int i = 0; i < first.Length; i++)
    {
        for (int j = 0; j < second.Length; j++)
        {
            if (second[j] == first[i])
            {
                arrM[counter++] = first[i];
            }
            if (second[j] > first[i]) break;
        }
    }
    int[] returnArry = new int[counter];
    for (int x = 0; x < counter; x++)
    {
        returnArry[x] = arrM[x];
    }
    return returnArry;
}

int[] arrA = null;
int[] arrB = {4, 5, 7};

int[] result = new int[5];
result = f(arrA, arrB);

foreach (var item in result)
{
    Console.WriteLine(item);
}