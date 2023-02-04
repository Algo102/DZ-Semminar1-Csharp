Console.WriteLine("Программа ещет 3 число");
l1:
Console.Write("Вводите цифры числа через пробел ");
string enterElem = Console.ReadLine();
string[] word = enterElem.Split(' ');

byte[] arrEnt = new byte[word.Length];

for (int i = 0; i < word.Length; i++)
{
  string sum = word[i].Trim();
  arrEnt[i] = Convert.ToByte(sum);
}

if (arrEnt.Length < 2)
{
  Console.WriteLine ("В веденом числе меньше трех цифр");
  goto l1;
}
else
{
  Console.WriteLine("Третья цифра в введеном числе:" + arrEnt[2]);
}





