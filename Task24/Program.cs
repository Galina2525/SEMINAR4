// Напишите программу, которая принимает на вход число(A) и выдает сумму чисел от 1 до A
// 7 ->28
//4->10
//8->36
Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum = 0;
while(i <= number)
{
    sum = sum + i;
    i++;
    
    
}
 Console.WriteLine(sum);
