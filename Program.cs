int numericValue;
bool validEntry;

Console.WriteLine("Enter an integer value between 5 and 10.");

do 
{
    string? readResult = Console.ReadLine();

    if (int.TryParse(readResult, out numericValue))
    {
        if (numericValue > 5 && numericValue < 10)
        {
            validEntry = true;
        }
        else
        {
            validEntry = false;
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        validEntry = false;
        Console.WriteLine("Sorry, you entered an invalid input, please try again.");
    }
} while (!validEntry);

Console.WriteLine($"Your input value {numericValue} has been accepted.");

