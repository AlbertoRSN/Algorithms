/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Program {
  static void Main() {
      
    Random random = new Random();
    int min = 0, max = 1000;
    bool found = false;
    int secretNumber = random.Next(min, max);
    int myNumber;
    
    do{
        Console.WriteLine("Tell me your number between [{0},{1}]: ", min, max);
        myNumber = Convert.ToInt32(Console.ReadLine());
        
        if(myNumber > secretNumber){
           Console.WriteLine("The secret number is SMALLER");
           max = myNumber;
        }
        else if(myNumber < secretNumber){
            Console.WriteLine("The secret number is BIGGER");
            min = myNumber;
        }
        else{//(myNumber == secretNumber){
            found = true;
            Console.WriteLine("Very Good! You found number. The secretNumber -> {0}", secretNumber);
        }
        
    }while(!found);

  }
}