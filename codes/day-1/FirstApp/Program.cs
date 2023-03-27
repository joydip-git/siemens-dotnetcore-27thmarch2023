using System;//System.Console.dll
using Common; //FirstLibrary.dll
//using Common.Data; //FirstLibrary.dll
using Common.Drawing;
using SecondLibrary;//SecondLibrary.dll

namespace FirstApp
{
    class Program
    {
        static void Main()
        {
            Messenger messenger = new Messenger();
            string message = messenger.GetMessage("joydip");
            Console.WriteLine(message);

            //SqlDataAccess sqlDataAccess = new SqlDataAccess();
            //Console.WriteLine(sqlDataAccess.GetData());

            Rectangle r = new Rectangle();
            r.DrwRectangle();

            Class1 cls = new Class1();
            Console.WriteLine(cls.SayHello());
        }
    }
}
