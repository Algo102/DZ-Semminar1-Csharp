// При вводе 0, программа предложит повторить ввод другого числа
Console.WriteLine("Проверяем является ли число чётным");
l1:

Console.WriteLine("Ведите свое число");
int number = Convert.ToInt32(Console.ReadLine());

int chetn = number % 2;
if (number == 0)
{
  Console.WriteLine("Вы ввели: " + number + ". Введите число снова");
  goto l1;
}

if (chetn == 0)
{
  Console.WriteLine("Ваше число: " + number + " четное");
}
else
{
  Console.WriteLine("Ваше число: " + number + " НЕ четное");
}

