// // Task - to find two coins whose sum is equal to a target value.

int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return [curr, next];  // Return an array with the two indices
            }
        }
    }
    return [];  // Return an empty array if no solution is found
}

// Usage
int target = 60;
int[] coins = [5, 5, 50, 25, 25, 10, 5];
int[] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

/*
Change found at positions 2 and 5
*/