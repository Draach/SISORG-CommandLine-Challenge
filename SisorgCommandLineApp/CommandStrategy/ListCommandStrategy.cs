namespace SisorgCommandLineApp.CommandStrategy
{
    internal class ListCommandStrategy : BaseCommandStrategy
    {
        private readonly string directoryPath;
        public ListCommandStrategy(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }

        public override void Execute(string[] arguments)
        {
            // TODO: Consider -R flag.
            string[] files = Directory.GetFiles(directoryPath);
            string[] directories = Directory.GetDirectories(directoryPath);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            foreach(string directory in directories)
            {
                Console.WriteLine(Path.GetFileName(directory));
            }
        }
    }
}
