public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
        string mask = new String('_', _text.Length);
        _text = mask;
    }

    public void Show()
    {
        _isHidden = false;

    }

    public bool IsHidden()
    {
        string mask = new String('_', _text.Length);
        if (String.Equals(_text, mask))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public string GetDisplayText()
    {
        
        return _text;
    }
}