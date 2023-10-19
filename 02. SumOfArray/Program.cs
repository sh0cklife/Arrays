int[] number = Console.ReadLine()                
                       .Split(" ")
                       .Select(int.Parse)
                       .ToArray();

int sum = 0;

for (int index = 0; index < number.Length; index++)
{
    sum += number[index];
}

Console.WriteLine(sum);