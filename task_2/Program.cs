//Данная программа сравнивает три числа и находит среди них максимальное.
Console.WriteLine("Введите первое число ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число ");
double n3 = Convert.ToDouble(Console.ReadLine());
double max = n1;
if(n2 > max) { max = n2; }
if(n3 > max) { max = n3; }
Console.WriteLine("максимальное число: " + max);
