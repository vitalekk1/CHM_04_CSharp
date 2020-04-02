using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЧисАнМетодЗейделя
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int size = 4;
            double eps = 0.000000000001;
            double[,]matrix =
            {
                {76, 21, 6, -34, -142},
                {12, -114, 8, 9, 83},
                {16, 24, -100, -35, -121},
                {23, -8, 5, -75, 85}
            };
            Console.WriteLine("----------matrix --------");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Zeidel(size, eps, matrix);

           
        }
    }
}
