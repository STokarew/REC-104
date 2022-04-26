using System;

namespace REC_104
{
    public class Entity<T>
    {
        public T Data { get; }
        public Entity(T data)
        {
            Data = data;
        }
    }

    public class Entity2<T2>
    {
        public T2 Data2 { get; }
        public Entity2(T2 Data2)
        {
            this.Data2 = Data2;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
