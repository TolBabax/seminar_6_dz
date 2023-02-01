// Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int IntupNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено не корректное число. Попробуйте еще раз.");
    }
    return number;
}

int[] GetBinaryView(int A)
{
    int i = 0;
    int[] arr = new int[A];
    while (i < A)
    {
        Console.Write("Введите число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        arr[i] = b;
        i++;
    }
    return arr;
}

int numberPos(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }
    return count;
}

int numberA = IntupNumber("Введите общее количество чисел, которые требуется ввести: ");
int[] array;
array = GetBinaryView(numberA);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Количество чисел больше нуля: {numberPos(array)}");
