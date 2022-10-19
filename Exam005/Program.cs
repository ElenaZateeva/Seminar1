int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.Write("Последовательность четных чисел от 1 до ");
Console.WriteLine(number);

while (count < number)
{
    if (count % 2 == 0) 
        Console.WriteLine(count);
    count ++;
}  
