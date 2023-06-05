// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// TODO: Get current path on init.
string placeholderPath = "C:\\";
string currentPath = $"{placeholderPath}>";

Console.WriteLine("Press Control + C to stop the application.");

while (true)
{
    Console.WriteLine(currentPath);
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "tch":
            break;
        case "mv":
            break;
        case "ls":
            break;
        case "ls -R":
            break;
        case "cd":
            break;
        case "help":
            break;
        default:
            Console.WriteLine($"\"{userInput}\" no se reconoce como un comando disponible.");
            break;
    }
}