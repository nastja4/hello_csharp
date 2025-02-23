// string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
// int stringCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringCount; i++)
// {
//     myString = myStrings[i];
//     periodLocation = myString.IndexOf(".");

//     string mySentence;

//     while (periodLocation != -1)
//     {
//         mySentence = myString.Remove(periodLocation);

//         myString = myString.Substring(periodLocation + 1);

//         myString = myString.TrimStart();

//         periodLocation = myString.IndexOf(".");

//         Console.WriteLine(mySentence);
//     }

//     mySentence = myString.Trim();
//     Console.WriteLine(mySentence);
// }


string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

foreach (string sentenceGroup in myStrings)
{
    string[] sentences = sentenceGroup.Split('.', StringSplitOptions.RemoveEmptyEntries);

    foreach (string sentence in sentences)
    {
        Console.WriteLine(sentence.Trim());
    }
}