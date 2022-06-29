#pragma warning disable
void stuff()
{
    // random utilization
    Random dice = new Random();
    int roll = dice.Next();

    // max value
    int firstValue = 500;
    int secondValue = 600;
    int largerValue = Math.Max(firstValue, secondValue);

    Console.WriteLine(largerValue);
}

#pragma warning disable
void arrays()
{
    int[] myArray = { 1, 5, 6, 'C', (int)0.5 };
    Console.WriteLine(myArray[1]); // 5
}

#pragma warning disable
void branchesAndLoops()
{
    const int a = 10;
    const int value = 6;
    int i = 0;

    if (a > value)
    {
        Console.WriteLine($"{a} is superior to {6}.\n");
    }

    while (i < 5)
    {
        string printSpace = i == 4 ? "\n" : "";
        Console.WriteLine($"while loop i: {i} {printSpace}");
        i++;
    }


    for (i = 0; i < 5; i++)
    {
        string printSpace = i == 4 ? "\n" : "";
        Console.WriteLine($"for loop i: {i} {printSpace}");
    }
}

void thread1()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Thread1: {i}");
        Thread.Sleep(1000);
    }
}

void thread2()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Thread2: {i}");
        Thread.Sleep(1000);
    }
}

// arrays();
// branchesAndLoops();

Thread t1 = new Thread(new ThreadStart(thread1));
Thread t2 = new Thread(new ThreadStart(thread2));

t1.Start();
t2.Start();

// for processing, maybe spawn multiple terminals ?
// see https://docs.microsoft.com/fr-fr/dotnet/api/system.diagnostics.process.start?view=net-6.0