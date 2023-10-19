int[] numbers = { 12, 22, 34, 56, 67 }; 
// масив от числа, дължината на масива е 5 елемента, всяко от числата си има позиция (индекс)
// индексите започват да се броят от 0 - в нашия случай числото 12 е с индекс 0, числото 67 с индекс 4
int lenght = numbers.Length; // съхранено в променлива, дължината на масива = брой на елементи
Console.WriteLine(numbers.Length); // дължината на масива = брой на елементи

// как да достъпя първия елемент от масив
Console.WriteLine(numbers[0]); // в квадратните скоби слагаме позицията на елемента

// как да взема последния елемент
Console.WriteLine(numbers[numbers.Length - 1]);

// вземи 4 числа от конзолата и ги съхрани
int[] prices = new int[4];

prices[0] = 5;
prices[1] = 34;
prices[2] = 56;
prices[3] = 98;

//прочитане на масив от цели числа от конзолата
int[] number = Console.ReadLine() // 5 3 6 3 4                  
                       .Split(" ") //["5", "3", "6", "3", "4"
                       .Select(int.Parse) // [5, 3, 6, 3, 4]
                       .ToArray();

// конвертиране от текст в масив
string text = "dog, cat, frog, rabbit, turtle";
string[] animals = text.Split(',');
// от масив в текст
Console.WriteLine(string.Join(" ", animals));

//масив с дробни числа
double[] grades = { 3.40, 4.50, 5.60, 6.00 };
//length = 4
//ако ще работя с индексите на масива - ползвам for loop
for (int index = 0; index < animals.Length; index++)
{

}
// ако ще работя с елемнти на масива (без да ми трябват индексите) - ползвам foreach loop
foreach (double grade in grades)
{
    //какво повтаряме за всяка една дробна стойност
    Console.WriteLine(grade);
}