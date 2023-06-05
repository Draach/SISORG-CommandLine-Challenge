using SisorgCommandLineApp.CommandStrategy;
using SisorgCommandLineApp.CommandStrategy.Interfaces;

namespace SisorgCommandLineApp
{
    internal class CommandLine
    {
        public string currentPath { get; private set; }
        private ICommandStrategy strategy;

        public CommandLine(string initialPath)
        {
            currentPath = initialPath;
        }

        public string ChangeDirectory(string path)
        {
            this.currentPath = path;
            return this.currentPath;
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
