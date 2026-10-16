using Tyuiu.SobjaninMI.Sprint3.Task4.V8.Lib;

Console.Title = "Спринт #3 | Выполнил: Собянин М. И. | СМАРТб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Операторы цикла с прерыванием                                     *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Собянин Михаил Игоревич | СМАРТб-26-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
Console.WriteLine("* функции y = (x / sin(x)) + 0.5. При x = 0 прервать цикл.                *");
Console.WriteLine("* Полученные значения перемножать.                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("* x изменяется от -5 до 5                                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int start = -5;
int end = 5;
double result = ds.Calculate(start, end);
Console.WriteLine(result);
Console.ReadKey();