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
        //static void Zeidel(int size, double eps, double[,]matrix)
        //{
        //    double[] previousVariableValues = new double[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        previousVariableValues[i] = 0.0;
        //    }
        //    int count = 0;
        //    while (true)
        //    {
        //        // Введем вектор значений неизвестных на текущем шаге
        //        double[] currentVariableValues = new double[size];

        //        // Посчитаем значения неизвестных на текущей итерации
        //        // в соответствии с теоретическими формулами
        //        for (int i = 0; i < size; i++)
        //        {
        //            // Инициализируем i-ую неизвестную значением
        //            // свободного члена i-ой строки матрицы
        //            currentVariableValues[i] = matrix[i, size];

        //            // Вычитаем сумму по всем отличным от i-ой неизвестным
        //            for (int j = 0; j < size; j++)
        //            {
        //                // При j < i можем использовать уже посчитанные
        //                // на этой итерации значения неизвестных
        //                if (j < i)
        //                {
        //                    currentVariableValues[i] -= matrix[i,j] * currentVariableValues[j];
        //                }

        //                // При j > i используем значения с прошлой итерации
        //                if (j > i)
        //                {
        //                    currentVariableValues[i] -= matrix[i, j] * previousVariableValues[j];
        //                }
        //            }

        //            // Делим на коэффициент при i-ой неизвестной
        //            currentVariableValues[i] /= matrix[i, i];
                   
                    
        //        }

        //        // Посчитаем текущую погрешность относительно предыдущей итерации
        //        double error = 0.0;

        //        for (int i = 0; i < size; i++)
        //        {
        //            error += Math.Abs(currentVariableValues[i] - previousVariableValues[i]);
        //        }

        //        // Если необходимая точность достигнута, то завершаем процесс
        //        if (error < eps)
        //        {
        //            break;
        //        }
               
                  
               
           
        //        // Переходим к следующей итерации, так
        //        // что текущие значения неизвестны
        //        // становятся значениями на предыдущей итерации
        //        previousVariableValues = currentVariableValues;
        //        count++;
        //        Console.WriteLine( count + "я итерация" + "\nОшибка: " + error + "\nРешения системы:");
        //        for (int i = 0; i < size; i++)
        //        {
                    
        //            Console.WriteLine("x" + (i + 1) + " " + previousVariableValues[i] + " ");
        //        }
                
                
        //    }

        //    // Выводим найденные значения неизвестных
           
        //    Console.WriteLine("Общее количество итераций: " + count);
            
        //}
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
