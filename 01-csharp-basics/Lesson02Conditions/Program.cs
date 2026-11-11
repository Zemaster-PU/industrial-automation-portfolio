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


// ===== Catch-up exercises - Lesson 2 =====
// Exercise 1 (beginner): Temperature check
// Declare double temperature = 73.5 and double temperatureLimit = 70.0.
// If the temperature is above the limit, print "WARNING: Temperature too high!"
// Otherwise, print "Temperature is OK."

// Exercise 2 (intermediate): Can the machine start?
// A machine may start ONLY if the safety door is closed AND the tank level
// is at least 20. Declare: bool doorClosed = true.
// Using && (AND), print "Machine can start." or "Start blocked - check the conditions."
// Then test with doorClosed = false, and with tankLevel = 15.
