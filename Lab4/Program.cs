using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int sum = first + second;
            if(sum < 100){
                Console.WriteLine("true");
            }else{
                Console.WriteLine("false");
            }

        }
    }
}
