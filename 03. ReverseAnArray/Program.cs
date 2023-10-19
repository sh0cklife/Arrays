int n = int.Parse(Console.ReadLine());

int[] number = new int[n];

for (int index = 0; index <= number.Length - 1; index++)
{
    number[index] = int.Parse(Console.ReadLine());
}

for (int index = number.Length - 1; index >= 0; index--)
{
    Console.Write(number[index]);
    Console.Write(" ");
}