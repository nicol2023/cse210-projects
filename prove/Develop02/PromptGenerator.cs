using System;

public class PromptGenerator 
{
    public List<string> _prompts = new List<string>();



    public PromptGenerator()
    {
        _prompts.Add("What made you smile today?");
        _prompts.Add("Describe a moment of gratitude.");
        _prompts.Add("What is your goal for tomorrow?");
        _prompts.Add("Write about a challenge you overcame recently.");
        _prompts.Add("Share a random act of kindness you witnessed or did.");
        _prompts.Add("Describe a place you would like to visit and why.");
        _prompts.Add("Write about a skill you'd like to learn and why.");
        _prompts.Add("Share a book or movie that had a big impact on you and why.");
        _prompts.Add("Describe a person who has influenced you positively and how.");

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
        
    }

}