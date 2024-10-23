using System;
using System.Dynamic;
using System.Collections.Generic;

class Verse {

    private List<Word> _wholeVerse;

    

    public List<Word> Get_wholeVerse(){
        return _wholeVerse;
    }

    public void Set_wholeVerse(List<Word> set){
        _wholeVerse = set;
    }

    // store a dictionary of Verses

    private Dictionary<string, string> Scripture = new Dictionary<string, string>() {
        {"D&C 10:5", "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work."},
        {"D&C 1:37-38", "37 Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. \n38 What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."},
        {"D&C 18:10-11", "10 Remember the worth of souls is great in the sight of God; \n11 For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him."}
    };
}