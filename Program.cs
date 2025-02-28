string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = ['[', '{', '('];

// Keeps track of where the last matching closing symbol was found
int closingPosition = 0;

// Looping through the string
while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    // Determining the matching closing symbol
    string currentSymbol = message.Substring(openingPosition, 1);
    char matchingSymbol = ' ';
    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // Finding the closing symbol & extracting the content
    openingPosition += 1;  // Move to the start of the enclosed content
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

/*
What if
different symbols
open symbol
matching closing symbol
*/