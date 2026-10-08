//1
int totalExercises = 8;
for (int number = totalExercises; number >= 1; number--)
{
    Console.WriteLine($"Упражнение {number}");
}
Console.WriteLine("Домашнее задание готово");
//2
for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}

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
//5
for (; ; ) {
    Console.Write("Введите код группы (для выхода — «выход»): ");
    string groupCode = Console.ReadLine();
    if (groupCode == "выход") {
        break;
    }
    Console.WriteLine($"Записан код группы: {groupCode}");
}

Console.WriteLine("Работа с журналом завершена");
//самостоятельные
//A
int N = 20;
for (int i = 1; i <= N; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
//Г
for (int numberr = 1; numberr <= 50; numberr++)
{
    if (numberr % 3 == 0)
    {
        continue;
    }
    if (numberr % 7 == 0)
    {
        Console.WriteLine($"Первое число, кратное 7: {numberr}");
        break;
    }
}

//индивидуальные
//2
int e = 20;
int M = 3;
for (int a = e; a >= 0; a -= M)
{
    Console.WriteLine(a);
}
//7
for (int r = 1; r <= 5; r++)
{
    for (int b = 1; b <= 5; b++)
    {
        Console.Write((r + b) + "\t");
    }
    Console.WriteLine();
}