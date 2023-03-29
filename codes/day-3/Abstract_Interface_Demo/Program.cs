using System;

namespace Abstract_Interface_Demo
{
    abstract class Reader
    {
        string data;

        public string Data { get => data; protected set => data = value; }

        public abstract void GetData();         
    }
    class FileReader : Reader
    {
        public override void GetData()
        {
            //base.GetData();
            Data = "data from file";
        }
    }
    class DbReader : Reader
    {
        public override void GetData()
        {
            Data = "data from db";
        }
    }
    internal class Program
    {
        static void Main()
        {
            int choice = 1;//2
            Reader reader = null;
            switch (choice)
            {
                case 1:
                    reader = new FileReader();
                    break;

                case 2:
                    reader = new DbReader();
                    break;

                default:
                    break;
            }
            
            reader.GetData();
        }
    }
}
