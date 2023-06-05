namespace SisorgCommandLineApp.CommandStrategy
{
    internal class InvalidOptionsCommandStrategy : CommandStrategy
    {
        public override void Execute(string[] arguments)
        {
            ThrowIfThereAreNoArguments(arguments);
        }
    }
}
