using System;

//namespace ConsoleApp1
namespace std
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[]  array = new int[3]; 
            for ( int j = 1; j < 3; j++)
            {
                array[j]  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(array[j]);
            }
            int i = Convert.ToInt32(Console.ReadLine());
         
            if (i <= 5) 
            {
                Console.WriteLine("Hello World!");
                Console.ReadLine();
            }else Console.WriteLine("try agen leter");
        }
    }
}
//просто здравствуй)))
/* как
 * ты 
 * думаешь
 * все норм?*/