Console.WriteLine("Программа удаляет вторую цифру трёхзначного числа");
Console.WriteLine("Ведите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int three = number % 10;
int onetwo = (number - three)/10;
int two = onetwo % 10;
int twothree = number % 100;
int one = (number - twothree) / 10;
int onethree = one + three;

//Console.WriteLine(one + " " + twothree + " " + number + " " + onetwo + " " + two + " " + three + " " + onethree );
Console.WriteLine("Результат после удаления второго числа " + onethree);