// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int InputInt(string message) //целочисленный ввод с клавиатуры
{
    Console.Write($"{message} > ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) // проверка правильности ввода числа
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); // exit code программы при ошибке
    return 0; // функция возвращает 0, потому что надо что-то возвращать int
}

int SumPositiveNumbersInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    return sum;
}

int quantityNumbers = InputInt("Укажите количество вводимых чисел");
int[] arrayOfNumbers = new int[quantityNumbers];
for (int i = 0; i < quantityNumbers; i++)
{
    arrayOfNumbers[i] = InputInt($"Введите {quantityNumbers}-е число");
}
Console.WriteLine($"Число введенных положительных чисел равно {SumPositiveNumbersInArray(arrayOfNumbers)}"); 
