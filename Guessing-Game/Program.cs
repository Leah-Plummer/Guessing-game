using System;
void GuessingGame()
{
    pickANumber();
};

void pickANumber()
{
    Console.WriteLine("Enter a difficulty level (Easy, Medium, Hard)");
    
    string userLevel = Console.ReadLine().ToLower();
  
    int guesses = 0;

     while (userLevel != "easy" && userLevel != "medium" && userLevel != "hard")
    {
        Console.Write("Please enter either easy, medium, or hard.");
        userLevel = Console.ReadLine().ToLower();

    }

        if (userLevel == "easy") 
        { 
            guesses =  8;
        }
        else if (userLevel == "medium")
        {
            guesses = 6; 
        }
        else if (userLevel == "hard")
        {
            guesses = 4; 
        }
        
    Console.WriteLine("Guess the number? (1-100):");

    int theSecretNumber = new Random().Next(1, 101);
    int userGuess = int.Parse(Console.ReadLine());
    int i = 1;
    while (userGuess != theSecretNumber && i < guesses)
    {


        if (userGuess != theSecretNumber)
        {
           if (userGuess > theSecretNumber){
                Console.WriteLine("Too High");
           }else {
                Console.WriteLine("Too Low");
           };
            Console.WriteLine($"You have {guesses - i} guesses left!");
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


