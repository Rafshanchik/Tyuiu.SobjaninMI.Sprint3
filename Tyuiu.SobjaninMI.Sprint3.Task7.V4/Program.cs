using Tyuiu.SobjaninMI.Sprint3.Task7.V4.Lib;

Console.Title = "Спринт #3 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Табулирование функции                                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
Console.WriteLine("* F(x) = (2x + 6) / (cos(x) + x) - 3                                      *");
Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5; 5] с шагом 1.  *");
Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
Console.WriteLine("* Значения занести в массив!                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int start = -5;
int end = 5;
Console.WriteLine("Старт шага = " + start);
Console.WriteLine("Конец шага = " + end);

DataService ds = new DataService();
int len = end - start + 1;
double[] res;
res = new double[len];

res = ds.GetMassFunction(start, end);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+---------+----------+");
Console.WriteLine("|    X    |   f(x)   |");
Console.WriteLine("+---------+----------+");
for (int i = 0; i < len; i++)
{
    Console.WriteLine("|{0,5:d}    |  {1, 6:f2}  |", start, res[i]);
    start++;
}
Console.WriteLine("+---------+----------+");
Console.ReadKey();