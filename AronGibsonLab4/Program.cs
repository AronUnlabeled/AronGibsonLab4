using System;

namespace AronGibsonLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            String again = "y";
            int num;
            do {
                Console.WriteLine("Enter number between 1 and 1920 (inclusive)");
                num = int.Parse(Console.ReadLine());
                if (num < 1) {
                    Console.WriteLine("Must be between 1 and 1290 (inclusive)");
                }
                else if (num>1290) {
                    Console.WriteLine("Must be between 1 and 1290 (inclusive)");
                }
                else {

                    getSqauresAndCubesVoid(num);
                    Console.WriteLine("again? y or n");
                    again = Console.ReadLine();

                    while(again!="y" && again!="n"){
                        Console.WriteLine("you must enter y or n");
                        again = Console.ReadLine();
                    }
                }
            } while (again=="y");
        }

        public static void getSqauresAndCubesVoid(int num){
            Console.WriteLine("number   Squares    cubes");
            Console.WriteLine("======   ========   =========");


            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i,5}       {i * i,5}       {i * i * i,5}");   
            }
        }

    }
}
