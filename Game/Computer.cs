namespace task3.Game
{
    class Computer
    {
        public readonly int Move;
        
        public Computer(int toExclusive)
        {
            Move = HashGenerator.GenerateInt32(toExclusive);
        }
    }
}