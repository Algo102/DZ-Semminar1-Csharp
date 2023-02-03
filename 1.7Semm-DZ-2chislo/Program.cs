Console.WriteLine("Программа выводит вторую цифру");
Console.WriteLine("Ведите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int posl = number % 10;
int predposl = (number - posl)/10;
int rez = predposl % 10;


Console.WriteLine("Проверяйте: " + rez);
