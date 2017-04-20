using System;

namespace _12.PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            var fillPipe1 = pipe1 * time;
            var fillPipe2 = pipe2 * time;
            var totalFill = fillPipe1 + fillPipe2;

            var percentageFull = Math.Truncate((totalFill / volume) * 100);
            var percentagePipe1 = Math.Truncate((fillPipe1 / totalFill) * 100);
            var percentagePipe2 = Math.Truncate((fillPipe2 / totalFill) * 100);

            var overflow = totalFill - volume;

            if (totalFill <= volume)
                Console.WriteLine($"The pool is {percentageFull}% full. Pipe 1: {percentagePipe1}%. Pipe 2: {percentagePipe2}%.");
            else
                Console.WriteLine($"For {time} hours the pool overflows with {overflow} liters.");
        }
    }
}
