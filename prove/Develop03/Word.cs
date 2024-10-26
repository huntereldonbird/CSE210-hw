using System;

class Word
{
    private bool _isRevealed = true;
    private String _theWord;


    public Word(String s, bool r){

        _theWord = s;
        _isRevealed = r;

    }


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