/******************************************************************************

@Author: Alberto Rodríguez Santana
@Email: alberodrisanta@gmail.com

*******************************************************************************/
using System;
class HelloWorld {
    
    
    public static long Factorial(int n){
        long result = 1;
        
        for(int i=1; i<=n; i++){
            result *= i; //Iterative
        }
    
        return result;
    } 
    
    public static long FactorialRecursive(int n){
        if(n<2)
            return 1;
        
        return n*FactorialRecursive(n-1);
    }
    
  static void Main() {
    int n = 4;
    long result = Factorial(n);
    Console.WriteLine("!{0} Iterative = {1}\n", n, result);
    
    result = FactorialRecursive(n);
    Console.WriteLine("!{0} Recursive = {1}", n, result);
  }
}

