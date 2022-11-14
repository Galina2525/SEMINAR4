// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 -> 11
//82->10
//9012 ->12
Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;


for(i = 0; i <= number; i++)
{
   sum += number % 10;
   number /= 10;
}

// while(i<=number)
// {
//     sum += number % 10;

//      number /= 10;
     
//     i++;
// }

Console.WriteLine(sum);