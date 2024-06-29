using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Example reference
        Reference reference = new Reference("John", 3, 16);

        // Example scripture text
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Create a Scripture object
        Scripture scripture = new Scripture(reference, text);

        // Display the full scripture
        Console.WriteLine("Full Scripture:");
        Console.WriteLine(scripture.GetDisplayText());

        // Hide random words
        scripture.HideRandomWords(5);

        // Display the scripture with hidden words
        Console.WriteLine("\nScripture with hidden words:");
        Console.WriteLine(scripture.GetDisplayText());

        // Check if all words are hidden
        bool allHidden = scripture.IsCompletelyHidden();
        Console.WriteLine($"\nAll words hidden: {allHidden}");
    }
}

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.FindAll(w => !w.IsHidden());

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove it from the list of visible words
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}

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
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
