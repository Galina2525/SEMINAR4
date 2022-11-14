// Напишите программу, которая принимает на вход число(A) и выдает сумму чисел от 1 до A
// 7 ->28
//4->10
//8->36
Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
// int i =1;
// while(i <= number)
// {
//     sum = sum + i;
//     i++;
    
    
// }
//  Console.WriteLine(sum);
for(int i = 1; i <= number; i++ )
{
    sum = sum +i;
}
Console.WriteLine($"Sum of digits from 1 to {number} = {sum}");

