//Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
string number = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введенное число: " + number);

if (number.Length >=3)
{
    Console.WriteLine("Третья цифра, введенного числа: " + number[2]);
}
else
{
    Console.WriteLine("Третьей цифры в введенном числе нет.");
}