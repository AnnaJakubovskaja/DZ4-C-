// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Без использования функции Math.Pow.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

 Console.WriteLine("Введите число, возводимое в степень: ");
int num =Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите число, обозначающее степень: ");
int n =Convert.ToInt32(Console.ReadLine());

int num_n=1;
for (int i=0; i<n; i++)
{
   num_n*=num;
}
Console.WriteLine("Ответ: " + (num_n));
