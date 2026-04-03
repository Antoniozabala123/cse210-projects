public class PromptGenerator
{
    // List containing the predefined prompts
    public List<string> _Prompts;
    public PromptGenerator()

    {
        // list question generator prompts 
        _Prompts = new List<string>
        {
            "What was the best part of your day?",
            "What made you feel grateful today?",
            "What did you learn today?",
            "How did you help someone today?",
            "What moment made you smile?",
            "What are you looking forward to tomorrow?",
            "Describe something beautiful you saw today.",
            "What challenge did you face and how did you handle it?",
            "If today had a theme song, what would it be?",
            "What small win did you have today?"
        };
    }
    //Select and return a random question from the list
    public string GetRandomPrompt()

    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
    }

}