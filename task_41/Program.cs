// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];
Chisla(m);
Console.Write($"\n Чисел больше нуля: {kolicestvo0(Array)}");

void Chisla(int m)
{
for (int i = 0; i < m; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int kolicestvo0(int[] Array)
{
int i=0;
int kolvo = 0;
while (i < Array.Length)
{
if(Array[i]>0)
kolvo = kolvo + 1;
i = i + 1;
}
return kolvo;
}

