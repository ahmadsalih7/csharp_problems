using System;

int isHollow(int[] a)
{
    int before = -1,
        counter = 0;
    bool zero = false,

    for (int i = 0; i < a.Length; i++)
    {   // no zero-sequence was found => do not check
        if (a[i] != 0 && zero == false) continue;
        // this first zero occurance 
        else if (a[i] == 0 && lastzero == false)
        {
            // register the last non-zero number
            before = a[i - 1];
            // register the index of zero
            zero = true;
            //start counting the zeros
            counter += 1;
        }
        // This is not the first zero
        else if (a[i] == 0)
        {
            // increament the counter
            counter += 1;
        }
        // non-zero after a zero sequence, check the conditions => return true
        else if (a[i] == before && counter >= 3)
        {
            return 1;
        }
        // non-zero after a zero sequent that does not meet the condiotn => reset
        else
        {
            zero = false;
            counter = 0;
        }
    }
    return 0;
}
Console.WriteLine(isHollow(new int[] {1,2,4,0,0,0,0,4,4,5}));
