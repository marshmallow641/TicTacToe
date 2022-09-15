// See https://aka.ms/new-console-template for more information
using System;
class Game
{
    // Member variables for gameplay
    static char x = 'X';
    static char o = 'O';

    static char one = '1', two = '2', three = '3', four = '4', five = '5', six = '6', seven = '7', eight = '8', nine = '9';

    int turnCounter = 0;

    int[] spots = new int[] {  };

    bool contain = false;

    string oneTwoThree = String.Format("  {0} | {1} | {2} ", one.ToString(), two.ToString(), three.ToString());
    string fourFiveSix = String.Format("  {0} | {1} | {2} ", four.ToString(), five.ToString(), six.ToString());
    string sevenEightNine = String.Format("  {0} | {1} | {2} ", seven.ToString(), eight.ToString(), nine.ToString());

    // Helper Functions
    public bool contains(int num)
    {
        for (int i = 0; i < spots.Length; i++)
        {
            if (num == spots[i]) {
                Console.WriteLine("Spot taken, try again");
                return true;
            }
        }
        spots.Append(num);
        return false;
    }
    public int tryAgain(int num, int[] nums)
    {
        int secondTry;

        //contain = contains(num, nums);

        if (contains(num))
        {
            Console.WriteLine("Spot taken, please try again");
            secondTry = int.Parse(Console.ReadLine());

            return secondTry;
        } else
        {
            return num;
        }
    }

    // Game Functions
    public int play()
    {
        int num;
        Console.WriteLine("Please enter a number between 1 and 9");
        try
        {
            num = int.Parse(Console.ReadLine());

            //contain = contains(num, spots);

            if (!contains(num))
            {
                spots.Append(num);
                Console.WriteLine("Spot Added To Array");
            } else
            {
                tryAgain(num, spots);
            }

            return num;
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return -1;
        }
    }
    public bool gameOver()
    {
        // Win by having 3 in a row
        if (one == x && two == x && three == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        } else if (four == x && five == x && six == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        } else if (seven == x && eight == x && nine == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        } else if (one == o && two == o && three == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (four == o && five == o && six == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (seven == o && eight == o && nine == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        // Win by having 3 in a column
        else if (one == x && four == x && seven == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (two == x && five == x && eight == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (three == x && six == x && nine == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (one == o && four == o && seven == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (two == o && five == o && eight == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (three == o && six == o && nine == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        // Win by having 3 in a diagonal
        else if (one == x && five == x && nine == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (three == x && five == x && seven == x)
        {
            Console.Write("Game Over!\n{0} won!\n", x);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (one == o && five == o && nine == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }
        else if (three == o && five == o && seven == o)
        {
            Console.Write("Game Over!\n{0} won!\n", o);
            Console.WriteLine("Please Press Enter");
            Console.Read();

            return true;
        }

        return false;
    }
    public void drawBoard(int num)
    {
        int secondTry;

        //contain = contains(num, spots);

        if (!contains(num))
        {
            spots.Append(num);
        }
        else
        {
            tryAgain(num, spots);
        }
        // There will be 2 switch statements, both within their own if statements, to check who's turn it is (X's or O's)
        if (turnCounter % 2 != 0)
        {
            switch (num)
            {
                case 1:
                    one = x;
                    break;
                case 2:
                    two = x;
                    break;
                case 3:
                    three = x;
                    break;
                case 4:
                    four = x;
                    break;
                case 5:
                    five = x;
                    break;
                case 6:
                    six = x;
                    break;
                case 7:
                    seven = x;
                    break;
                case 8:
                    eight = x;
                    break;
                case 9:
                    nine = x;
                    break;
            }
        } else if (turnCounter % 2 == 0)
        {
            switch (num)
            {
                case 1:
                    one = o;
                    break;
                case 2:
                    two = o;
                    break;
                case 3:
                    three = o;
                    break;
                case 4:
                    four = o;
                    break;
                case 5:
                    five = o;
                    break;
                case 6:
                    six = o;
                    break;
                case 7:
                    seven = o;
                    break;
                case 8:
                    eight = o;
                    break;
                case 9:
                    nine = o;
                    break;
            }
        }

        oneTwoThree = String.Format("  {0} | {1} | {2} ", one.ToString(), two.ToString(), three.ToString());
        fourFiveSix = String.Format("  {0} | {1} | {2} ", four.ToString(), five.ToString(), six.ToString());
        sevenEightNine = String.Format("  {0} | {1} | {2} ", seven.ToString(), eight.ToString(), nine.ToString());

        // Game Board
        Console.WriteLine("    |   |   ");
        Console.WriteLine(oneTwoThree);
        Console.WriteLine("----|---|----");
        Console.WriteLine(fourFiveSix);
        Console.WriteLine("----|---|----");
        Console.WriteLine(sevenEightNine);
        Console.WriteLine("    |   |    ");
    }
    // Main Function
    public static void Main()
    {
        // Game Instance
        Game game = new Game();

        // Draw Initial Game Board
        Console.WriteLine("    |   |   ");
        Console.WriteLine(game.oneTwoThree);
        Console.WriteLine("----|---|----");
        Console.WriteLine(game.fourFiveSix);
        Console.WriteLine("----|---|----");
        Console.WriteLine(game.sevenEightNine);
        Console.WriteLine("    |   |    ");

        Console.WriteLine("Player 1, Start");

        while (game.gameOver() != true)
        {
            game.gameOver();

            int number = game.play();
            number = game.tryAgain(number, game.spots);
            game.drawBoard(number);

            game.turnCounter += 1;
        }
    }
}
