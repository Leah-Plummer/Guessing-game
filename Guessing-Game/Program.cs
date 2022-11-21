using System;
void GuessingGame()
{
    pickANumber();
};
int theSecretNumber = 42;
void pickANumber()
{
    Console.Write("Guess the number? (1-50):");
    int userGuess = int.Parse(Console.ReadLine());
    int i = 1;
    while (userGuess != theSecretNumber && i < 4)
    {


        if (userGuess != theSecretNumber)
        {
            Console.WriteLine($"Chance {1-50}");
            Console.WriteLine("Try again (1-50):");
            
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
        Console.WriteLine("Sorry your wrong");

    }
}




GuessingGame();


