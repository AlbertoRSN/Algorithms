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
    bool found = true;
    int secretNumber = random.Next(min, max);
    int letItBe;
    int steps = 0;

Console.WriteLine("Secret Number -> {0}", secretNumber);

    while(found){
    
        
        letItBe = (min+max)/2;

        if(letItBe == secretNumber){
            found =false;
            Console.WriteLine("Very Good! You found number. The secretNumber -> {0} in {1} steps.", secretNumber, steps);

        }

        if(letItBe > secretNumber){
           min = letItBe;
        }
        else{
            max = letItBe;
        }
        steps++;
        
    };
  }
}