using System;
using System.Runtime.CompilerServices;

class Nicaea
{

   public List<Verse> _allVerse = new List<Verse>();
    public void Main()
    {



        // ALL OF THIS IS TEMPORARY I WANTED TO TEST THIS, Hunter
        Verse v = new Verse(null);
        _allVerse.Add(v);
         int CurrentVerseIndex = 0;
        // ONCE THIS FUNCTION IS ACTUALLY CREATED PLEASE DELETE THIS, Hunter
        // of note as of now, if you dont pass anything through to the new List<Verse> it automatically just uses a default verse for testing, Hunter


        Console.WriteLine("Welcome to Scripture memorizer!");
        _allVerse[0].PrintVerseToConsole();

        

        while (!WholeVerseIsHidden(_allVerse[0]))  
        {

            Console.Clear();
            Console.WriteLine("Welcome to Scripture memorizer!");
            _allVerse[0].PrintVerseToConsole();

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                //put stuff to randomly remove the key.


                Random rng = new Random();
                int rngNum = rng.Next(0, 3);

                RandomRemoveWords(rngNum, CurrentVerseIndex);

            }
        }
    }

    // Give it a random amount # of words to remove and a verse (you need to give it a verse index from _allVese) and it sets the is removed values, Hunter
    private void RandomRemoveWords(int removeAmout, int from){

        for(int i = 0; i <= removeAmout; ) {

            Random random = new Random();

            int ToRemove = random.Next(_allVerse[from].Get_wholeVerse().Count());

            if(_allVerse[from].Get_wholeVerse()[ToRemove].Get_isRevealed()){

                _allVerse[from].Get_wholeVerse()[ToRemove].Set_isRevealed(false);
                i++;

            }

            continue;
        }
    }

    // use this to check if the verse you are currently using is completly "spent" or relealed, hunter
    // it returns true if No words are revealed, hunter
private bool WholeVerseIsHidden(Verse verse)
    {
        for (int i = 0; i <= verse.Get_wholeVerse().Count() - 1; i++)
        {
            if (verse.Get_wholeVerse()[i].Get_isRevealed())
            {
                return false;
            }
        }
        return true;
    }

    // Resets the "revealed" status of any verse currently contianed to is_revealed = true, hunter
    private void Reset(){

        for(int x = 0; x < _allVerse.Count(); ){

            for(int y = 0; y < _allVerse[x].Get_wholeVerse().Count(); ){

                Word ThisWord = _allVerse[x].Get_wholeVerse()[y];

                ThisWord.Set_isRevealed(true);


                y++;
            }

            x++;
        }
    }
}