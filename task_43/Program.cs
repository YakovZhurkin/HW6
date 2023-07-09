// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double B1 = Prompt("Введите коориданту x первой прямой : ");
double K1 = Prompt("Введите коориданту y первой прямой : ");
double B2 = Prompt("Введите коориданту x второй прямой : ");
double K2 = Prompt("Введите коориданту y второй прямой : ");
tochka_per(B1,K1,B2,K2);
double tochka_per(double b1,double k1,double b2,double k2) 
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Координаты точки пересечения прямы : {x}|{y}");
    return 0;
}

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
