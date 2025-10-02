using System;
using System.Threading;

class Fruits
{
    static int SleepTime = 1;

    static void Apple()
    {
        for (int i = 0; i <= 3; i++)
        {
            Thread.Sleep(SleepTime * 1000);
            Console.WriteLine("Apple " + i);
        }
    }

    static void Banana()
    {
        for (int i = 0; i <= 3; i++)
        {
            Thread.Sleep(SleepTime * 1000);
            Console.WriteLine("Banana " + i);
        }
    }

    static void Cherry()
    {
        for (int i = 0; i <= 3; i++)
        {
            Thread.Sleep(SleepTime * 1000);
            Console.WriteLine("Cherry " + i);
        }
    }

    public void Run()
    {
        Thread t1 = new Thread(Apple);
        Thread t2 = new Thread(Banana);
        Thread t3 = new Thread(Cherry);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Task finish");
    }

    // Entry point
    static void Main()
    {
        Fruits fruits = new Fruits();
        fruits.Run();
    }
}
