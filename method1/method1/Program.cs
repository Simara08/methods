using System;

namespace method1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 8, 2, 5, 7 };
            Console.WriteLine("Massivin en boyuk elementi");
            
            Console.WriteLine(Array(num));
        }
    
    
    static int Array(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max<a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
    
    
    }
}
