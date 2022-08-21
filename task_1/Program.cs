//Данная программа сравнивает два числа и находит среди них максимальное и минимальное. В случае если числа равны выводит соответствующее сообщение.
Console.WriteLine("Введите первое число ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double n2 = Convert.ToDouble(Console.ReadLine());
if(n1 > n2) { Console.WriteLine("максимальное число - " + n1); Console.WriteLine("минимальное число - " + n2); }
else if (n2 > n1) { Console.WriteLine("максимальное число - " + n2); Console.WriteLine("минимальное число - " + n1);}
else Console.Write("Данные числа равны");
