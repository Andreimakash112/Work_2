int uno (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = uno("Введите число");
if (number <100 && number>=1000)
{
   Console.WriteLine("Число не трех значное.Введите трех значное число") ;
   return;
}
 Console.WriteLine($"Введенное число `{number}`") ;
 int x = number / 10 % 10;
 Console.WriteLine($"Вторая цифра `{x}`");