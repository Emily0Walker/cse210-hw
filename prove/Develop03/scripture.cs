public class Scripture
{
    public Reference
    public List<Word> Words;

    public Scripture(string Text)
    {
        
        
        foreach (var Word in Words);

    }
    

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (var Word in Words)
        {
            displayWords.Add(Word.GetDisplayText());
        }

        return string.Join(" ", displayWords);
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hiddenWords = 0;

        while (hiddenWords < count)
        {
            int index = rand.Next(Words.Count);

            if (!Words[index].IsHidden())
            {
                Words[index].Hide();
                hiddenWords++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var Word in Words)
        {
            if (!Word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
