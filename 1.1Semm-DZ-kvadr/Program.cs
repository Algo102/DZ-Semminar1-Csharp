Console.WriteLine("По двум заданным числам проверяем является ли первое квадратом второго");
Console.WriteLine("Ведите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1/number2 == number2)
{
  Console.WriteLine("Да, первое число " + (number1) + " является квадратом " + number2);
}
else
{
  Console.WriteLine(number1 + " НЕ является квадратом " + number2);
}