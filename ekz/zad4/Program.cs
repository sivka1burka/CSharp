using System;
using System.Linq;
using System.Collections.Generic;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char[][] mass = new char[3][];
            mass[0] = new char[3];
            mass[1] = new char[2];
            mass[2] = new char[4];

            mass[0][0] = 'C';
            mass[0][1] = 'A';
            mass[0][2] = 'E';

            mass[1][0] = 'Z';
            mass[1][1] = 'Q';

            mass[2][0] = 'L';
            mass[2][1] = 'J';
            mass[2][2] = 'K';
            mass[2][3] = 'S';

            List<char> A = new List<char>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write(mass[0][i]+" ");
                A.Add(mass[0][i]);
                
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Write(mass[1][i] + " ");
                A.Add(mass[1][i]);
             
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(mass[2][i] + " ");
                A.Add(mass[2][i]);
               
            }
            var B = A.OrderBy(x => x);
            Console.WriteLine();
           
            char[] C = new char[9];
            int j = 0;
            foreach (var item in B)
            { 
                
                C[j] = item;
                j++;
            }
            j = 0;
            Console.WriteLine("-----------");
            for (int i = 0; i < 3; i++)
            {
                mass[0][i]=C[j];
                Console.Write(mass[0][i] + " ");
                j++;
                

            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                mass[1][i] = C[j];
                Console.Write(mass[1][i] + " ");
                j++;
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                mass[2][i] = C[j];
                Console.Write(mass[2][i] + " ");
                j++;
            }




        }
    }
}
