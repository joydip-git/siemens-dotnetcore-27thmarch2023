using System;//System.Console.dll
using Common; //FirstLibrary.dll
//using Common.Data; //FirstLibrary.dll
using Common.Drawing;
using SecondLibrary;//SecondLibrary.dll

namespace FirstApp
{
    class Program
    {
        //unsafe static void UsePointer()
        //{
        //    int* p = (int*)20;
        //    Console.WriteLine();
        //}
        static void Main()
        {
            //x => value type variable
            //int => value type
            int x = 10;
            Console.WriteLine(x);

            //messenger => refernce type variable
            //Messenger => reference type (user-defined type)
            Messenger messenger = new Messenger(1);
            string message = messenger.GetMessage("joydip");
            Console.WriteLine(message);

            //SqlDataAccess sqlDataAccess = new SqlDataAccess();
            //Console.WriteLine(sqlDataAccess.GetData());

            Rectangle r = new Rectangle();
            r.DrwRectangle();

            Class1 cls = new Class1();
            Console.WriteLine(cls.SayHello());

            Console.WriteLine("oress any ket to close the application.");
            Console.ReadLine();
        }
    }
}
