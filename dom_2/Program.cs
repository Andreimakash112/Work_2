﻿/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int uno (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
 
 int  GetThirdRank(int number)
 {
while (number >999)
  {
    number /=10;
  }  

 return number %10;
}
bool validateNumber(int number) 
{
    if(number<100)
    {
Console.Write("Трейтьего значения нет");
return false;
    }
    return true;
}
 int number = uno ("введите число");
 if (validateNumber(number))
 {
 Console.WriteLine(GetThirdRank ( number) );
 }