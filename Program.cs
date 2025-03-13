﻿string[] words = ["racecar" ,"talented", "deified", "tent", "tenet"];

Console.WriteLine("Is it a palidrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }
    return true;
}

/*
Is it a palidrome?
racecar: True
talented: False
deified: True
tent: False
tenet: True
*/