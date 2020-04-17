using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int[,] matriz = new int[8, 8];

            //fazer lobo
            //fazer ovelhas
            //pedir input do jogador lobo
            //pedir input do jogador ovelha
            board();
        }
        // Draws the Board
        static void board() 
        {
            string horizontalbar = "---------------------------------";
            string verticalbar = "| ";
            string Numbers = ("1 2 3 4 5 6 7 8");
            string letters = ("A B C D E F G H");
            int lins = 8, cols = 8, i, j;
            int[,] m = {  {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8},
                                            {1,2,3,4,5,6,7,8}, };

            for (i = 0; i < lins; i++)
            {
                Console.WriteLine(horizontalbar);
                for (j = 0; j < cols; j++)
                    Console.Write(verticalbar + "{0} ", m[i, j]);
                Console.WriteLine(verticalbar);
            }
        }
    }
}
