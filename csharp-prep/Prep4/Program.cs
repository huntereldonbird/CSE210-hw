using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> inputs = new List<int>();

        int UserInput = -1;

        do {

            Console.Write("What number would you like to add?: ");
            UserInput = int.Parse(Console.ReadLine());


            if (UserInput == 0){

                
                int sum = 0;
                foreach (int i in inputs){
                    sum += i;
                }
                Console.WriteLine($"the sum is {sum}");

                float avg = ((float)sum) / inputs.Count;

                int largest = 0;
                foreach (int x in inputs) {

                    if (x > largest){
                        largest = x;
                    }
                }

                Console.WriteLine($"The Largest Number is: {largest}");

            }
            else{

            }

        }
        while (UserInput != 0);


    }

}