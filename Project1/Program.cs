using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables


            board();
        }
        // Draws the Board
        static void board() 
        {
            string [,] matrix;
            int lins = 8, cols = 8;

            //Inicialize the matrix
            matrix = new string [8,8];

            //Fill the matrix with empty spaces
            for (int i = 0; i < lins; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix [i,j]= "  ";
                }
            }

            // show the matrix
            for (int i = 0; i < lins; i++)
            {
                Console.WriteLine("  -------------------------");
                Console.Write((i + 1) + " ");
                for (int j = 0; j < cols; j++)
                    Console.Write( "|" +  matrix[i, j]);
                Console.WriteLine("|");
            }
            Console.WriteLine("  -------------------------");
            Console.WriteLine("    A   B   C   D   E   F  ");
        }
    }
}