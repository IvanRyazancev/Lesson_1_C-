//Выяснить, кратно ли число заданному, если нет, вывести остаток.

int numberA = 5;
Console.Write("Введите число от 1 до 99: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданное число: " + numberA);

if (numberB % numberA == 0)
{
    Console.WriteLine("Введенное число кратно заданному.");
}
else
{
    int remains = numberB % numberA;
    Console.WriteLine("Введенное число некратно заданному. Остаток от деления:" + remains);
}