                        //  Задача 2
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

//                  * m = 2, n = 3  ->  A(m, n) = 29


//===============  ФУНКЦИЯ, КОТОРАЯ РАСЧИТЫВАЕТ ФУНКЦИЮ АНКЕРМАНА  ========================
//===============  И ВОЗВРАЩАЕТ ЗНАЧЕНИЕ (ИСПОЛЬЗУЕТСЯ РЕКУРСИЯ)  =========================
int Ackerman(int n, int m)
{
    if( n == 0) return m + 1;
    else if (m == 0) return Ackerman(n - 1, 1);
    else return Ackerman(n - 1, Ackerman(n, m - 1));
}


//===============  ФУНКЦИЯ, КОТОРАЯ УПРАВЛЯЕТ ВСЕЙ ПРОГРАММОЙ  ===============================
void Main()
{
    Console.Write("Введите первое число (n): ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число (m): ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    
    int total = Ackerman(n, m);
    Console.Write($"n = {n}, m = {m} -> A(n, m) = {total}");
}

Main();