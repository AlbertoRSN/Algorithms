using System;

class Program
{
    
    public static int Fibonacci(int n)
    {
        int a = 1;
        int b = 1;
        int temp = 0;
        
        for (int i = 0; i < n; i++)
        {
            temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static int FibonacciRecursive(int n)
    {
        if ((n == 0) || (n == 1))
            return 1;
        else
            return FibonacciRecursive(n-1) + FibonacciRecursive(n-2);
    } 

    static void Main()
    {
        for (int i = 0; i < 15; i++)
        {
            Console.Write(Fibonacci(i) + ", ");
        }
        
        Console.WriteLine("\nFibonacci Iterative");
        Console.WriteLine(Fibonacci(5));
        
        Console.WriteLine("Fibonacci Recursive");
        Console.WriteLine(FibonacciRecursive(5));

        
    }
}


