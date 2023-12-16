using System;

internal class problem1
{
public static void Main1()
{
    int total = 0;
    for(int i = 1; i < 1000; i++)
    {
        if(i % 3 == 0 || i % 5 == 0)
        {
            Console.WriteLine("{0} is a valid multiple!", i);
            total += i;
        }
    }
    Console.WriteLine("The total of the multiples is {0}", total);
}

}