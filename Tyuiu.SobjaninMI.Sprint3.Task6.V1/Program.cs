using Tyuiu.SobjaninMI.Sprint3.Task6.V1.Lib;

Console.Title = "Спринт #3 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Вложенные циклы                                                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
Console.WriteLine("* числовому отрезку [11, 17] сумму всех делителей.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("* Отрезок: [11, 17]                                                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int start = 11;
int end = 17;
DataService ds = new DataService();
int result = ds.GetSumTheDivisors(start, end);
Console.WriteLine(result);
Console.ReadKey();