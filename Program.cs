using System;
using System.Threading; 
class Program
{
    static void Wait()
    {
        CountToThree();
        Console.WriteLine("Waiting..");
        Thread.Sleep(3000);
        Console.WriteLine("done sleeping");
    }
    
    static void CountToThree() 
    {
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
    }
    static void Main(string[] args)
    {
        Wait();
        CountToThree();
    }
}
