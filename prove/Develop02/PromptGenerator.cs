using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>(){
        "Who or what made you smile today?",
        "What was a problem today and how did you fix it?",
        "What are three things that went well today?",
        "What have you done today to care for yourself? If you didn't, how will you tomorrow?",
        "What is one thing you are looking forward to tomorrow?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        // Get a random index value and look up the value in _prompts
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
