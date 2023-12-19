using System;

internal class Menu
{
    public static void Main(string[] args)
    {
        string problem;
        do
        {
            
            int numeral;
            Console.WriteLine("Enter a problem to run or X to exit:");
            Console.WriteLine();

            problem = Console.ReadLine();
            bool num1 = int.TryParse(problem, out numeral);
            if(num1)
            {
                switch(numeral)
                {
                    case 1:
                        problem1.Main1();
                        break;
                    case 2:
                        problem2.Main2();
                        break;
                    case 3:
                        problem3.Main3();
                        break;
                    default:
                        break;
                }
            }
            if(problem == "X" || problem == "x")
            {
                break;
            }
        } while (true);
        
    }
}