public class Word
{
    private string _text;
    private char _punctuation;
    private bool _isHidden = false;

    public Word(string text, char punctuation)
    {
        _text = text;
        _punctuation = punctuation;
    }

    public void Hide()
    {
        int len = _text.Length;
        _text = new string('_', len);
        _isHidden = true;
    }

    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }

        else
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        string displayText = _text + _punctuation;
        return displayText;
    }


}
