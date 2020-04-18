using System;
using System.Text;


namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //variables
            Random rnd = new Random ();
            string str;
            int Movement ;
            int[] x_values = new int[4] {1,3,5,7};
            int x = rnd.Next(x_values.Length);
            int X = x_values[x];
            int W_y = 0;
            int W_x = X;
            int Test = new Tuple<int,int>(1,2);
            
            board(W_y,W_x);
            Console.WriteLine("Wolf Commands");
            Console.WriteLine("1. \u2B09 2. \u2B08 ");
            Console.WriteLine("3. \u2B0B 4. \u2B0A ");
            Console.WriteLine(Test);
            str = Console.ReadLine();
            Movement = int.Parse(str);
            //W_y,W_x = Wolf_movement(Movement,W_y,W_x);
            Console.Write(X);
            
        }
        // Draws the Board
        private static void board(int Wy , int Wx) 
        {
            string [,] matrix;
            int lins = 8, cols = 8;

            //Inicialize the matrix
            matrix = new string [8,8];

            //show position of wolf
            matrix[Wy,Wx] = "W";

            //Fill the matrix with empty spaces
            for (int i = 0; i < lins; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix [i,j]= "  ";
                }
            }

            matrix[Wy,Wx] = "W";

            
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
         private static void Wolf_movement ( int choice, int Wy , int Wx)
        {
            switch (choice)
            {
                case 1 :

                    break;
                case 2 :
                    break;
                case 3 :
                    break;
                case 4:
                    break;

            }
        }
    }
}