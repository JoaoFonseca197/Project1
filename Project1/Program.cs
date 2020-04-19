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
            Random rnd = new Random();
            int[] x_values = new int[4] { 1, 3, 5, 7 };
            int x = rnd.Next(x_values.Length);
            int X = x_values[x];
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

            Console.WriteLine("\nWelcome To the Wolf and Sheeps Board Games!\n");
            Console.WriteLine("The Wolf is represented by the letter W.");
            Console.WriteLine("The Sheeps are represented by their names: 1, 2, 3 and 4.\n");
            Console.WriteLine("For the Wolf to Win the Game he must reach one of the Sheeps initial position.");
            Console.WriteLine("For the Sheeps to win the Game they must surround the Wolf.\n");
            Console.WriteLine("Follow the instructions given during the game to play.\n");
            Console.WriteLine("Write anything to start. Good Luck!");
            Console.ReadLine();

            bool IsWolfPlaying = true;
            //Game cicle
            do
            {
                board(W_y, W_x, S1y, S1x, S2y, S2x, S3y, S3x, S4y, S4x);
                if (IsWolfPlaying == true)
                {
                    PLayer_Wolf(ref W_y, ref W_x,
                    ref S1y, ref S1x,
                    ref S2y, ref S2x,
                    ref S3y, ref S3x,
                    ref S4y, ref S4x);
                    IsWolfPlaying = false;
                }
                else if (W_y == 7)
                {
                    Console.WriteLine("Wolf Wins The Game!");
                    break;
                }
                else if (IsWolfPlaying == false)
                {
                    Player_Sheep(ref S1y, ref S1x, ref S2y, ref S2x,
                    ref S3y, ref S3x, ref S4y, ref S4x, ref W_y, ref W_x);
                    IsWolfPlaying = true;

                }

            } while (true);//Mudar a condição conforme parametros de vitória

        }


        /// <summary>
        /// This will show the commands to the player and then asks for a choice
        /// Then after choosing we call the method <see cref="Wolf_movement"/> 
        /// </summary>
        /// <param name="W_y">Position of the Wolf in Y coodinates</param>
        /// <param name="W_x">Position of the Wolf in X coodinates</param>
        private static void PLayer_Wolf(ref int W_y, ref int W_x,
        ref int S1y, ref int S1x,
        ref int S2y, ref int S2x,
        ref int S3y, ref int S3x,
        ref int S4y, ref int S4x)
        {
            string str;
            char Movement;
            Console.WriteLine("Wolf Commands");
            Console.WriteLine("\u2B09 1.      2. \u2B08 ");
            Console.WriteLine("\u2B0B 3.      4. \u2B0A ");
            str = Console.ReadLine();
            Movement = char.Parse(str);
            Wolf_movement(Movement, ref W_y, ref W_x,
            ref S1y, ref S1x,
            ref S2y, ref S2x,
            ref S3y, ref S3x,
            ref S4y, ref S4x);


        }



        /// <summary>
        /// This method after the player´s <see cref="choice"/> will change the
        /// coordinates
        /// </summary>
        /// <param name="choice">Choices are 1 through 4 and each 
        /// represents a direction</param>
        /// <param name="Wy">Position of the Wolf in Y coodinates</param>
        /// <param name="Wx">Position of the Wolf in X coodinates</param>

        private static void Wolf_movement(int choice,
        ref int Wy, ref int Wx,
        ref int S1y, ref int S1x,
        ref int S2y, ref int S2x,
        ref int S3y, ref int S3x,
        ref int S4y, ref int S4x)
        {
            switch (choice)
            {
                //Up-left
                case '1':
                    if ((Wy == 0 || Wx == 0) || ((((Wy - 1) == S1y)
                    && ((Wx - 1) == S1x)) || (((Wy - 1) == S2y)
                    && ((Wx - 1) == S2x)) || (((Wy - 1) == S3y)
                    && ((Wx - 1) == S3x)) || (((Wy - 1) == S4y)
                    && ((Wx - 1) == S4x))))
                    // if wolf position equals sheep position
                    {
                        Console.WriteLine("You Cant move there.");
                        PLayer_Wolf(ref Wy, ref Wx,
                        ref S1y, ref S1x,
                        ref S2y, ref S2x,
                        ref S3y, ref S3x,
                        ref S4y, ref S4x);

                    }
                    else
                    {
                        Wy -= 1;
                        Wx -= 1;
                    }
                    break;
                //Up-right
                case '2':
                    if ((Wy == 0 || Wx == 7) || ((((Wy - 1) == S1y)
                    && ((Wx + 1) == S1x)) || (((Wy - 1) == S2y)
                    && ((Wx + 1) == S2x)) || (((Wy - 1) == S3y)
                    && ((Wx + 1) == S3x)) || (((Wy - 1) == S4y)
                    && ((Wx + 1) == S4x))))
                    // if wolf position equals sheep position
                    {
                        Console.WriteLine("You Cant move there.");
                        PLayer_Wolf(ref Wy, ref Wx,
                        ref S1y, ref S1x,
                        ref S2y, ref S2x,
                        ref S3y, ref S3x,
                        ref S4y, ref S4x);

                    }
                    else
                    {
                        Wy -= 1;
                        Wx += 1;
                    }
                    break;
                //Down-left
                case '3':
                    if ((Wy == 7 || Wx == 0) || ((((Wy + 1) == S1y)
                    && ((Wx - 1) == S1x)) || (((Wy + 1) == S2y)
                    && ((Wx - 1) == S2x)) || (((Wy + 1) == S3y)
                    && ((Wx - 1) == S3x)) || (((Wy + 1) == S4y)
                    && ((Wx - 1) == S4x))))
                    // if wolf position equals sheep position
                    {
                        Console.WriteLine("You Cant move there.");
                        PLayer_Wolf(ref Wy, ref Wx,
                        ref S1y, ref S1x,
                        ref S2y, ref S2x,
                        ref S3y, ref S3x,
                        ref S4y, ref S4x);

                    }
                    else
                    {
                        Wy += 1;
                        Wx -= 1;
                    }
                    break;
                //Down-right
                case '4':
                    if ((Wy == 7 || Wx == 7) || ((((Wy + 1) == S1y)
                    && ((Wx + 1) == S1x)) || (((Wy + 1) == S2y)
                    && ((Wx + 1) == S2x)) || (((Wy + 1) == S3y)
                    && ((Wx + 1) == S3x)) || (((Wy + 1) == S4y)
                    && ((Wx + 1) == S4x))))
                    // if wolf position equals sheep position
                    {
                        Console.WriteLine("You Cant move there.");
                        PLayer_Wolf(ref Wy, ref Wx,
                        ref S1y, ref S1x,
                        ref S2y, ref S2x,
                        ref S3y, ref S3x,
                        ref S4y, ref S4x);

                    }
                    else
                    {
                        Wy += 1;
                        Wx += 1;
                    }
                    break;
                //in case of none of the above
                default:
                    Console.WriteLine("Unvalid movement, please choose again.");
                    PLayer_Wolf(ref Wy, ref Wx,
                    ref S1y, ref S1x,
                    ref S2y, ref S2x,
                    ref S3y, ref S3x,
                    ref S4y, ref S4x);
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
            char Chosen_Sheep;
            Console.WriteLine("Choose one of the Sheeps:");
            Console.WriteLine("1, 2, 3, 4.");
            while (true)
            {
                sheep = Console.ReadLine();
                Chosen_Sheep = char.Parse(sheep);

                switch (Chosen_Sheep)
                {
                    case '1':
                        Console.WriteLine("Move Sheep 1");
                        return 1;
                    case '2':
                        Console.WriteLine("Move Sheep 2");
                        return 2;
                    case '3':
                        Console.WriteLine("Move Sheep 3");
                        return 3;
                    case '4':
                        Console.WriteLine("Move Sheep 4");
                        return 4;
                    default:
                        Console.WriteLine("Invalid Sheep, please choose again.");
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
                                         ref int S4y, ref int S4x,
                                         ref int Wy, ref int Wx)
        {
            //Choose a Sheep
            int sChoice = Sheep_Choice();
            string str;
            char Movement;
            Console.WriteLine("Sheep Commands");
            Console.WriteLine("\u2B09 1.     2. \u2B08 ");
            str = Console.ReadLine();
            while (str != "1" && str != "2")
            {
                Console.WriteLine("Invalid Movement, please try again");
                str = Console.ReadLine();
            }
            Movement = char.Parse(str);

            switch (sChoice)
            {
                case 1:
                    Sheep_Movement(Movement,
                    ref S1y, ref S1x,
                    ref S1y, ref S1x, ref S2y,
                    ref S2x, ref S3y, ref S3x,
                    ref S4y, ref S4x,
                    ref Wy, ref Wx);
                    break;
                case 2:
                    Sheep_Movement(Movement,
                    ref S2y, ref S2x,
                    ref S1y, ref S1x,
                    ref S2y, ref S2x,
                    ref S3y, ref S3x,
                    ref S4y, ref S4x,
                    ref Wy, ref Wx);
                    break;
                case 3:
                    Sheep_Movement(Movement,
                    ref S3y, ref S3x,
                    ref S1y, ref S1x,
                    ref S2y, ref S2x,
                    ref S3y, ref S3x,
                    ref S4y, ref S4x,
                    ref Wy, ref Wx);
                    break;
                case 4:
                    Sheep_Movement(Movement,
                    ref S4y, ref S4x,
                    ref S1y, ref S1x,
                    ref S2y, ref S2x,
                    ref S3y, ref S3x,
                    ref S4y, ref S4x,
                    ref Wy, ref Wx);
                    break;
            }
        }

        /// <summary>
        /// Moves the previously selected cheep only in the upward direction
        /// </summary>
        /// <param name="sChoice"> Chosen Movement for the Sheep </param>
        /// <param name="sy"> Y coordinate for the selected Sheep </param>
        /// <param name="sx"> X coordinate for the selected Sheep </param>
        private static void Sheep_Movement(char sChoice,
        ref int sy, ref int sx,
        ref int S1y, ref int S1x,
        ref int S2y, ref int S2x,
        ref int S3y, ref int S3x,
        ref int S4y, ref int S4x,
        ref int Wy, ref int Wx)
        {

            bool loop = true;
            string new_choice;
            while (loop)
            {
                switch (sChoice)
                {
                    //Up-left
                    case '1':
                        if ((sy == 0 || sx == 0) || ((((sy - 1) == S1y)
                        && ((sx - 1) == S1x)) || (((sy - 1) == S2y)
                        && ((sx - 1) == S2x)) || (((sy - 1) == S3y)
                        && ((sx - 1) == S3x)) || (((sy - 1) == S4y)
                        && ((sx - 1) == S4x)) || (((sy - 1) == Wy)
                        && ((sx - 1) == Wx))))
                        {
                            Console.WriteLine("You can't go that way");
                            new_choice = Console.ReadLine();
                            sChoice = char.Parse(new_choice);
                        }
                        else
                        {
                            sy -= 1;
                            sx -= 1;
                            loop = false;
                        }
                        break;

                    //Up-right
                    case '2':
                        if ((sy == 0 || sx == 7) || ((((sy - 1) == S1y)
                        && ((sx + 1) == S1x)) || (((sy + 1) == S2y)
                        && ((sx + 1) == S2x)) || (((sy - 1) == S3y)
                        && ((sx + 1) == S3x)) || (((sy - 1) == S4y)
                        && ((sx + 1) == S4x)) || (((sy - 1) == Wy)
                        && ((sx + 1) == Wx))))
                        {
                            Console.WriteLine("You can't go that way");
                            new_choice = Console.ReadLine();
                            sChoice = char.Parse(new_choice);
                        }
                        else
                        {
                            sy -= 1;
                            sx += 1;
                            loop = false;
                        }
                        break;
                }
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
            string[,] matrix;
            int lins = 8, cols = 8;

            //Inicialize the matrix
            matrix = new string[8, 8];

            //show position of wolf

            //Fill the matrix with empty spaces
            for (int i = 0; i < lins; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = "   ";
                }
            }

            matrix[Wy, Wx] = " W ";
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
                    Console.Write("|" + matrix[i, j]);
                Console.WriteLine("|");
            }
            Console.WriteLine("  ---------------------------------");
            Console.WriteLine("    A   B   C   D   E   F   G   H  ");


        }
    }
}
