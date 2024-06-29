public class Scripture
{
    public Reference Reference { get; }
    public string Text { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        Words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (var word in Words)
        {
            displayWords.Add(word.GetDisplayText());
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
        foreach (var word in Words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
