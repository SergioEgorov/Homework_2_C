Console.Write("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void dayOfWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день недели выходной");
    }
    else if (dayNumber <1 || dayNumber > 7)
    {
        Console.WriteLine("Такого дня недели не существует!");
    }
    else 
    {
        Console.WriteLine("Этот день недели невыходной");
    }


}
dayOfWeek(dayNumber);
