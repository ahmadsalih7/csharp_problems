/* Write a function to reverse an integer using numeric operators 
and without using any arrays or other data structures.
The signature of the function is:
int f(int n)
*/
using System;
using System.Linq;

int f(int n)
{
    // declare an array to save the digits
    int[] digits = new int[10];
    // number of digits
    int nDigits = 0;
    // result
    double result = 0;
    // sign
    int sign = (n > 0) ? 1 : -1 ;
    n *= sign; // absolute value
    // populate the array using the numbers from n
    while (n > 0)
    {
        digits[nDigits++] = n % 10;
        n /= 10;
    }

    //recreate the number
    for (int i = 0; i < nDigits; i++)
    {
        result += digits[i] * Math.Pow(10, nDigits-i-1);
    }

    return (int) result*sign;

}
while (true)
{
    Console.Write("Enter input, enter s to stop ");
    string input = Console.ReadLine();
    if (input == "s") break;
    Console.WriteLine(f(Convert.ToInt32(input)));
}
