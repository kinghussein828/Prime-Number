/************************************************************/
/*File Info    : program that Checking for prime numbers               */
/*Version     : v1.0                                                                                 */
/*Date         : 12\11\2021                                                                      */
/*Author      : Hussein Mohamad ELnaggar                                             */
/************************************************************/
using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        int n, i, m = 0, check = 0;
        Console.Write("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2; // to reduce the number of iterations
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Number is not Prime.");
                check = 1;
                break;
            }
        }
        if (check == 0)
            Console.Write("Number is Prime.");
    }
}