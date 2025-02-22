bool validEntry;
string? readResult;
string editedInput;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();

    editedInput = readResult.Trim().ToLower();
    if (editedInput == "administrator" || editedInput == "manager" || editedInput == "user")
    {
        validEntry = true;
    }
    else
    {
        validEntry = false;
        Console.WriteLine($"The role name that you entered, '{readResult}' is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (!validEntry);

Console.WriteLine($"Your input value {readResult} has been accepted.");