﻿int dayNumber = int.Parse(Console.ReadLine());

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

if (dayNumber >= 1 &&  dayNumber <= 7)
{
    Console.WriteLine(days[dayNumber - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}