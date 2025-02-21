Random random = new();
int healthPointsHero = 10;
int healthPointsMonster = 10;

do
{
    int attackValueHero = random.Next(1, 11);
    healthPointsMonster -= attackValueHero;
    Console.WriteLine($"Monster was damaged and lost {attackValueHero} health and now has {healthPointsMonster} health");

    if (healthPointsMonster <= 0) continue;
    
    int attackValueMonster = random.Next(1, 11);
    healthPointsHero -= attackValueMonster;
    Console.WriteLine($"Hero was damaged and lost {attackValueMonster} health and now has {healthPointsHero} health"); 
} while (healthPointsHero > 0 && healthPointsMonster > 0);

Console.WriteLine(healthPointsHero > healthPointsMonster ? "Hero wins!" : "Monster wins!");
 

 