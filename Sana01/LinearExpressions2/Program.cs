// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a:");
if (double.TryParse(Console.ReadLine(), out double a)) ;
Console.WriteLine("Enter b:");
if (double.TryParse(Console.ReadLine(), out double b)) ;
Console.WriteLine("Enter m:");
if (double.TryParse(Console.ReadLine(), out double m)) ;
Console.WriteLine("Enter n:");
if (double.TryParse(Console.ReadLine(), out double n)) ;
Console.WriteLine("Enter x:");
if (double.TryParse(Console.ReadLine(), out double x)) ;

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n*m + Math.Pow(m, 2) - m);

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

double y = 2.4 * Math.Abs((x*x + b) / a) + (a-b) * Math.Pow(Math.Sin(a-b), 2) + Math.Pow(10, -2) * (x-b);

Console.WriteLine($"z1: {z1}, z2: {z2}, y: {y}");