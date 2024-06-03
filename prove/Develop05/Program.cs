using System;

class Program
{
    static void Main(string[] args)
    {
        string fileName1 = "Goals.txt";
        Console.Clear();
        GoalManager goalManager = new GoalManager();

        string option = "";
        while (option != "6")
        {
            goalManager.Start();
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Select the type of goal to create:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    string typeOption = Console.ReadLine();

                    switch (typeOption)
                    {
                        case "1":
                            goalManager.CreateGoal("simple");
                            break;
                        case "2":
                            goalManager.CreateGoal("eternal");
                            break;
                        case "3":
                            goalManager.CreateGoal("checklist");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please select a valid goal type.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("\nThe Goals are:");
                    goalManager.ListGoalDetails();
                    break;
                
                case "3":
                    Console.Write($"\nType your goals file (default: {fileName1}): ");
                    string saveFilename = Console.ReadLine();
                    if (string.IsNullOrEmpty(saveFilename)) { saveFilename = fileName1; }
                    goalManager.SaveGoals(saveFilename);
                    Console.Clear();
                    break;

                case "4":
                    Console.Write($"\nType your goals file (default: {fileName1}): ");
                    string loadFilename = Console.ReadLine();
                    if (string.IsNullOrEmpty(loadFilename)) { loadFilename = fileName1; }
                    goalManager.LoadGoals(loadFilename);
                    Console.Clear();
                    break;

                case "5":
                    goalManager.ListGoalNames();
                    goalManager.RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("Thanks!!!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    break;
                    

            }
        }
    }
}