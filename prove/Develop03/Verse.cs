using System;
using System.Dynamic;
using System.Collections.Generic;

class Verse {

    private List<Word> _wholeVerse;
    private String _name;

    
    // Generates a verse from one of the ones from the dictionary, hunter
    public Verse()
    {
        List<Word> LW = new List<Word>();
        
        Random rnd = new Random();
        int rand = rnd.Next(0, Scripture.Count);
        
        var element = Scripture.ElementAt(rand);
        string sentence = element.Value;
        
        string[] words = sentence.Split(' ', ',', '.', '?', '!');

        foreach (var i in words)
        {
            Word w = new Word(i, true);
            LW.Add(w);
        }
        
        Set_name(element.Key);
        Set_wholeVerse(LW);
    }

    

    public List<Word> Get_wholeVerse(){
        return _wholeVerse;
    }

    public void Set_wholeVerse(List<Word> set){
        _wholeVerse = set;
    }

    public String Get_name()
    {
        return _name;
    }

    public void Set_name(String name)
    {
        _name = name;
    }


    private Dictionary<string, string> Scripture = new Dictionary<string, string>() {
        {"D&C 10:5", "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work."},
        {"D&C 1:37-38", "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. 38 What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."},
        {"D&C 18:10-11", "Remember the worth of souls is great in the sight of God; 11 For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him."}
    };

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