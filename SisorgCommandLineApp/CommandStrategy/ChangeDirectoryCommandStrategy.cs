
namespace SisorgCommandLineApp.CommandStrategy
{
    internal class ChangeDirectoryCommandStrategy : BaseCommandStrategy
    {
        private readonly CommandLine commandLine;
        public ChangeDirectoryCommandStrategy(CommandLine commandLine)
        {
            this.commandLine = commandLine;
        }
        public override void Execute(string[] arguments)
        {
            ThrowIfThereAreNoArguments(arguments);
            ThrowIfPathIsInvalid(arguments[0]);
            commandLine.ChangeDirectory(arguments[0]);
        }

        public void ThrowIfPathIsInvalid(string path)
        {
            if (!IsValidPath(path)) throw new Exception("Invalid path.");
        }
    }
}
