// №7 стр.11
//Даны два действительных числа x и y. Вычислить их сумму, разность, произведение частное

Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());

int sum = x + y;
int differ = x - y;
int multip = x * y;
double quotient = (Convert.ToDouble(x) / Convert.ToDouble(y));


Console.WriteLine($"Сумма {sum}");
Console.WriteLine($"Разность {differ}");
Console.WriteLine($"Произведение {multip}");
Console.WriteLine($"Частное {quotient}");

