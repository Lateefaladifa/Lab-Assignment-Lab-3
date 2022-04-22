using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
     
          Console.WriteLine("Program to check Prime Number..."); 
          Console.Write("Please, Input your value..");    
          int number = int.Parse(Console.ReadLine());  
          int var = 0;
          var value = number/2;    
          for(int i = 2; i <= value; i = i + 1)    
          {    
           if(number % i == 0)    
            {    
             Console.WriteLine("It is not a Prime Number!");    
             var = 1;    
             break;    
            }    
          }    
          if (var==0)    
           Console.WriteLine("This is Prime Number!");  
            
        }
    }
}
