using System;

class Word
{
    private bool _isRevealed;
    private String _theWord;



    public bool Get_isRevealed(){
        return _isRevealed;
    }

    public String Get_theWord(){
        return _theWord;
    }

    public void Set_isRevealed(bool set){
        _isRevealed = set;
    }

    public void Set_theWord(String set){
        _theWord = set;
    }


}