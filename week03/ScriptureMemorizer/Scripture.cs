public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split long text into single words (including punctuation)
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            char punctuation = '\0';
            char[] wordArray = new char[word.Length];

            // Divide each word into a char array to separate the alphanumerical values from the punctuation
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                {
                    wordArray[i] = word[i]; // Add to char array only alphanumerical values
                }

                else if (Char.IsPunctuation(word[i]))
                {
                    punctuation = word[i]; // Store punctuation separately
                }

            }
            // Convert word array back into string word (without punctuation)
            string s = new string(wordArray);

            // Construct new Word datatype
            Word newWord = new Word(s, punctuation);

            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Random randomGenerator = new Random();
            int rdn = randomGenerator.Next(0, _words.Count);
            
            if (IsComppletelyHidden())
            {
                return;
            }
            while (_words[rdn].IsHidden())
                {
                    rdn = randomGenerator.Next(0, _words.Count);
                }
            _words[rdn].Hide();
            
        }
    }

    public string GetDisplayText()
    {
        string rtext = $"{_reference.GetDisplayText()}";
        string verse = "";
        foreach (Word word in _words)
        {
            verse += $"{word.GetDisplayText()} ";
        }
        string finalText = $"{rtext} {verse}";
        return finalText;
    }

    public bool IsComppletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}