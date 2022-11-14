// Напишите программу, которая принимает на вход число N  и выдает произведение
// чисел от 1 до N
// 4->24
// 5->120

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result =1;
if(number < 1)
{
    Console.WriteLine("Imposible processing this number");
}
else
{


for(i =1; i <= number; i++)
{
    result = result*i;
}
Console.WriteLine(result);
}