Console.WriteLine("Программа выводит большую цифру у двузначного числа");
l1:
Console.WriteLine("Ведите двузначное число");
int number = Convert.ToInt32(Console.ReadLine());

int posl = number % 10;
int perv = (number - posl)/10;

if (perv == posl)
{
  Console.WriteLine("Первая и вторая цифра одинаковые, введите чило снова");
  goto l1;
}
else
{
  if (perv > posl)
  {
    Console.WriteLine($"Первая цифра {perv} больше {posl}");
  }
  else
  {
    Console.WriteLine($"Вторая цифра {posl} больше {perv}");
  }
}