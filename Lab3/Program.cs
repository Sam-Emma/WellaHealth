using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prime numbers have just two factors - 1 and the number itself
                int factor = 0;                 //counts the number of factors as we check the modulo in the loop
                Console.WriteLine("Enter a number to check: ");
                int number = int.Parse(Console.ReadLine()); //collects the number to be checked

                //loop to count the number of factors of a number
                for (int i = 1; i<=number;i++){    //loops runs from 1 to the number itself
                    if(number % i == 0){            //modulo to check if variable i is a factor of number
                        factor++;                   //factor is incremented if a factor is found
                    }
                }

                //condition to check if a number is prime based on the number of factors
                if(factor == 2){            //prime numbers have just two factors
                    Console.WriteLine("Prime number");
                }
                else{
                    Console.WriteLine("Not prime number");
                }
        }
    }
}
