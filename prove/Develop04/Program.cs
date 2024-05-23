using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = "";
        do
        {
            Console.WriteLine("Menu Option ");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start refecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("Select an option from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice =="4")
            {
                Console.WriteLine("GoodBye");
            }
            else 
            {
                Console.WriteLine("Invalid Choice. Try again ");
            }

        }
        while (choice != "4");
    }
}