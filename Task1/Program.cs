﻿                        // Задача 1
// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
//          * M = 1; N = 5  ->  "1, 2, 3, 4, 5"
//          * M = 4; N = 8  ->  "4, 5, 6, 7, 8"

//======  ФУНКЦИЯ, КОТОРАЯ ВЫВОДИТ ЗНАЧЕНИЯ В ДИАПАЗОНЕ ОТ М ДО N (ИСПОЛЬЗУЕТСЯ РЕКУРСИЯ)  =========================
void OutNumbers(int M, int N)
{
    if(M > N) return;
    Console.Write($"{M}, ");
    OutNumbers(M+1, N);
}


//===========  ФУНКЦИЯ, КОТОРАЯ УПРАВЛЯЕТ ВСЕЙ ПРОГРАММОЙ  ================================
void Main()
{
    Console.Write("Введите начальное число (M): ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите конечное число (N): ");
    int N = Convert.ToInt32(Console.ReadLine());

    OutNumbers(M, N);
}

Main();