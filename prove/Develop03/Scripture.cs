public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string textString) 
    {
        string[] values = textString.Split(':');
        string verseString = values[0] ;
        string book = values[1];
        string chapter = values[2];
        string verse = values[3];
        int rndIndex;

        _reference = new Reference(book, chapter, verse);
        
        //split verseString into words
        string[] textStrings = verseString.Split(" ");

        foreach (string text in textStrings)
        {
            Word word = new Word(text);
            _words.Add(word);                        
        }

        Console.Clear();
        Console.Write($"{_reference.GetDisplayText()} ");
        Console.WriteLine(GetDisplayText());
        
        string option;

        Random rnd = new Random();        

        Console.WriteLine("Press Enter to continue or type 'quit' to finish");
        option = Console.ReadLine();

        while (true)
        {
            if (IsCompletelyHidden()) 
            {
                break;
            }  
            if (String.Equals(option, "quit")) 
            {
                break;
            }
            rndIndex = rnd.Next(_words.Count);                                         
            HideRandomWords(rndIndex);
                        
            Console.Clear();
            Console.Write($"{_reference.GetDisplayText()} ");
            Console.WriteLine(GetDisplayText());
            Console.WriteLine($"Hidden Index: {rndIndex} Total word: {_words.Count}");
                        
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            option = Console.ReadLine();

        }
                        
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (i == numberToHide) {
                _words[i].Hide();
                Word word = new Word(_words[i].GetDisplayText());
                _words[i] = word;                
            }
            else
            {
                _words[i].Show();
            }
                        
        }

    }

    public string GetDisplayText()
    {        
        string wordString = "";
        for (int i = 0; i < _words.Count; i++)
        {
            wordString = wordString + _words[i].GetDisplayText() + " ";            
        }
        
        Word wordText = new Word(wordString);
        return wordText.GetDisplayText();
    }

    public bool IsCompletelyHidden()
    {
        int totalWords = _words.Count;
        int trueCount = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                trueCount++;
            }            
        }
        if (trueCount == totalWords) 
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}