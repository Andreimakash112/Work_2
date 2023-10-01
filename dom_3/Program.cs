 /*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
int uno (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool isWeekend( int weekdey)
{
    if(weekdey > 5)
    {
        return true;
    }
        return false;
}
bool ValidateWeekday( int number)
{
    if(number >0 && number <= 7)
    {
         return true; 
    }
    Console.WriteLine("Это не  верно");
    return false;
}
int Weekday = uno ("Введите день недели");
if ( ValidateWeekday(Weekday))
{
    if(isWeekend(Weekday))
    {
 Console.WriteLine("Выходной");
    }
    else
     {
Console.WriteLine("Рабочий");
    }
}