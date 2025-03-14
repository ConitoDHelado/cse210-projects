using System.Security.Cryptography;

public class PropmtGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int rdn = randomGenerator.Next(0,_prompts.Count);
        string prompt = _prompts[rdn];
        return prompt;
    }
}