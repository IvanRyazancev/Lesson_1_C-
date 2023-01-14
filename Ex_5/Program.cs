//Найти максимальное из трех чисел

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max_number = 0;

if (numberA > numberB)
{
    max_number = numberA;    
}
else
{
    max_number = numberB;
}

if (max_number < numberC)
{
    max_number = numberC;
    Console.Write("Максимальное число: ");
    Console.Write(max_number);   
}
else
{
    Console.Write("Максимальное число: ");
    Console.Write(max_number);
}