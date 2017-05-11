using System;
using System.Reflection;
using NUnit.Common;
using NUnitLite;

namespace coding_challenges_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            new AutoRun(typeof(Program).GetTypeInfo().Assembly)
                .Execute(args, new ExtendedTextWrapper(Console.Out), Console.In);
        }
    }
}
