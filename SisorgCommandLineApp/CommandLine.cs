using SisorgCommandLineApp.CommandStrategy;
using SisorgCommandLineApp.CommandStrategy.Interfaces;

namespace SisorgCommandLineApp
{
    internal class CommandLine
    {
        public readonly string currentPath;
        private ICommandStrategy strategy;

        public CommandLine(string initialPath)
        {
            currentPath = initialPath;
        }

        public void SetCommandStrategy(ICommandStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteCommand(string[] arguments)
        {
            strategy.Execute(arguments);
        }
    }
}
