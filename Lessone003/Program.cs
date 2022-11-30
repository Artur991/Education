Console.WriteLine("Ведите день недели от 1 до 7: ");
int numberday = Convert.ToInt32(Console.ReadLine());

if(numberday == 1)
{
  Console.WriteLine("Понедельник");
}
else if(numberday == 2)
{
  Console.WriteLine("Вторник");
}
else if(numberday == 3)
{
  Console.WriteLine("Среда");
}
else if(numberday == 4)
{
 Console.WriteLine("Четверг");
}
else if(numberday == 5)
{
  Console.WriteLine("Пятница");
}
else if(numberday == 6)
{
  Console.WriteLine("Суббота");
}
else if(numberday == 7)
{
  Console.WriteLine("Воскресение");
}      
else
{
  Console.WriteLine("Нет такого дня недели");
}

// switch (numberday){
    case 1:
        Console.WriteLine("Пн");
        break;
    case 2:
        Console.WriteLine("Вт");
        break;
    case 3:
        Console.WriteLine("Ср");
        break;
    case 4:
        Console.WriteLine("Чт");
        break;
    case 5:
        Console.WriteLine("Пт");
        break;
    case 6:
        Console.WriteLine("Сб");
        break;
    case 7:
        Console.WriteLine("Вс");
        break;  
    case > 7:
      Console.WriteLine("нет такого дня недели");
      break;

}
