namespace MauiTABU.GameLogic;


public class WordChecker 
{

    List<string> _notUsableWords;
    public WordChecker(List<string> notUseableWords)
    {
        _notUsableWords = notUseableWords;
    }

    public bool CheckWord(string word)
    {
        if (_notUsableWords.Contains(word))
        {
            // wenn etw. aus der Liste hergenommen wird
            return false;
        }
        
        else if (word == "scheiße") // das ist absolut verboten
        {
            throw new GameOverExeption("This Word is not allowed!");
        }
        
        // sagt das throw new das Objekt das dann hinter
        // geschrieben ist eine Exeption ist und macht dann eine
        // eigene Exeption weil er es selber checkt
        
        return true;
    }


}