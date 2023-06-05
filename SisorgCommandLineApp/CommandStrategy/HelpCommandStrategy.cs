namespace SisorgCommandLineApp.CommandStrategy
{
    internal class HelpCommandStrategy : BaseCommandStrategy
    {
        public override void Execute(string[] arguments)
        {
            Console.WriteLine("Available command list:");
            Console.WriteLine();
            Console.WriteLine($"tch [filename] - Creates a new empty file with the given filename and extension.");
            Console.WriteLine($"mv [filename1] [filename2] - Renames a file in the actual directory.");
            Console.WriteLine($"mv [filePath] [folderPath] - Moves the file in the given filePath to the given folderPath");
            Console.WriteLine($"ls - Lists all the files and directories in the current directory");
            Console.WriteLine($"cd [path] - Navigates to the given path");
            Console.WriteLine($"help - Lists all the available application commands");
        }
    }
}
