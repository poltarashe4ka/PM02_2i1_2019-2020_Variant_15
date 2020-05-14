using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace Test11
{
    class Program
    {
        static double f(double X)
        {
            return 3 * Math.Pow(X, 3) - 2 * Math.Pow(X, 2);         
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.InputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("Введите X:");             
            string T = Console.ReadLine();
            int X = Convert.ToInt32(T);             
            int I;             
            double O = 0;             
            for (I = 1; I <= X; I++) 
            X = X + f(I);
            Console.WriteLine("Результат: {0}", X);
            Console.ReadLine();
        }
    }
}
