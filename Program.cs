using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = "";
            var input2 = "";


            Console.WriteLine("Please enter your first name then press enter");
            input1 = Console.ReadLine();

            Console.WriteLine("Please enter your last name then press enter");
            input2 = Console.ReadLine();


            Console.WriteLine($" {input1 }   {input2}");

            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            //done//

        }
    }
}
