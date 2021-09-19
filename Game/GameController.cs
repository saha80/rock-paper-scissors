namespace task3.Game
{
    public class GameController
    {
        readonly Computer _computer;
        readonly HashGenerator _generator;
        readonly string[] _cmdArgs;

        public GameController(string[] args)
        {
            GameLogic.VerifyArgs(args);

            _computer = new Computer(args.Length);
            _generator = new HashGenerator();
            _cmdArgs = args;

            GameUI.PrintHmac(_generator.GetHMAC(args[_computer.Move]));
        }

        public void GameLoop()
        {
            var running = true;
            while (running)
            {
                var input = GameUI.PrintMenu(_cmdArgs);
                if (input == "?")
                {
                    GameUI.PrintHelp(_cmdArgs);
                    continue;
                }

                if (!int.TryParse(input, out int choice) || choice < 0 || choice > _cmdArgs.Length)
                    continue;

                if (choice != 0)
                {
                    var userMove = choice - 1;
                    var gameResult = GameLogic.Compare(_computer.Move, userMove, _cmdArgs.Length / 2);
                    GameUI.PrintMoves(_cmdArgs[userMove], _cmdArgs[_computer.Move]);
                    GameUI.PrintResult(gameResult);
                    GameUI.PrintKey(_generator.Key);
                }
                running = false;
            }
        }
    }
}