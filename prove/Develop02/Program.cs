using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {

        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        string choice;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal, promptGenerator);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("Enter the filename to load the journal from:");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;

                case "4":
                    Console.WriteLine("Enter the filename to save the journal to:");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;

                case "5":
                    Console.WriteLine("Goodbye");
                    break;
                
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine();
        } 
        while (choice != "5");
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        // Obtener un prompt aleatorio
        string prompt = promptGenerator.GetRandomPrompt();

        // Mostrar el prompt al usuario
        Console.WriteLine("Prompt: " + prompt);

        // Pedir al usuario que ingrese su respuesta
        Console.WriteLine("Write your answer: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToString(),
            _promptText = prompt,
            _entryText = response
        };
        journal.AddEntry(newEntry);

        Console.WriteLine("Entry added successfully!");
    }
}