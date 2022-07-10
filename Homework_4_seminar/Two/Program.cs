// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (number > 1 && number < 10000)
{
    int firstRemainsNumbers = number % 10;
    int secondRemainsNumbers = (number / 10) % 10;
    int thirdrRemainsNumbers = (number / 100) % 10;
    int fourthRemainsNumbers = (number / 1000) % 10;
    sum = firstRemainsNumbers + secondRemainsNumbers + thirdrRemainsNumbers + fourthRemainsNumbers;
    Console.WriteLine($"Cумма всех цифр в числе равна: {sum}");
}
else if (number <= 1)
{
    Console.WriteLine("Вы ввели отрицательные числа");
}
else
{
    Console.WriteLine("Вы ввели слишком большие числа");
}

