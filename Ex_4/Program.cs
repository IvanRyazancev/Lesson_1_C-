//По заданному номеру дня недели вывести его название

List<string> week = new List<string>();
{
    week.Add("Понедельник");
    week.Add("Вторник");
    week.Add("Среда");
    week.Add("Четверг");
    week.Add("Пятница");
    week.Add("Суббота");
    week.Add("Воскресенье");
}

Console.Write("Введите номер дня недели: ");
int number_day = Convert.ToInt32(Console.ReadLine());

if (number_day >= 1 && number_day <= 7)
{
    Console.Write("Название дня: ");
    Console.Write(week[number_day-1]);
}
else
{
    Console.WriteLine("Введен некорректный номер дня недели!");
}