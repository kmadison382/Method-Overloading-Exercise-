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
            string money;
            if (a + b == 1)
                {
                    money = $"{a + b} dollar";
                }
            else
                {
                    money = $"{a + b} dollars";
                }
                return money;
            
        }

        static void Main(string[] args)
        {
            var two = Add(5, 13);
            Console.WriteLine(two);
            var decimals = Add(5.4, 8.7);
            Console.WriteLine(decimals);
            var howMuchMoney = Add(1, 0, true);
            Console.WriteLine(howMuchMoney);
        }
    }
}
