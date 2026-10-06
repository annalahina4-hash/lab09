//3
int totalWeeks = 3;
for (int week = 1; week <= totalWeeks; week++)
{
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя{week}, день {day}");
    }
    Console.WriteLine("^_^");
}
//4
int s = 0;
for (int ticket = 1; ticket <= 30; ticket++)
{
    if (ticket == 4 || ticket == 12 || ticket == 19)
    {
        s++;
        continue;
    }
    Console.WriteLine($"Первый доступный билет:{ticket}");
    break;
}
Console.WriteLine($"Пропущенные: {s}");

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
//самостоятельные

//индвид