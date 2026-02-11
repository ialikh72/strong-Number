using System;
class Strong
{
    static void Main()
    {
        Console.WriteLine("enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=num; i++)
        {
            int sum = 0;
            int temp = i;
            while(temp > 0)
            {
                int rem = temp % 10;
                sum += Factorial(rem);
                temp /= 10;
            }
            if(sum == i)
            {
                Console.WriteLine(i + " is a strong number.");
            }
        }
    }
    static int Factorial(int n)
    {
        int fact = 1;
        for(int i =1; i<=n;i++)
        {
            fact *= i;
        }
        return fact;
    }
}