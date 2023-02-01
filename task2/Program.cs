// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

void Point(double a, double b, double c, double d)
{
    if (b - d == 0)
    {
        Console.Write("Измените число k1 или k2: ");
        Console.Write("Измените число k1: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Измените число k2: ");
        d = Convert.ToInt32(Console.ReadLine());  
    }

    double x = (c - a) / (b - d);     
    double y = b * x + a;
    System.Console.WriteLine($"Координаты точки пересечения двух прямых: координата х = {x}; координата у = {y}");
}



double numberB1 = IntupNumber("Введите число b1: ");
double numberK1 = IntupNumber("Введите число k1: ");
double numberB2 = IntupNumber("Введите число b2: ");
double numberK2 = IntupNumber("Введите число k2: ");

Point(numberB1, numberK1, numberB2, numberK2);