

using Homework11._01._2023Console_app_Practice_.Controllers;
using ServiceLayer.Helpers;

LibraryContreller LibraryContreller = new();

while (true)
{
    GetOptions();

    Option: string option = Console.ReadLine();
    int selectedOption;

    bool isCorrectOPtion = int.TryParse(option, out selectedOption);

    if (isCorrectOPtion)
    {
        switch (selectedOption)
        {
            case 1:
                LibraryContreller.Create();
                break;

            case 2:
                Console.WriteLine("Get all");
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                ConsoleColor.Red.WriteConsole("Please add correct option");
                goto Option;
                
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please add correct format option");
        goto Option;
    }

}

static void GetOptions()
{
    ConsoleColor.Cyan.WriteConsole("Please select one option: ");
    ConsoleColor.Cyan.WriteConsole("Library options: 1 - Create, 2 - Get all, 3 - Delete");
}
