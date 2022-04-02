using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 variables with different data types
            int first = 34;
            float second = -34355;
            double third =  -45.3433;
            bool fourth = true;
            char fifth  = 'a';
            short sixth = 54;
            long seventh = 45354643;
            byte eighth = 3;
            decimal ninth = 454646;
            string tenth = "WellaHealth";
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
            Console.WriteLine(sixth);
            Console.WriteLine(seventh);
            Console.WriteLine(eighth);
            Console.WriteLine(ninth);
            Console.WriteLine(tenth);


            //Implicit typde conversion
            long eleventh = first;
            Console.WriteLine(eleventh);

            //Explicit type conversion
            int twelfth = (int) third;
             Console.WriteLine(twelfth);


        }
    }
}
