// программа на вход принимает трёхзначное число и на выходе показ вторую цифру
/*
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трёхзначное число: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число, поэжалуйста повторите ввод: ");
    return;
}

Console.WriteLine($"Введёное число {number} ");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра {secondRank} ");
*/
//программа выводит 3 цифру заданного числа или сообщает что ее нет
/*
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
ink GetThirdRank(int number)
{
    while(number > 999)
    {
        number /= 10
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    returne true;
}

int number = Prompt ("Введите число: ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}
*/
//программа принимает на вход цифру и проверяет выходной ли это
/*
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool Isweekend(int weekDay);
{
    if (weekDay > 5);
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number);
{
    if (number > 0 && num <=7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели");
    return false;
}

int weekDay = Prompt("Введите номер дня недели (от 1 до7): ");
if (ValidateWeekday(weekDay))
{
    if (weekend(numday))
    {
        Console.WriteLine("Выходной!");
    }
    else
    {
        Console.WriteLine("Будний день!");
    }
}
*/
