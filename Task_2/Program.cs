Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberArray = Convert.ToString(number);

if(numberArray.Length > 2)
{
    Console.WriteLine($"Третья цифра {numberArray[2]}");
}
else
{
   Console.WriteLine("Третьей цифры нет!"); 
}
