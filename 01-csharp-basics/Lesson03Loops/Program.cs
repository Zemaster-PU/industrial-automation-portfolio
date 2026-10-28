// Lesson 03 - Loops with industrial examples

// Part 1 - for Loop: count produced parts
Console.WriteLine("Production Count:");
for (int part = 1; part <=10; part++)
{
    Console.WriteLine("Part "+ part + " produced.");
}

//Part 2 - While loop: fill the tank until it reaches 80%
double tankLevel = 55;
Console.WriteLine("Filling the Tank...");
while (tankLevel < 80.0)
{
    tankLevel = tankLevel + 5;
    Console.WriteLine("Tank level rising, level is at " + tankLevel + "%");
}
Console.WriteLine("Tank level is Full. Filling Stopped");