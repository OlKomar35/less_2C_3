//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int NumDayEntry()
{
    Console.Write("Введите цифру, дня недели= ");
    return Convert.ToInt32(Console.ReadLine());
}

void Weekday(int numDay)
{
    if (numDay < 1 || numDay > 7)
    {
        Console.WriteLine("В неделе всего 7 дней,неверный ввод");
    
    }
    else
    {
        if (numDay >= 6) { Console.WriteLine("Сегодня выходной!!!"); }
        else{ Console.WriteLine("Сегодны будний день!");}
    }
}

Weekday(NumDayEntry());