using System;
using System.Globalization;

class Nicaea
{

   private List<Verse> _allVerse;
    public void Main()
    {
        Console.WriteLine("Hello Develop03 World!");
    }

    private void RandomRemoveWords(int removeAmout, int from){

        for(int x = 0; x < _allVerse[from].Get_wholeVerse().Count(); x++){

            for(int i = 0; i < removeAmout;){

                Random rng = new Random();

                int randNum = rng.Next(_allVerse.Count());

                if(_allVerse[from].Get_wholeVerse()[randNum].Get_isRevealed() == true){
                    _allVerse[from].Get_wholeVerse()[randNum].Set_isRevealed(false);
                    i++;
                }
            }
        }
    }
}