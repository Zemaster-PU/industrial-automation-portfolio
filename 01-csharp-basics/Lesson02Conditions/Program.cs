// Lesson 2 - Conditions With industrial example

double tankLevel = 68.5;
double highLevelLimit = 80.0;
double lowLevelLimit = 20.0;

Console.WriteLine("Tank Level: " + tankLevel + "%");

if (tankLevel >= highLevelLimit)
{
    Console.WriteLine("ALARM: Tank level is too high!");
}
else if(tankLevel <= lowLevelLimit)
{
    Console.WriteLine("ALARM: Tank level is too low!");
}
else
{
    Console.WriteLine("TankLevel is Normal.");
}

