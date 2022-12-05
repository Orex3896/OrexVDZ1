/*
Console.Write("Введите число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int max = A;

if (A>max) max = A;
if (B>max) max = B;

Console.WriteLine("Максимальное число = " + max); 
*/

/*
Console.Write("Введите число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C ");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;

if (A>max) max = A;
if (B>max) max = B;
if (C>max) max = C;

Console.WriteLine("Максимальное число = " + max);

*/
/*
Console.Write("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
if (A % 2 == 0) Console.WriteLine("четное число");
else Console.WriteLine("нечетное");
*/

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= n)
   
    {   
        if (current %2 == 0)
        {
        Console.Write(current + " ");   
        }
        current++;
    }