// №11 стр.11 
//Найти площадь кольца, внутренний радиус которого равен r, а внешний - заданному числу R(R>r)

Console.WriteLine("Введите внутренний радиус");
double R1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите внешний радиус");
double R2 = Convert.ToInt32(Console.ReadLine());

double S = Math.PI * (Math.Pow(R2, 2) - Math.Pow(R1, 2));
Console.WriteLine($"Площадь кольца {S}");

