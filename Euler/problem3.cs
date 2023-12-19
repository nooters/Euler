using System;
using System.Runtime.CompilerServices;
internal class problem3
{
public static void Main3()
{
    double primeFactors = 600851475143;
    double factor = 0;
    double sqrt_main = primeFactors / 2;
    bool found = false;
    //Step 1: Find factors of input number
    //Factor pairs will match up after the square root of a number is either reached or surpassed
    for(int i = 2; i <= sqrt_main; i++)
    {
        if(primeFactors % i == 0)
        {
            factor = primeFactors / i;
            Console.WriteLine("{0} is a valid factor", factor);
            double sqrt_factor = Math.Sqrt(factor);
            //Step 2: Find out if that factor is prime
            for(int f = 2;; f++)
            {
                if(f <= sqrt_factor && factor % f == 0)
                {
                    Console.WriteLine("{0} is not prime...", factor);
                    break;
                }
                else if(f > sqrt_factor + 1)
                {
                    //Since we're going from largest factors to smallest, we can stop after the first instance of a prime factor is found.
                    found = true;
                    break;
                }
            }
        }
        if(found)
        {
            break;
        }
    }
    Console.WriteLine("{0} is the largest prime factor of {1}", factor, primeFactors);

    

}
}