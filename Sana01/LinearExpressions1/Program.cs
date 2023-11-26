// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a:");
if (double.TryParse(Console.ReadLine(), out double a)) ;
Console.WriteLine("Enter b:");
if (double.TryParse(Console.ReadLine(), out double b)) ;
Console.WriteLine("Enter c:");
if (double.TryParse(Console.ReadLine(), out double c)) ;
Console.WriteLine("Enter d:");
if (double.TryParse(Console.ReadLine(), out double d)) ;

Console.WriteLine($"{a}, {b}, {c}, {d}");

double x = (a + 2*b - c + d) / (c*d) + (a + b) / (c - d) - (Math.Pow(a, 2) / Math.Pow(b, 2));

double y = (5 * (a + b)*(c - d)) / (0.5 * c) + Math.Pow(d, 2) * (a*a - b*b) / (b - a);

double z = ( Math.Pow(x * x - 2 * x, 3) - 4*( Math.Pow(x, 4) + 1) * (1 - b) ) / 5*a + 3*b;

double r = (0.5*a + 3.0/4*b - 7.0/5) / (3*c + 1) + 1 / (a - c);

Console.WriteLine($"x: {x}, y: {y}, z: {z}, r: {r}");

