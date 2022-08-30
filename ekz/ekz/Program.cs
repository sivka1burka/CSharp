//1.Заполнить матрицу А 3х3 числами 0 и 1 в случайном порядке. Заполнить матрицу B 3х3 числами 0 и 1 в случайном порядке. Получить матрицу С 3х3 в которой будут сохранены булевы значения равен ли элемент A[x, y] элементу B[x, y], подсчитать количество элементов со значением true, и со значением false.
//Например:
//{ 1, 0, 1 }
//{ 1, 1, 1}
//{ true, false, true}
//А = { 0, 1, 0 }
//B = { 1, 1, 1}
//C = { false, true, false}
//{ 1, 0, 1 }
//{ 1, 1, 1}
//{ true, false, true}
//Количество элементов true в матрице C : 5
//Количество элементов false в матрице C: 4

using System;

namespace ekz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] A = new int[3, 3];
            Console.WriteLine("A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    A[i, j] = rand.Next(0, 2);
                    Console.Write(A[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------");
            int[,] B = new int[3, 3];
            
            Console.WriteLine("B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B[i, j] = rand.Next(0, 2);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------");
            bool[,] C = new bool[3, 3];

            Console.WriteLine("C:");
            int amountTrue = 0;
            int amountFalse = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (A[i, j] == B[i, j])
                    {
                        C[i, j] = true;
                        amountTrue++;
                    }
                    else
                    {
                        C[i, j] = false;
                        amountFalse++;
                    }
                    Console.Write(C[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество элементов true в матрице C :"+amountTrue);
            Console.WriteLine("Количество элементов false в матрице C:"+amountFalse);


        }
    }
}
