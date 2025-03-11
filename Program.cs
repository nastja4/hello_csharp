using System;

int[] times = [800, 1200, 1600, 2000];
int diff = 0;

Console.WriteLine("Enter current GMT");  // e.g., 5 for GMT+5, -3 for GMT-3
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }

// Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
    // for (int i = 0; i < times.Length; i++)
    // {
    //     times[i] = (times[i] + diff) % 2400;
    // }
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
    // for (int i = 0; i < times.Length; i++)
    // {
    //     times[i] = (times[i] + diff) % 2400;
    // }
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();
// foreach (int val in times)
// {
//     string time = val.ToString();
//     int len = time.Length;

//     if (len >= 3)
//     {
//         time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//         time = time.Insert(0, "0:");
//     }
//     else 
//     {
//         time = time.Insert(0, "0:0");
//     }

//     Console.Write($"{time} ");
// }

// Console.WriteLine();


// Methods
void DisplayTimes()
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else 
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
    Console.WriteLine();
}

void AdjustTimes()
{
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = (times[i] + diff) % 2400;
    }
}

/*
Enter current GMT
-6
Current Medicine Schedule:
8:00 12:00 16:00 20:00 
Enter new GMT
+6
New Medicine Schedule:
20:00 0:00 4:00 8:00 
PS C:\Users\fazius\GitHub_projects\helloworld> 
*/