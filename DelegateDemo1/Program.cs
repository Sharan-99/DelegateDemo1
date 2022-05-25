using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo1
{
    public delegate int Calculation(int a, int b);
    class Program
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Subtract(int x,int y)
        {
            return x - y;
        }
        public int Multiply(int x,int y)
        {
            return x * y;
        }
        public int Divide(int x,int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Calculation calc = new Calculation(p.Add);
            int result = calc(25, 30);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
