// Напишите программу, которая задает массив из 8 элементов (с консоли) и выводит их на экран.
//1,2,5,7,19 -> [1,2,5,7,19]
//6,1,33,->[6,1,33]


 //Console.Write("Enter number of elemens of massiv:\t");
 //int elementCount = int.Parse(Console.ReadLine());

//int [] array = new int [elementCount];
int [] array = new int [8];


//Console.WriteLine("Massiv");
for(int i = 0; i< array.Length; i++)
{
    Console.Write(" Enter the element of massiv ");
    //array [i] = int.Parse(Console.ReadLine());
    array [i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", array)}]");
