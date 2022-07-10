// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/////////// 1 вариант :
Console.WriteLine("Введите 1 число:");
int firstNamber = Convert.ToInt32(Console.ReadLine()); // условно число 3
Console.WriteLine("Введите 2 число:");
int secondNamber = Convert.ToInt32(Console.ReadLine()); // условно число 5
int result = firstNamber; // тут 9 ка в 1 круге, во 2 круге = 9*3=27, 3 круг = 27*3=81,4круг = 81*3 = 243,на 5 круг не заходим i < secondnamber;

for (int i = 1; i < secondNamber; i++) // пока индекс будет меньше 2 числа делай с 1 по тому что с 0 еще 1 круг лишний 
{
    result *= firstNamber; // число 3 умножаем на result - в котором лежит переменная firstnamber (3*3=9)
}
Console.WriteLine($"A в степени B равно: {result}");


//////вариант 2 :
//double result = 0; // переменная куда мы записывам результат для 2 варианта
//  for (int i = 0; i < secondNamber; i++)
// {
//     result = Math.Pow(secondnNamber, firstNamber);
// }
// Console.WriteLine($"A в степени B равно: {result}");

// //// Вариант без цикла с методом Math.Pow:
// Console.WriteLine(Math.Pow(secondNamber, firstNamber));