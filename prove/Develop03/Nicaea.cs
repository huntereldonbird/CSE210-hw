using System;
using System.Runtime.CompilerServices;

class Nicaea
{

   public List<Verse> _allVerse;
    public void Main()
    {



        // ALL OF THIS IS TEMPORARY I WANTED TO TEST THIS, Hunter
        Verse v = new Verse(null);
        List<Verse> lv = new List<Verse>();
        _allVerse = lv;
        // ONCE THIS FUNCTION IS ACTUALLY CREATED PLEASE DELETE THIS, Hunter


        Console.WriteLine("Welcome to Scripture memorizer!");

        

        while (true)  
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                //put stuff to randomly remove the key.

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