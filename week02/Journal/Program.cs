using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        
        Console.WriteLine(prompt.GetRandomPrompt());
    }
}