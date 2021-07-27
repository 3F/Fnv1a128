using BenchmarkDotNet.Running;

namespace net.r_eg.algorithms.Tests
{
    class Program
    {
        static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
    }
}
