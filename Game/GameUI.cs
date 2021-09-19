using System;
using System.Linq;

using ConsoleTables;

namespace task3.Game
{
    static class GameUI
    {
        public static void PrintHmac(string hmac)
        {
            Console.WriteLine($"HMAC: {hmac}");
        }

        public static string PrintMenu(string[] args)
        {
            Console.WriteLine("Available moves:");
            for (var i = 0; i < args.Length; ++i)
                Console.WriteLine($"{i + 1} - {args[i]}");
            Console.WriteLine("0 - exit");
            Console.WriteLine("? - help");
            Console.Write("Enter your move: ");
            return Console.ReadLine();
        }

        public static void PrintHelp(string[] cmdArgs)
        {
            var table = new ConsoleTable(new[] { "pc \\ user" }.Concat(cmdArgs).ToArray());
            for (int pc = 0; pc < cmdArgs.Length; pc++)
            {
                var row = new object[cmdArgs.Length];
                for (int user = 0; user < cmdArgs.Length; user++)
                    row[user] = GameLogic.Compare(pc, user, cmdArgs.Length / 2);
                table.AddRow(new[] { cmdArgs[pc] }.Concat(row).ToArray());
            }
            table.Configure(conf =>
            {
                conf.NumberAlignment = Alignment.Left;
                conf.EnableCount = false;
            });
            table.Write();
        }

        public static void PrintMoves(string userMove, string computeMove)
        {
            Console.WriteLine($"Your move: {userMove}");
            Console.WriteLine($"Computer move: {computeMove}");
        }

        public static void PrintResult(GameResult result)
        {
            Console.WriteLine(result == GameResult.DRAW ? result : $"You {result}!");
        }

        public static void PrintKey(byte[] key)
        {
            Console.WriteLine($"HMAC key: {BitConverter.ToString(key).Replace("-", "")}");
        }
    }
}