using System;
using InterfaceDemo.Entities;

namespace InerfaceDemo.UserInterface
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("1. write in XML file\n2. Write in Tex file");
            int choice = int.Parse(Console.ReadLine());

            IWriter writerObjectReference = null;
            switch (choice)
            {
                case 1:
                    //writerObjectReference = new XmlWriter();
                    writerObjectReference = Creator.Create(WriterOptions.Xml);
                    break;

                case 2:
                    //writerObjectReference = new TextWriter();
                    writerObjectReference = Creator.Create(WriterOptions.Text);
                    break;

                default:
                    writerObjectReference = Creator.Create(WriterOptions.Text);
                    break;
            }

            if (writerObjectReference != null)
                Console.WriteLine(writerObjectReference.WriteData("my name is joydip"));
        }
    }
}
