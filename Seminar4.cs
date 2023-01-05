// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

void PowerAB()
{
    Console.WriteLine("Введите число A: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int b = int.Parse(Console.ReadLine());

    int result = 1;

    for (int i = 0; i < b; i++) result *= a;

    Console.WriteLine(result);
} 

PowerAB();

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

void SumDigits(int num)
{
    int result = 0;
    string number = num.ToString();

    for(int i = 0; i < number.Length; i++)
    {
        result += num % 10;
        num /= 10;
    }

    Console.WriteLine(result);
}

SumDigits(9012);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void ShowArray (int Size)
{
    int[] array = new int[Size];
    Random rnd = new Random();

    for (int i = 0; i < Size; i++) array[i] = rnd.Next(0, 99);

    Console.WriteLine(String.Join (", ", array));
}

ShowArray(8);