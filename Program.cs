/*
- There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups
*/

using System;

string[] pettingZoo = 
[
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
];

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group1 = AssignGroups(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals()
{
    // cycle through each element in the array, select a random index, and swap it with the current element.
    Random random = new();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(i, pettingZoo.Length);
        (pettingZoo[r], pettingZoo[i]) = (pettingZoo[i], pettingZoo[r]);  // Using Tuple Swap 
    }    
}

string[,] AssignGroups(int groups = 6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int start = 0;

    for (int i = 0; i < groups; i++)  // Iterates over each group (rows)
    {
        for (int j = 0; j < result.GetLength(1); j++)  // Assigns animals to each group (columns).
        {
            result[i,j] = pettingZoo[start++];  // start++: Moves through the pettingZoo and assign animals sequentially to animal slot in group.
        }
    }
    return result;
}

void PrintGroup(string[,] groups)
{
    for (int i = 0; i < groups.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++)
        {
            Console.Write($"{groups[i,j]} ");
        }
        Console.WriteLine();
    }
}

/*
School A
Group 1: capybaras llamas pigs 
Group 2: ostriches macaws sheep
Group 3: chickens lemurs tortoises
Group 4: iguanas alpacas geese
Group 5: ducks goats kangaroos
Group 6: ponies emus rabbits
School B
Group 1: kangaroos ostriches pigs alpacas geese chickens
Group 2: ponies tortoises macaws rabbits llamas iguanas
Group 3: capybaras emus goats sheep lemurs ducks
School C
Group 1: goats macaws chickens geese pigs capybaras sheep llamas ostriches
Group 2: alpacas iguanas rabbits kangaroos lemurs emus ducks ponies tortoises
*/