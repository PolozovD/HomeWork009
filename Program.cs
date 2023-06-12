int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Math.Abs(Convert.ToInt32(value));
    return result;
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     if(n > 0)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n - 1);
//     }
// }

// ShowNumbers(5);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNum (int num1, int num2)
// {
//     int sum = 0;
//     if(num1 < num2)
//     {
//         sum += SumNum(num1 + 1, num2) + num1;
//         return sum;
//     }
//     else if(num1 > num2)
//     {
//         sum += SumNum(num1 , num2 + 1) + num2;
//         return sum;
//     }
//     else return sum;
// }

// int num1 = Prompt("Input first number: ");
// int num2 = Prompt("Input second number: ");

// int sumNum = SumNum(num1, num2);
// Console.WriteLine(sumNum + num2);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int m = InputNumbers("Input m: ");
// int n = InputNumbers("Input n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }