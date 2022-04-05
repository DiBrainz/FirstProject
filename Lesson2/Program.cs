
Console.Write($"Введите минимальную температуру за сутки>");

string min = Console.ReadLine();
int minO = Convert.ToInt32(min);

Console.Write($"Введите максимальную температуру за сутки>");

string max = Console.ReadLine();
int maxO = Convert.ToInt32(max);
//gthdsq
double middle = (double)(minO + maxO)/2;
Console.WriteLine($"Средняя суточная темература составляет {middle}°");