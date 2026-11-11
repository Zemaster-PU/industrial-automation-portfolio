// Lesson 1 - Variables with industrial examples

// int: a whole number, no decimals
int partsCount = 12;

// double: a number with decimals
double tankLevel = 68.5;

// bool: a true or false value
bool motorRunning = true;

// string: text, always in double quotes
string machineName = "Filling Station 1";

Console.WriteLine (machineName);
Console.WriteLine ("Parts produced: " + partsCount);
Console.WriteLine ("Tank level: " + tankLevel + "%");
Console.WriteLine ("motor Running: " + motorRunning);

// a Variable can change value
tankLevel = 45.2;
Console.WriteLine ("New Tank level: " + tankLevel + "%");


// ===== Catch-up exercises - Lesson 1 =====
// Exercise 1 (beginner): A second machine
// Declare variables for another machine: name "Packaging Station 2",
// partsCount = 25, motorRunning = false, temperature = 36.5 (double).
// Print all four values, one per line, with a label for each.

// Exercise 2 (intermediate): How many liters are in the tank?
// The tank capacity is 1000 liters. Using tankLevel from the lesson (a %),
// calculate and print: the current volume in liters, and how many liters
// are missing to fill the tank.
