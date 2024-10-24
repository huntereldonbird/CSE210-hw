using System;
using System.Runtime.CompilerServices;

class Nicaea
{

   private List<Verse> _allVerse;
    public void Main()
    {
        Console.WriteLine("Welcome to Scripture memorizer!");
        int what_variable_we_in = -1;

        Random thisranddom = new Random();
        what_variable_we_in = thisranddom.Next(_allVerse.Count());

        //get and set scripture here then display
        while (true)  
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                int random_remove_num = 0;
                Random random = new Random();
                random_remove_num = random.Next(1,4);

                RandomRemoveWords(random_remove_num, what_variable_we_in);
                //display the scripture here


            }
        }
    }

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