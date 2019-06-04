#pragma warning disable CS0219
#pragma warning disable CS0168
using System;

namespace NullableReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            // string? surname;

            int i = 5;
            // int j = null;

            int? k = null;
            Nullable<int> l = null;
        }
    }
}
