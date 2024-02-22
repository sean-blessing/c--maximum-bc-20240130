// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int counter = 0;
Console.WriteLine(counter);
//counter++;
counter = counter + 1;

Console.WriteLine(counter++);
Console.WriteLine(counter);

string name1;
name1 = "George";
string name2;

Console.WriteLine(name1);

DateTime when = DateTime.Now;
Console.WriteLine(when);

decimal price = 10.25m;
Console.WriteLine(price);
double distance = 5.33333;
distance = 1f / 3f;
Console.WriteLine("distance as double: "+distance);
decimal distance2 = 1m / 3m;
Console.WriteLine("distance as decimal: "+distance2);
