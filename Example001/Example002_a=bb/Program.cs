Console.Write("Введите первое число");

int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    System.Console.WriteLine("Правильно!");
}
else
{
    System.Console.WriteLine("Не подходит, пробуй еще");
}



