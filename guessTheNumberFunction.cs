/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program {

    public static int GuessTheNumber(int a, int b){
        int steps = 0;
        Random random = new Random();
        int secretNumber = random.Next(a, b);
        bool notFound = true;
        int letItBe;

        while(notFound){
            letItBe = (a+b)/2;
            if(secretNumber == letItBe){
                notFound = false;
            }
            if(secretNumber > letItBe){
                a = letItBe;
            }
            else{
                b = letItBe;
            }
            steps++;
        }
        return steps;
    }



  static void Main() {
      
    int a = 0;  int b = 2000;
    Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b,  GuessTheNumber(a, b));
    
    a = 0;  b = 1000;
    Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b,  GuessTheNumber(a, b));

    a = 0;  b = 10000;
    Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b,  GuessTheNumber(a, b));
    
    a = 0;  b = 100000;
    Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b,  GuessTheNumber(a, b));
    
    a = 0;  b = 1000000;
    Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b,  GuessTheNumber(a, b));

    a = 0;  b = 1000000000;
    Console.WriteLine("a = {0}, b = {1}, steps = {2}, ", a, b,  GuessTheNumber(a, b));

    Console.WriteLine(Math.Pow(2,14));
  }
}