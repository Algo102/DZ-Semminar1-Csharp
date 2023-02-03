// 0 отсекает
Console.WriteLine("Программа выводит все четные числа до введенного");
l1:
Console.WriteLine("Введите цело и положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
  {
    Console.WriteLine("Вы ввели: " + number + ". Введите число снова");
    goto l1;
  }

int count = 1;

while (count < number+1)
{
  if (count % 2 == 0)
  {
    Console.Write("  " + count);
    count++;
  }
  else
  {
    count++;
  }
}
