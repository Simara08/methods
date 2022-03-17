using System;

namespace method2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ededi daxil edin");
            Console.WriteLine(Num(int.Parse(Console.ReadLine())));
            
        }

        static int Num(int a)
        {
            
            int count = 0;
            int b=a;
            while (b!=0)
            {
                //for (int i = 0; i < b; i++)
                //{
                
                if (b % 2 == 1)
                    {
                    b = b / 2;
                    count++;
                    }
                else
                {
                    b = b / 2;
                }
               



            }
            return count;
        }
    }
}
