using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool dollars)
        {
            if (dollars == false)
            {
                return $"{a + b}";
            }
            else if (dollars == true && a + b == 1)
            {
                return $"{a + b} dollar";
            }
            else
            {
                return $"{a + b} dollars";
            }
            
        }

        static void Main(string[] args)
        {
            var two = Add(1, 6);
            Console.WriteLine(two);
            var howMuchMoney = Add(6, 111, true);
            Console.WriteLine(howMuchMoney);
            var dot = Add(5.6, 9.9);
            Console.WriteLine(dot);
        }
    }
}
