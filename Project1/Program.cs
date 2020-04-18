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
            int[] x_values = new int[4] {1,3,5,7};
            int x = rnd.Next(x_values.Length);
            int X = x_values[x];
            int W_y = 0;
            int W_x = X;

            
            board( 0, X);

            PLayer_Wolf(ref W_y,ref W_x); 
            PLayer_Wolf(ref W_y,ref W_x);
            PLayer_Wolf(ref W_y,ref W_x);
            PLayer_Wolf(ref W_y,ref W_x);
            PLayer_Wolf(ref W_y,ref W_x);

        }
        

        /// <summary>
        /// This will show the commands to the player and then asks for a choice
        /// Then after choosing we call the method <see cref="Wolf_movement"/> 
        /// </summary>
        /// <param name="W_y">Position of the Wolf in Y coodinates</param>
        /// <param name="W_x">Position of the Wolf in X coodinates</param>
        private static void PLayer_Wolf (ref int W_y, ref int W_x)
        {
            string str;
            int Movement;
            Console.WriteLine("Wolf Commands");
            Console.WriteLine("1. \u2B09 2. \u2B08 ");
            Console.WriteLine("3. \u2B0B 4. \u2B0A ");
            str = Console.ReadLine();
            Movement = int.Parse(str);
            Wolf_movement(Movement,ref W_y,ref W_x);
            
        }


        /// <summary>
        /// This method after the player´s <see cref="choice"/> will change the
        /// coordinates
        /// </summary>
        /// <param name="choice">Choices are 1 through 4 and each 
        /// represents a direction</param>
        /// <param name="Wy">Position of the Wolf in Y coodinates</param>
        /// <param name="Wx">Position of the Wolf in X coodinates</param>
        private static void Wolf_movement ( int choice, ref int Wy , ref int Wx)
        {
            switch (choice)
            {
                //Up-left
                case 1 :
                    Wy -= 1;
                    Wx -= 1;
                    board(Wy,Wx);
                    break;
                //Up-right
                case 2 :
                    Wy -= 1;
                    Wx += 1;
                    break;
                //Down-left
                case 3 :
                    Wy += 1;
                    Wx -= 1;
                    board(Wy,Wx);
                    break;
                //Down-right
                case 4:
                    Wy += 1;
                    Wx += 1;
                    board(Wy,Wx);
                    break;

            }
        }
        /// <summary>
        /// Draws the board with the position of the wolf
        /// </summary>
        /// <param name="Wy">Position of the Wolf in Y coodinates</param>
        /// <param name="Wx">Position of the Wolf in X coodinates</param>
        private static void board(int Wy , int Wx) 
        {
            string [,] matrix;
            int lins = 8, cols = 8;

            //Inicialize the matrix
            matrix = new string [8,8];

            //show position of wolf

            //Fill the matrix with empty spaces
            for (int i = 0; i < lins; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix [i,j]= "   ";
                }
            }

            matrix[Wy,Wx] = " W ";

            
            // show the matrix
            for (int i = 0; i < lins; i++)
            {
                Console.WriteLine("  ---------------------------------");
                Console.Write((i + 1) + " ");
                for (int j = 0; j < cols; j++)
                    Console.Write( "|" +  matrix[i, j]);
                Console.WriteLine("|");
            }
            Console.WriteLine("  ---------------------------------");
            Console.WriteLine("    A   B   C   D   E   F   G   H  ");
        }
    }
}
