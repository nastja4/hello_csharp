string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

foreach (string sentenceGroup in myStrings)
{
    string[] sentences = sentenceGroup.Split('.', StringSplitOptions.RemoveEmptyEntries);

    foreach (string sentence in sentences)
    {
        Console.WriteLine(sentence.Trim());
    }
}