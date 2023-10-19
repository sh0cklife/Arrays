using System.Runtime.ExceptionServices;

int[] first = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] second = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int number in first)
{
    foreach (int number2 in second)
    {
        if (number == number2)
        {
            Console.Write(number + " ");
        }
    }
}