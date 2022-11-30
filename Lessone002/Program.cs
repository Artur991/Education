Console.WriteLine("Ведите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB*numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}   

