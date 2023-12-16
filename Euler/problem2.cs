using System;

internal class problem2
{
public static void Main2()
{
    //Fib. Sequence numbers are the previous two numbers in the sequence added together
    int a = 1;
    int b = 2;
    int total = 0;
    Console.WriteLine(a);
    while(b < 4000000)
    {
        Console.WriteLine(b);
        if(b % 2 == 0)
        {
            total += b;
        }
        b += a;
        a = b - a;
        //Since b becomes b + a, you can just remove a from current b to get previous b to then place in a
    }
    Console.WriteLine("The sum of the even fibonacci numbers under 4000000 equals {0}", total);

}
}