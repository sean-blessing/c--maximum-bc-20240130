// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Collections!");

int[] values = { 2, 4, 8, 16, 32, 64};

string[] directions = { "North", "South", "East", "West"};

for (int i = 0; i < values.Length; i++) {
    Console.WriteLine(values[i]);
}
foreach (string direction in directions) {
    Console.WriteLine(direction);
}
