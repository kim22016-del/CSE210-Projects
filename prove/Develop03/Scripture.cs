using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            Word newWord = new Word(part);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int count = 0;

        while (count < 3 && !ALLHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].WordHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text;
    }

    public bool ALLHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.WordHidden()) return false;
        }
        return true;
    }
}