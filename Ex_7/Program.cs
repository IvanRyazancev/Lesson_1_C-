//Показать четные числа от 1 до N

Console.WriteLine("Введите конечное число последовательности: ");
int lust_number = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <=lust_number)
{
    if (count % 2 == 0)
    {        
        Console.WriteLine(count);
        count += 2;
    }
    else
    {
        count += 1;
    }
}
