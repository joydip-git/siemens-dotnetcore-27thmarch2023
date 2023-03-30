using System;

namespace GenericsDemo
{
    //TData=> Type Parameter
    //where TData : class => constraint
    interface IWriter<TData> where TData : class
    {
        bool WriteData(TData data);
    }
    interface IReader<TData>
    {
        TData ReadData();
    }
    class StringWriter : IWriter<string>
    {
        public bool WriteData(string data)
        {
            throw new NotImplementedException();
        }
    }
    class StringReader : IReader<string>
    {
        public string ReadData()
        {
            throw new NotImplementedException();
        }
    }
    class Calculation<TResult> where TResult : struct
    {
        public TResult Add<TInput>(TInput first, TInput second) where TInput : struct
        {
            return default(TResult);
        }
        public TResult Add<T1, T2>(T1 first, T2 second) where T1 : struct where T2 : struct
        {
            return default(TResult);
        }
    }
    class Program
    {
        static void Main()
        {
            Calculation<long> calc = new Calculation<long>();
            calc.Add<int>(12, 13);
            //calc.Add<string>("siemens", "healthineers");
            calc.Add<int, long>(12, 1000000000);
        }
    }
}
