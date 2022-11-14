// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
Console.WriteLine("Enter number");

// string number = Console.ReadLine();
// Console.WriteLine($"Quantity of digits = {number.Length}");


// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;  //
// while (number >0)
// {
//     number = number/10;
//     count++;

// } 
// Console.WriteLine($"Quantity of digits = {count}");

int A = Convert.ToInt32(Console.ReadLine());
int i = 0;
for(i = 0; A > 0; i++)
{
    A/=10;
}
Console.WriteLine($"Quantity of digits = {i}");