Console.Clear();

Console.WriteLine("Введите x1: ");
int numX1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите у1: ");
int numY1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z1: ");
int numZ1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int numX2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите у2: ");
int numY2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z2: ");
int numZ2 = int.Parse(Console.ReadLine());

int distance = (numX1 - numX2)*(numX1 - numX2) + (numY1 - numY2)*(numY1 - numY2) + (numZ1 - numZ2)*(numZ1 - numZ2);

Console.WriteLine($" расстояние между двумя точками --> {distance} ");