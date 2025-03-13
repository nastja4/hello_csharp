Random random = new();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

// method should retrieve user input (Y/N) and determine if the user wants to play again
bool ShouldPlay() => Console.ReadLine().Trim().Equals("y", StringComparison.OrdinalIgnoreCase);

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

// Create methods that set target and roll to random values in the correct range
int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}


// method should determine if the player has won or lost
string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose :(";
}

/*
Would you like to play? (Y/N)
y
Roll a number greater than 3 to win!
You rolled a 2
You lose :(

Play again? (Y/N)

*/

