// Напишите цикл, который принимает на вход два числа(А и В) и возводит число А в
// натуральную степень В. Не использовать Math.pow !
//3, 5 ->243 (3 в пятой степени)
//2, 4 ->16 (2 в четвертой степени)
Console.WriteLine("Enter number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number A");
int B = Convert.ToInt32(Console.ReadLine());

//int i = 1;
int result = 1;
for(int i=1; i<=B; i++)
{
    
    result*=A;  //result = result*A;
}
Console.WriteLine(result);