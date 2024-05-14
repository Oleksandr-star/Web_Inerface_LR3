class Program
{
    static void Main()
    {
        // Пункт 1: Робота із класом Thread
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Робота із класом Thread ===");

        Thread thread1 = new Thread(ThreadMethod1);
        Thread thread2 = new Thread(ThreadMethod2);
        Thread thread3 = new Thread(ThreadMethod3);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine();

        // Пункт 2: Робота з Async-Await
        Console.WriteLine("=== Робота з Async-Await ===");

        ExecuteAsyncMethod1().Wait();
        ExecuteAsyncMethod2().Wait();
        ExecuteAsyncMethod3().Wait();

        Console.WriteLine("=== Завершено ===");
    }

    // Пункт 3: Методи для роботи із класом Thread
    static void ThreadMethod1()
    {
        Console.WriteLine($"Початок роботи ThreadMethod1 в потоці {Thread.CurrentThread.ManagedThreadId}.");
        Thread.Sleep(3000);
        Console.WriteLine($"Кінець роботи ThreadMethod1.");
    }

    static void ThreadMethod2()
    {
        Console.WriteLine($"Початок роботи ThreadMethod2 в потоці {Thread.CurrentThread.ManagedThreadId}.");
        Thread.Sleep(2000);
        Console.WriteLine($"Кінець роботи ThreadMethod2.");
    }

    static void ThreadMethod3()
    {
        Console.WriteLine($"Початок роботи ThreadMethod3 в потоці {Thread.CurrentThread.ManagedThreadId}.");
        Thread.Sleep(1000);
        Console.WriteLine($"Кінець роботи ThreadMethod3.");
    }

    // Пункт 4: Методи для роботи з Async-Await
    static async Task ExecuteAsyncMethod1()
    {
        Console.WriteLine($"Початок роботи AsyncMethod1 в потоці {Thread.CurrentThread.ManagedThreadId}.");
        await Task.Delay(3000);
        Console.WriteLine($"Кінець роботи AsyncMethod1.");
    }

    static async Task ExecuteAsyncMethod2()
    {
        Console.WriteLine($"Початок роботи AsyncMethod2 в потоці {Thread.CurrentThread.ManagedThreadId}.");
        await Task.Delay(2000);
        Console.WriteLine($"Кінець роботи AsyncMethod2.");
    }

    static async Task ExecuteAsyncMethod3()
    {
        Console.WriteLine($"Початок роботи AsyncMethod3 в потоці {Thread.CurrentThread.ManagedThreadId}.");
        await Task.Delay(1000);
        Console.WriteLine($"Кінець роботи AsyncMethod3.");
    }
}
