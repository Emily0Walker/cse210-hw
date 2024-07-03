public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _rng = new Random();
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        string[] wordary = text.Split();
        
        foreach (string wordstr in wordary)
        {
            Word wordObj = new Word(wordstr);
            _words.Add(wordObj);
        }
    }


    public void HideRandomWords( int toHide) 
    {
        for (int _ = 0; _ < toHide; _++)
        { 
            int index = _rng.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()    
    {   
        string displaystr = "";
        displaystr += _reference.GetDisplayText() + " - "; 
       
        foreach( Word word in _words)
        {
            displaystr += word.GetDisplayText() + " ";
        }
         return displaystr; // reference and scripture 
        
    }

    public bool IsCompletlyHidden()
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