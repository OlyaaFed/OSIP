// №3 стр.11
//Вычислить длину окружности и площадь круга с заданным радиусом R

Console.WriteLine("Введите радиус");
double r = Convert.ToInt32(Console.ReadLine());
double s = Math.PI * Math.Pow(r, 2);
double l = 2 * Math.PI * r;
Console.WriteLine($"длина  {l}");
Console.WriteLine($"площадь  {s}");