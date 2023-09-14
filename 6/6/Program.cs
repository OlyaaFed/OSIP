// №6 стр.11
//Вычислить расстояние между двумя точками с заданными координатами (х1, у1), (х2,у2)

Console.WriteLine("Введите координату х1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату у1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату у2");
int y2 = Convert.ToInt32(Console.ReadLine());

double z = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
Console.WriteLine($"Расстояние между двумя точками: {z}");
