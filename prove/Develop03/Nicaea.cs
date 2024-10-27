using System;
using System.Runtime.CompilerServices;

class Nicaea
{

   public List<Verse> _allVerse = new List<Verse>();
    public void Main()
    {



        // ALL OF THIS IS TEMPORARY I WANTED TO TEST THIS, Hunter
        Verse v = new Verse();
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
            
            Console.WriteLine("");
            
            Console.WriteLine(_allVerse[0].Get_name() + ":");
            
         
            
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
                int rngNum = rng.Next(0, 5);

                RandomRemoveWords(rngNum, CurrentVerseIndex);

            }
        }
        Console.Clear();
        _allVerse[0].PrintVerseToConsole();
        Console.WriteLine();
        Console.WriteLine("You have hidden all the words. Good job memorizing");
    }

    // Give it a random amount # of words to remove and a verse (you need to give it a verse index from _allVese) and it sets the is removed values, Hunter
    private void RandomRemoveWords(int removeAmount, int from) {
        int wordsRemoved = 0;
        int maxAttempts = _allVerse[from].Get_wholeVerse().Count() * 2; // Prevent infinite loop
        int attempts = 0;
        Random random = new Random();

        while (wordsRemoved <= removeAmount && attempts < maxAttempts) {
            int toRemove = random.Next(0, _allVerse[from].Get_wholeVerse().Count());

            if (_allVerse[from].Get_wholeVerse()[toRemove].Get_isRevealed()) {
                _allVerse[from].Get_wholeVerse()[toRemove].Set_isRevealed(false);
                wordsRemoved++;
            }

            attempts++;
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