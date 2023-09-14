// №10 стр.11
//Известна длина окружности. Найти площадь круга, ограниченного этой окружностью

Console.WriteLine("Введите длинну окружности");
double l = Convert.ToDouble(Console.ReadLine());

double R = l / (2 * Math.PI);
double S = (Math.PI*Math.Pow(R,2));
Console.WriteLine($"Площадь круга {S}");

