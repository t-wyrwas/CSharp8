#pragma warning disable CS0219
#pragma warning disable CS0168
using System;

namespace NullableReferences
{
    class Worker {
        public int DoSth()
        {
            return 5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // string name = null;
            string? surname = null;

            //Console.WriteLine(surname.HasValue ? surname.Value ? "dupa");

            string dave = "dave";
            string? john = null;
            Worker? worker = null;
            // Console.WriteLine($"John: {worker.DoSth()}");
            // Console.WriteLine($"John: {worker!.DoSth()}");
            john = dave;

            // if(john != null)
            // {
            //     dave = john;
            // }

            int i = 5;
            // int j = null;

            int? k = null;
            Nullable<int> l = null;
        }
    }
}
