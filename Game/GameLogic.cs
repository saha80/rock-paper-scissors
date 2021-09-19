using System;
using System.Linq;

namespace task3.Game
{
    static class GameLogic
    {
        public static void VerifyArgs(string[] args)
        {
            if (args.Length < 3)
                throw new Exception("Number of arguments must be greater or equal three");
            if (args.Length % 2 == 0)
                throw new Exception("You must provide odd number of arguments");
            if (args.Length != args.Distinct().Count())
                throw new Exception("Arguments must be unique");
        }

        public static GameResult Compare(int pc, int user, int argsHalfLength)
        {
            if (pc == user)
                return GameResult.DRAW;
            var diff = user - pc;
            if (pc <= argsHalfLength)
            {
                if (diff > 0 && diff <= argsHalfLength)
                    return GameResult.WIN;
                return GameResult.LOSE;
            }
            if (diff > 0 || diff < -argsHalfLength)
                return GameResult.WIN;
            return GameResult.LOSE;
        }

    }
}