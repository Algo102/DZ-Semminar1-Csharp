//Можно было решить и через массив и через операторы выбора, но это мне показалось проще, т.к. дней всего 7

Console.WriteLine("Программа по заданному номеру дня недели выводит его наименование");
Console.WriteLine("Ведите номер дня");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 1)
{
  Console.WriteLine("Номер дня " + (numberDay) + " соответствует ПОНЕДЕЛЬНИКУ");
}
else
{
  if (numberDay == 2)
  {
    Console.WriteLine("Номер дня " + (numberDay) + " соответствует ВТОРНИКУ");
  }
  else
  {
    if (numberDay == 3)
    {
      Console.WriteLine("Номер дня " + (numberDay) + " соответствует СРЕДЕ");
    }
    else
    {
      if (numberDay == 4)
      {
        Console.WriteLine("Номер дня " + (numberDay) + " соответствует ЧЕТВЕРГУ");
      }
      else
      {
        if (numberDay == 5)
        {
          Console.WriteLine("Номер дня " + (numberDay) + " соответствует ПЯТНИЦЕ");
        }
        else
        {
          if (numberDay == 6)
          {
            Console.WriteLine("Номер дня " + (numberDay) + " соответствует СУББОТЕ");
          }
          else
          {
            if (numberDay == 7)
            {
              Console.WriteLine("Номер дня " + (numberDay) + " соответствует ВОСКРЕСЕНИЮ");
            }
            else
            {
              Console.WriteLine("Вы что-то не то ввели, запустите программу снова");
            }
          }
        }
      }
    }
  }
}
