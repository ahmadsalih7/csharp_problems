/*Question 10
A fancy number is a number in the sequence 1,1,5,17,61,... Note the first two fancy numbers
are 1 and any fancy number other than the first two is sum of three times previous one and two times
the one before that. see below*/

int isFancy(int a){
    // create the fancy numbers array
    int preprevious = 1;
    int previous = 1;
    int current = 5;
    int temp;

    while (current <= a)
    {
        temp = previous*3 + preprevious *2;
        if (temp == a) return 1;
        preprevious = previous;
        previous = current;
        current = temp;
        Console.WriteLine(current);
    } 
    return 0;
}

Console.WriteLine(isFancy(1200));