using System;
using System.Runtime.CompilerServices;

class Nicaea
{

   private List<Verse> _allVerse;
    public void Main()
    {
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

    private void RandomRemoveWords(int removeAmout, int from){

        for(int i = 0; i <= removeAmout; ) {

            Random random = new Random();

            int ToRemove = random.Next(_allVerse.Count());




            i++;
        }
    }

    private void Reset(){

        for(int x = 0; x < _allVerse.Count(); ){

            for(int y = 0; y < _allVerse[x].Get_wholeVerse().Count(); ){

                Word ThisWord = _allVerse[x].Get_wholeVerse()[y];

                ThisWord.Set_isRevealed(true);


            }
        }
    }
}