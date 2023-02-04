Console.WriteLine("Проверяем, кратно ли число заданному, если нет, выводим остаток.");
Console.WriteLine("Введите кратное число");
double number1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите делитель");
double number2 = double.Parse(Console.ReadLine() ?? "0");

double kratn = number1 % number2; // узнаем кратное или нет


//Console.WriteLine(kratn + " " + kratnD + " " + celoe + " " + ostatok);

if (kratn == 0)
{
  Console.WriteLine($"Ваше число {number1} кратное c делителем {number2}");
}
else
{
  double kratnD = number1 / number2; // дробный результат
  double celoe = Math.Round(kratnD); // округление до целого
  double ostatok = kratnD - celoe; // Остаток
  Console.WriteLine($"Ваше число {number1} НЕ кратное c делителем {number2}");
  Console.WriteLine($"Остаток после деления равен: {ostatok}");
}