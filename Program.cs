string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1: Split the sentence into words
string[] words = pangram.Split(' ');

// Step 2: Reverse each word using a loop and Array methods
for (int i = 0; i < words.Length; i++)
{
    // Convert word to char array, reverse it, and convert back to string
    char[] charArray = words[i].ToCharArray();
    Array.Reverse(charArray);
    words[i] = new string(charArray);
}

// Step 3: Join the modified words back into a sentence
string result = string.Join(" ", words);

// Print the result
Console.WriteLine(result);

/*
string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    char[] charArray = words[i].ToCharArray();
    Array.Reverse(charArray);
    words[i] = new string(charArray);
}

string result = string.Join(" ", words);
Console.WriteLine(result);
*/
