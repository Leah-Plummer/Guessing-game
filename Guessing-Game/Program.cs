using System;
void GuessingGame()
{
    pickANumber();
};

void pickANumber()
{
    Console.Write("Guess the number? (1-100):");

    int theSecretNumber = new Random().Next(1, 101);
    int userGuess = int.Parse(Console.ReadLine());
    int i = 1;
    while (userGuess != theSecretNumber && i < 4)
    {


        if (userGuess != theSecretNumber)
        {
           if (userGuess > theSecretNumber){
                Console.WriteLine("Too High");
           }else {
                Console.WriteLine("Too Low");
           };
            Console.WriteLine($"Chance {i + 1}");
            Console.WriteLine("Try again (1-100):");
            
            userGuess = int.Parse(Console.ReadLine());

        }



        i++;
    }
    if (userGuess == theSecretNumber)
    {
        Console.WriteLine("You guessed it!");

    }
    else
    {
        Console.WriteLine("Sorry you're wrong");

    }
}




GuessingGame();


