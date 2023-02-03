Console.WriteLine("Программа выводит третью цифру");
Console.WriteLine("Ведите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int rez = number % 10;

Console.WriteLine("Проверяйте: " + rez);