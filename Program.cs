//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b (степень числа a): ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}

Console.WriteLine($"Результат возведения числа a в степень b: {result}" );

//------------------------------------------------------------------------------------------------------
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Input a number: ");
// int a = Convert.ToInt32(Console.ReadLine()); 

// int SummOfDigit(int number)
// {
//     int sum = 0;
//     for (int i = 0; i <= sum; i++)
//     {
//         number = a % 10;
//         a = a / 10;  
//         sum = sum + number;     
//     }
//     return sum;
// }

// Console.WriteLine($"Summ of numbers in digit is {SummOfDigit(a)} ");
//------------------------------------------------------------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Input a length of array: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[m];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Input {i+1} element of array: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.Write("Output an array: ");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"{array[i]} ");
// }

// Console.WriteLine();