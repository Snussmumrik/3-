Console.Clear();

Console.WriteLine("Ввведите пятизначное число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);

int a = num / 10000;
int b = num % 10;

Console.WriteLine ($" первая цифра --> {a}, последняя цифра --> {b} ");

int c = (num % 10000) / 1000;
int d = (num % 100) /10;

Console.WriteLine ($" вторая цифра --> {c}, четвертая цифра --> {d} ");

if ( a==b && c==d )
{
     Console.WriteLine($" {num} --> палиндром ");
}
else
{
     Console.WriteLine($" {num} --> не палиндром ");
}