using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        //1
        Console.WriteLine("Введите фамилию и инициалы (Иванов И.И. или Иванов ИИ):");
        string input = Console.ReadLine();

        string pattern = @"^[А-Я][а-я]+ [А-Я]\.[А-Я]\.$|^[А-Я][а-я]+ [А-Я]{2}$";

        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Всё Верно.");
        }
        else
        {
            Console.WriteLine("Используйте формат: Иванов И.И. или Иванов ИИ");
        }

        //2
        Console.WriteLine("Введите адрес электронной почты:");
        string input2 = Console.ReadLine();

        string pattern2 = @"^[A-Za-z][A-Za-z0-9_]{2,15}@[A-Za-z0-9]+(\.[A-Za-z0-9]+)*\.[A-Za-z]{2,3}$";

        if (Regex.IsMatch(input, pattern2))
        {
            Console.WriteLine("Корректно");
        }
        else
        {
            Console.WriteLine("Некорректно.");
        }

        //3
        Console.WriteLine("Введите дату в формате Число-Месяц-Год (например, 01-04-2015):");
        string input3 = Console.ReadLine();

        string pattern3 = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-(\d{4})$";

        if (Regex.IsMatch(input, pattern3))
        {
            Console.WriteLine("Дата корректна.");
        }
        else
        {
            Console.WriteLine("Дата некорректна.");
        }
    }
}

