int[] first = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] second = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true;

for (int index = 0; index <= first.Length - 1; index++)
{
    if (first[index] != second[index])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}
if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}