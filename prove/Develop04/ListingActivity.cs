using System;
using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);
        Console.WriteLine("You have a few seconds to start thinking about your list...");
        ShowCountDown(5);

        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {userList.Count} items.");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            list.Add(item);
        }
        return list;
    }
}