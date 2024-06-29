using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        
    }

    public void HideRandomWords(int numberToHide)
    {
    }

    public string GetDisplayText()
    {
        return"";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            
            {
                return false;
            }
        }

        return true;
    }
}