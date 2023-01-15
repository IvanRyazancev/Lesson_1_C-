// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10,99); 
string numberA = Convert.ToString(number);
Console.Write("Сгенерированное число: ");
Console.WriteLine(numberA);

if (numberA[0] > numberA[1])
{    
    Console.WriteLine("Наибольшая цифра, сгенерированного числа:" + numberA[0]);
}
else
{
    Console.WriteLine("Наибольшая цифра, сгенерированного числа:" + numberA[1]);
}