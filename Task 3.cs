using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class Task
            int nRows;

            Console.WriteLine("Write any number between 3-9:");
            Console.ReadLine();
            do
            {
                Console.WriteLine("Write any number between 3-9:");
                nRows = Convert.ToInt32(Console.ReadLine());
            } while (nRows < 3 || nRows > 9);

            int[][] matrix = new int[nRows][];

            int n = 0;
            for (int row = 0; row < matrix.Length; row++, n++)
            {
                matrix[row] = new int[row + 1];
                
                for(int clm = 0; clm < matrix[row].Length; clm++)
                {
                    matrix[row][clm] = n;
                }
                
            }
            
            foreach(int[] Row in matrix)
            {
                foreach (int Clm in Row)
                {
                    Console.WriteLine(Clm + ",");
                }
            }
            
            
            
            
            
            
            //Home Work
            
            string[][] matrix1 = new string[3][] {
                new string [0]{"Main", "Up" , "Sub"},
                new string [1]{"Down", "Center" ,"Sub"},
                new string [2]{"Main", "Up" , "Sub"}
            };
            foreach (string[] Row in matrix1)
            {
                foreach (string Colm in Row)
                {
                    Console.Write($"[{Colm}]");
                }
                Console.WriteLine();
            }
            
            }
            
        }
    }

