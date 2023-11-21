//                                   Задача 3
//         Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//          Использовать рекурсию, не использовать циклы.

//              * [1, 2, 5, 0, 10, 34]  ->  34, 10, 0, 5, 2, 1



//===================  ФУНКЦИЯ ПО СОЗДАНИЮ МАССИВА  ==================
int[] GenerateArray()
{
    string[] str;
    Console.WriteLine("Введите числа через , :");
    str = Console.ReadLine().Split(",");

    int[] numbers = new int[str.Length];
    for(int i = 0; i < str.Length; i++)
    {
        numbers[i] = Convert.ToInt32(str[i]);
    }

    return numbers;
}


//==================  ФУНКЦИЯ ВЫВОДА МАССИВА НА ЭКРАН  =======================
void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.Write("Изначальный Массив: [");
    for(int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i] + "]");
        else Console.Write(array[i] + ", ");
    }

}

//==============  ФУНКЦИЯ, КОТОРАЯ ВЫВОДИТ МАССИВ В ОБРАТНОМ ПОРЯДКЕ (ИСПОЛЬЗУЕТСЯ РЕКУРСИЯ) ==================
void NewGenerateArray(int[] array, int len_array)
{
    if(len_array < 0) return;
    else
    {
        Console.Write(array[len_array] + " ");
    
        NewGenerateArray(array, len_array - 1);

    }
}

//===============  ФУНКЦИЯ, КОТОРАЯ УПРАВЛЯЕТ ВСЕЙ ПРОГРАММОЙ  ===============================
void Main()
{
    int[] array = GenerateArray();
    PrintArray(array);

    int len_array = array.Length - 1;
    Console.WriteLine();

    Console.Write("Обратный массив: ");
    NewGenerateArray(array, len_array);

}

Main();

