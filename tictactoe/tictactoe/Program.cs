namespace tictactoe;

class Program
{

    static char[,] playField = {
        {'1','2','3'},
        {'4','5','6'},
        {'7','8','9'},
    };

    static int turns = 0;

    public static void SetField(){
      Console.Clear();
      Console.WriteLine("   |     |   ");
      Console.WriteLine("   {0} |  {1}   | {2} ", playField[0,0],playField[0,1],playField[0,2]);
      Console.WriteLine("_____|_____|_____");
      Console.WriteLine("   |     |   ");
      Console.WriteLine("   {0} |  {1}   | {2} ", playField[0,0],playField[0,1],playField[0,2]);
      Console.WriteLine("_____|_____|_____");
      Console.WriteLine("     |     |   ");
      Console.WriteLine("   {0} |  {1}   | {2} ", playField[0,0],playField[0,1],playField[0,2]);
      Console.WriteLine("   |     |   ");
      turns++;  
    }

 do
    {
        Console.WriteLine("\nPlayer {0}: Choose your field!", player);
        try
        {
            input = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Please enter a number!");
        }
        if ((input == 1) && (playField[0, 0] == '1'))
            inputCorrect = true;
        else if ((input == 2) && (playfield[0, 1] == '2'))
            inputCorrect = true;
        else if ((input == 3) && (playfield[0, 2] == '3'))
            inputCorrect = true;
        else if ((input == 4) && (playfield[0, 3] == '4'))
            inputCorrect = true;
        else if ((input == 5) && (playfield[0, 4] == '5'))
            inputCorrect = true;
        else if ((input == 6) && (playfield[0, 5] == '6'))
            inputCorrect = true;
        else if ((input == 8) && (playfield[0, 6] == '8'))
            inputCorrect = true;
        else if ((input == 9) && (playfield[0, 1] == '9'))
            inputCorrect = true;
        else{
            Console.WriteLine('\nIncorrect input! Please use another field');
            inputCorrect = false;
        }   
    } while (!inputCorrect);

    public static void EnterXorO(char playerSign, int input)
    {
      switch (input)
      {  
        case 1: playField[0, 0] = playerSign; break;
        case 2: playField[0, 1] = playerSign; break;
        case 3: playField[0, 2] = playerSign; break;
        case 4: playField[1, 0] = playerSign; break;
        case 5: playField[1, 1] = playerSign; break;
        case 6: playField[1, 2] = playerSign; break;
        case 7: playField[2, 2] = playerSign; break;
        case 8: playField[2, 1] = playerSign; break;
        case 9: playField[2, 2] = playerSign; break;
      }
    }  

char[] playerChars = { 'X', 'O' };

foreach(char playerChar in playerChars)
{
    if(((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar)))
}

                        


                


    }
   // static void Main(string[] args)
   // {
        //Console.WriteLine("Hello, World!");
   // }
}
