using System;

using task3.Game;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var game = new GameController(args);
                game.GameLoop();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }

        // static void PrintUsage()
        // {
            // todo: add system languge based usage
//             Console.Write(
// "\nGeneralized rock-paper-scissors game (any number of arbitrary combinations)\n" +
// "When the program starts, an odd number of non-repeating lines is transferred\n" +
// "These lines are moves (for example, Rock Paper Scissors or\n" +
// "Rock Paper Scissors Lizard Spock or 1 2 3 4 5 6 7 8 9).\n\n" +
// "Victory is defined as follows - the sequence of the next wins in the circle,\n" +
// "half of the previous ones in the circle lose (the semantics of the lines\n" +
// "is not important, in which the user entered, and plays in that).\n" +
// "A random key with a length of 128 bits is generated, the computer does,\n" +
// "the HMAC is calculated from its move, the HMAC is shown.\n" +
// "The script shows who won, the turn of the computer and the original key.\n" +
// "This way, you can check that the computer is playing fair (did not change\n" +
// "its move after your move).\n\n"
//             );
        // }
    }
}
