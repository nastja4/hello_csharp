// Task - to find more pairs of coins whose sum is equal to the target value.

int target = 30;
int[] coins = [5, 5, 50, 25, 25, 10, 5];
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i,0] == -1)  // Stops printing when -1 is found
        {
            break;
        }        
        Console.WriteLine($"{result[i,0]}, {result[i,1]}");
    }
}

// Method
int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};   // Storage for up to 5 pairs (indicating empty slots).
    int count = 0;  // Tracks how many pairs have been found

    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;  // Store first index
                result[count, 1] = next;  // Store second index
                count++;
            }
            if (count == result.GetLength(0))  // dimension for 2D arrays = 0 → Returns the number of rows (outer array size). (1 - the number of columns)
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}

/*
Change found at positions:
0, 3
0, 4
1, 3
1, 4
3, 6
*/