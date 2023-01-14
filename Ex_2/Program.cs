//Вывести квадрат числа

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(number, 2);

Console.Write("Квадрат введенного числа :");
Console.Write(result);