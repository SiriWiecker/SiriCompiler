using SiriCompiler.Builder;
using System.IO;
using System;
using System.Linq;

namespace SiriCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcePath = @"C:\Users\Admin\source\repos\SiriCompiler";
            var filePath = Path.Combine(sourcePath, "DynamicProgram.cs");

            Console.WriteLine($"Kører fra: {sourcePath}");

            var compiler = new Compiler();
            var runner = new Runner();

            runner.Execute(compiler.Compile(filePath), new[] { "Denmark" });

            int[] a = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine();
            Console.WriteLine(a.Count());

            var filePath2 = Path.Combine(sourcePath, "TestArrayCount.cs");
            runner.Execute(compiler.Compile(filePath2), new[] { "a.Count();" });

        }
    }
}
