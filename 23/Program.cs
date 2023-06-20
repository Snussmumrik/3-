Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine ());
int b = 0;

Console.WriteLine($" {a} ---> "); 

while (b != a - 1)
{
     b ++;
     Console.WriteLine($" {b * b * b},  ");   
}
b ++;
Console.WriteLine($" {b * b * b}.");   