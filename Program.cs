//Vi opretter en Main() og en hjælper funktion der skal tjekke hvad vores hånd er
class Program
{
    static void Main(string[] args)
    {
        //Inserts the code from Gôkce. 
        //++ means add another when running the code and refers to the enums. It is a kind of for-loop.
        for (var p1 = Throw.Spock; (int) p1 < 5; ++p1)
        {
            for (var p2 = Throw.Spock; (int) p2 < 5; ++p2)
            {
                //This is the console print that shows the result based on the players throws.
                Console.WriteLine($"If p1: {p1} and p2: {p2}  => ");
                Console.WriteLine(GetWinState(p1, p2));
            }
        }
    }
    
    //Creates enum based on the options you can choose in the game
    internal enum Throw
    {
        Rock,
        Paper,
        Scissors,
        Lizard,
        Spock
    }
    //As the outcomes are not Boolean, we create another enum
    internal enum WinState
    {
        Tie,
        Wins,
        Loses
    }
    
    //We make another method that is our helping tool.
    private static WinState GetWinState(Throw player1, Throw player2)
    //declare variable that does the calculation p2-p1
    {
        var Score = player2 - player1;
        switch (Score)
        {
            //Lists all the cases based on the value that determines the result
            case 0 :
                return WinState.Tie;
            case -4 or -2 or 1 or 3:
                return WinState.Wins;
            case -3 or -1 or 2 or 4:
                return WinState.Loses;
            //We create a default option if nonw of the above happens. This is an exception (add-on)
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

