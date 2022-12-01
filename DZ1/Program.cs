Console.Write("Введите число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int max = A;

if (A>max) max = A;
if (B>max) max = B;

Console.WriteLine(max); 