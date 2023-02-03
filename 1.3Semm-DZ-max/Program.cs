Console.WriteLine("Ищем максимальное из трех чисел");
Console.WriteLine("Ведите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 & number1 > number3 )
{
  Console.WriteLine("Число " + number1 + " самое большое");
}

if (number2 > number1 & number2 > number3 )
{
  Console.WriteLine("Число " + number2 + " самое большое");
}

if (number3 > number2 & number3 > number1 )
{
  Console.WriteLine("Число " + number3 + " самое большое");
}

if ((number1 == number2) || (number1 == number3) || (number2 == number3) )
{
  Console.WriteLine("Некоторые числа повторяются, пожалуйста повторите ввод");
}