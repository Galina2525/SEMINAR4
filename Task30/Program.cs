// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами
//в случайном порядке
//[1,0,1,1,0,1,0,1]

int [] array = new int[8];
Random rand = new Random();

for(int i = 0; i< array.Length; i++)
{
    array[i] = rand.Next(0,2);
    //Console.Write(array[i]+ " ");
}
Console.WriteLine($"[{string.Join(", ", array)}]");
// или просто Console.WriteLine(string.Join(", ",array)) тогда будет без квадратных скобок

