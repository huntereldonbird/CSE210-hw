using System;
using System.Dynamic;

class Verse {

    private List<Word> _wholeVerse;

    public Verse(List<Word> lw) {
        if(!(lw == null)) {
            _wholeVerse = lw;
        }
        else{
            _wholeVerse = TESTTOSETVERSE();
        }

    }

    

    public List<Word> Get_wholeVerse(){
        return _wholeVerse;
    }

    public void Set_wholeVerse(List<Word> set){
        _wholeVerse = set;
    }


    // ANOTHER FOR TESTING PURPOSES FUNCTION, PLEASE REMOVE THIS LATER AS NEEDED, Hunter
    public List<Word> TESTTOSETVERSE(){
        List<Word> LW = new List<Word>();

        LW.Add(new Word("TEST", true));
        LW.Add(new Word("Also", true));
        LW.Add(new Word("Word", true));
        LW.Add(new Word("HI", true));
        LW.Add(new Word("This", true));


        return LW;
    }



    // this function just outputs the entire verse, I would suggest printing from here, Hunter
    public void PrintVerseToConsole(){

        for(int i = 0; i < _wholeVerse.Count(); i++){
            
            if(_wholeVerse[i].Get_isRevealed()){
                Console.Write(_wholeVerse[i].Get_theWord() + " ");
            }
            else{
                Console.Write(GetUnRevealedWord(_wholeVerse[i]) + " ");
            }

        }

    }


    // this is the function that replaces the words with underlines, Hunter
    public String GetUnRevealedWord(Word word){

        String output = "";

        int len = word.Get_theWord().Length;

        for(int i = 0; i < len; i++) {
            output += "_";
        }

        return output;
    }
}