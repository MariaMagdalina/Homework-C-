// данная программа принимает на вход число n и показывает все четные числа от 1 до n
Console.Write("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
if(n > 1)
{
   while(count <= n)
   { Console.WriteLine(count); count +=2;}
}
else Console.WriteLine("В данном интервале четных чисел нет");

