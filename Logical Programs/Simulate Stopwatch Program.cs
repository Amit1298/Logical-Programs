using System;
using System.Linq;
using System.Diagnostics;
public class Demo
{
    public static void Main()
    {
        var sw = Stopwatch.StartNew();
        long ticks = sw.ElapsedTicks;
        Console.WriteLine(ticks);
    }
}