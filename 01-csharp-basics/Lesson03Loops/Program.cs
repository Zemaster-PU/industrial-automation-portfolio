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
// ===== Catch-up exercises - Lesson 3 =====
// Exercise 1 (beginner): Countdown
// With a for loop, print a countdown from 5 to 1, then print "Cycle started!"
// (Hint: start at 5, continue while >= 1, and decrease with part--.)

// Exercise 2 (intermediate): Quality control
// With a for loop from 1 to 20 parts, print each part number.
// Every 5 parts, ALSO print "--> Quality check done."
// (Hint: inside the loop, use an if with part % 5 == 0. The % operator
// gives the remainder of a division.)
