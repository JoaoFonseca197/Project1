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
            int Gameover = 0;
            //Wolf Position
            int W_y = 0;
            int W_x = X;
            //Sheep 1 position
            int S1y = 7;
            int S1x = 0;
            //Sheep 2 position
            int S2y = 7;
            int S2x = 2;
            //Sheep 3 position
            int S3y = 7;
            int S3x = 4;
            //Sheep 4 position
            int S4y = 7;
            int S4x = 6;

            bool isWolfPlaying = true;
            //Game cicle
            do
            {
                board(W_y, W_x, S1y, S1x, S2y, S2x, S3y, S3x, S4y, S4x);
                if (isWolfPlaying)
                {
                    PLayer_Wolf(ref W_y, ref W_x);
                    isWolfPlaying = false;
                }
                else
                {
                    Player_Sheep(ref S1y, ref S1x, ref S2y, ref S2x,
                    ref S3y, ref S3x, ref S4y, ref S4x);
                    isWolfPlaying = true;
                }
                
            } while (Gameover != 1);//Mudar a condição conforme parametros de vitória

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
            char Movement;
            Console.WriteLine("Wolf Commands"); //testando se consegui fazer o commit
            Console.WriteLine("1. \u2B09 2. \u2B08 ");
            Console.WriteLine("3. \u2B0B 4. \u2B0A ");
            str = Console.ReadLine();
            Movement = char.Parse(str);
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
        private static void Wolf_movement ( char choice, ref int Wy , ref int Wx)
        {
            switch (choice)
            {
                //Up-left
                case '1':
                    if(Wy == 0 || Wx == 0)
                    {
                        Console.WriteLine("You can´t go that way");
                        PLayer_Wolf(ref Wy, ref Wx);
                    }
                    else
                    {
                        Wy -= 1;
                        Wx -= 1;
                    }
                    break;
                //Up-right
                case '2' :
                    if(Wy == 0 || Wx == 7)
                    {
                        Console.WriteLine("You can´t go that way");
                        PLayer_Wolf(ref Wy, ref Wx);
                    }
                    else
                    {
                        Wy -= 1;
                        Wx += 1;  
                    }
                    break;
                //Down-left
                case '3' :
                    if(Wy == 7 || Wx == 0)
                    {
                        Console.WriteLine("You can´t go that way");
                        PLayer_Wolf(ref Wy, ref Wx);
                    }
                    else
                    {
                        Wy += 1;
                        Wx -= 1;  
                    }
                    break;
                //Down-right
                case '4':
                    if(Wy == 7 || Wx == 7)
                    {
                        Console.WriteLine("You can´t go that way");
                        PLayer_Wolf(ref Wy, ref Wx);
                    }
                    else
                    {
                        Wy += 1;
                        Wx += 1; 
                    }
                    break;
                //in case of none of the above
                default :
                    Console.WriteLine("Invalid movement, please choose again.");
                    PLayer_Wolf(ref Wy, ref Wx);
                    break;
                


            }
        }

        /// <summary>
        /// Chooses one of the 4 sheeps available to move them
        /// </summary>
        /// <returns></returns>
        private static int Sheep_Choice()
        {
            string sheep;
            int Chosen_Sheep;
            Console.WriteLine("Choose one of the Sheeps:");
            Console.WriteLine("1, 2, 3, 4.");
            while (true)
            {
                sheep = Console.ReadLine();
                Chosen_Sheep = int.Parse(sheep);

                switch (Chosen_Sheep)
                {
                    case 1:
                        Console.WriteLine("Move Sheep 1");
                        return 1;
                    case 2:
                        Console.WriteLine("Move Sheep 2");
                        return 2;
                    case 3:
                        Console.WriteLine("Move Sheep 3");
                        return 3;
                    case 4:
                        Console.WriteLine("Move Sheep 4");
                        return 4;
                    default:
                        Console.WriteLine("Unvalid Sheep, please choose again.");
                        break;
                }
            }
        }

        /// <summary>
        /// Calls the function to choose which cheep
        /// Moves the selected cheep
        /// </summary>
        /// <param name="S1y">Sheep 1 Y Coordinate</param>
        /// <param name="S1x">Sheep 1 X Coordinate</param>
        /// <param name="S2y">Sheep 2 Y Coordinate</param>
        /// <param name="S2x">Sheep 2 X Coordinate</param>
        /// <param name="S3y">Sheep 3 Y Coordinate</param>
        /// <param name="S3x">Sheep 3 X Coordinate</param>
        /// <param name="S4y">Sheep 4 Y Coordinate</param>
        /// <param name="S4x">Sheep 4 X Coordinate</param>
        private static void Player_Sheep(ref int S1y, ref int S1x,
                                         ref int S2y, ref int S2x,
                                         ref int S3y, ref int S3x,
                                         ref int S4y, ref int S4x)
        {
            //Choose a Sheep
            int sChoice = Sheep_Choice();
            string str;
            int Movement;
            Console.WriteLine("Sheep Commands");
            Console.WriteLine("1. \u2B09 2. \u2B08 ");
            str = Console.ReadLine();
            while (str != "1" && str != "2")
            {
                Console.WriteLine("Invalid Movement, please try again");
                str = Console.ReadLine();
            }
            Movement = int.Parse(str);

            switch(sChoice)
            {
                case 1:
                    Sheep_Movement(Movement, ref S1y, ref S1x);
                    break;
                case 2:
                    Sheep_Movement(Movement, ref S2y, ref S2x);
                    break;
                case 3:
                    Sheep_Movement(Movement, ref S3y, ref S3x);
                    break;
                case 4:
                    Sheep_Movement(Movement, ref S4y, ref S4x);
                    break;
            }
        }

        /// <summary>
        /// Moves the previously selected cheep only in the upward direction
        /// </summary>
        /// <param name="sChoice"> Chosen Movement for the Sheep </param>
        /// <param name="sy"> Y coordinate for the selected Sheep </param>
        /// <param name="sx"> X coordinate for the selected Sheep </param>
        private static void Sheep_Movement(int sChoice, ref int sy, ref int sx)
        {
                switch (sChoice)
                {
                    //Up-left
                    case 1:
                        sy -= 1;
                        sx -= 1;
                        break;
                    //Up-right
                    case 2:
                        sy -= 1;
                        sx += 1;
                        break;
                }
        }

        /// <summary>
        /// Draws the board with the position of the wolf
        /// </summary>
        /// <param name="Wy">Position of the Wolf in Y coodinates</param>
        /// <param name="Wx">Position of the Wolf in X coodinates</param>
        private static void board(int Wy, int Wx,
                                  int S1y, int S1x,
                                  int S2y, int S2x,
                                  int S3y, int S3x,
                                  int S4y, int S4x) 
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
            matrix[S1y, S1x] = " 1 ";
            matrix[S2y, S2x] = " 2 ";
            matrix[S3y, S3x] = " 3 ";
            matrix[S4y, S4x] = " 4 ";
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
