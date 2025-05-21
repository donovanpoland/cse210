using System;
using System.Collections.Generic;

class PromptGenerator
{
    //member variables
    private List<string> _list;
    private Random _random = new Random();

    //Default constructor
    public PromptGenerator()
    {
    
    }

    //methods
    public string GetRandomPrompt()
    {
        //get list
        getPromptList();
        // use random index from list
        int index = _random.Next(_list.Count);
        //return prompt
        return _list[index];
    }

    // list of prompts
    private void getPromptList()
    {
        //initialize prompts into list
        _list = new List<string>
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who am I when no one is watching?",
        "What are three values that are most important to me, and why?",
        "What habits help me become the version of myself I want to be?",
        "What does 'success' mean to me, personally?",
        "What emotion have I been feeling most often lately, and why?",
        "What thoughts or beliefs are holding me back?",
        "How do I handle failure or rejection?",
        "What helps me feel most at peace?",
        "What do I need to forgive myself for?",
        "Who in my life brings out my best self, and how?",
        "What do I need more (or less) of in my relationships?",
        "How do I show love and how do I prefer to receive it?",
        "What boundaries do I need to set or reinforce?",
        "What role do I play in the lives of those around me?",
        "When do I feel most fulfilled?",
        "What impact do I want to have on others?",
        "If I had no fear, what would I pursue?",
        "What legacy do I want to leave behind?",
        "How do I define a meaningful life?",
        "What am I grateful for today, really?",
        "What small moments brought me joy recently?",
        "How do I ground myself when I feel overwhelmed?",
        "How do I practice being present in daily life?",
        "What beauty did I notice in the last 24 hours?"
        };

    }
}