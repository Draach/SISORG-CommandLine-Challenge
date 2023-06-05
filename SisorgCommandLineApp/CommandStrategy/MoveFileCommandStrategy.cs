namespace SisorgCommandLineApp.CommandStrategy
{
    internal class MoveFileCommandStrategy : CommandStrategy
    {
        public override void Execute(string[] arguments)
        {
            ThrowIfThereAreNoArguments(arguments);
            ThrowIfInvalidArgumentsQuantity(arguments);

            
            // TODO: Identify if second argument is a folder or a file.
            // If it is a file, then rename it.
            // If it is a folder, then move it there.
        }

        private void ThrowIfInvalidArgumentsQuantity(string[] arguments)
        {
            // TODO: Improve error message?
            if (arguments.Length != 2) throw new Exception("Invalid arguments quantity");
        }
    }
}
