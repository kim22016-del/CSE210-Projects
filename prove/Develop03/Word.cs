public class Word
{
    private string _text;
    private bool _Hidden;

    public Word(string text)
    {
        _text = text;
        _Hidden = false;
    }

    public void Hide()
    {
        _Hidden = true;
    }

    public bool WordHidden()
    {
        return _Hidden;
    }

    public string GetDisplayText()
    {
        if (_Hidden)
        {
            string blanks = "";
            for (int i = 0; i < _text.Length; i++)
            {
                blanks += "_";
            }
            return blanks;
        }
        return _text;
    }
}