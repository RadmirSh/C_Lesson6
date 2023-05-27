// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Please write number of array elements: ");

int elementsArray = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elementsArray];

void mass(int elementsArray)
{
    for (int i = 0; i < elementsArray; i++)
    {
        Console.WriteLine($"Please wtite {i+1} element of array ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int sumElements(int[] Array)
{
int i=0;
int sum = 0;
    while (i < Array.Length)
    {
        if(Array[i]>0)
        sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

mass(elementsArray);
Console.Write($"\n Numbers greater than zero: {sumElements(myArray)}");

Console.WriteLine("\n");