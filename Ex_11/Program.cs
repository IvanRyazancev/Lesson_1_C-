//Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100,999); 
string numberA = Convert.ToString(number);
Console.Write("Сгенерированное число: ");
Console.WriteLine(numberA);

Console.WriteLine("Удаленное число:" + numberA[1]);
Console.WriteLine("Новое число:" + numberA.Remove(1, 1));