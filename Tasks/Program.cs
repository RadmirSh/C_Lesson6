Console.WriteLine("Please write the number of task");

int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        task1();
        break;

    case 2:
        task2();
        break;

    default:
        break;
}

void task1()
{
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
}

void task2()
{
Console.WriteLine("Please write the variable b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please write the variable k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please write the variable b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please write the variable k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"\n Point of intersection of two lines: [{x};{y}]");

Console.WriteLine("\n");
}