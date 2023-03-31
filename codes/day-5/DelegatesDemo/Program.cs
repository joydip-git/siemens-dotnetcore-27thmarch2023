using System;

namespace DelegatesDemo
{
    delegate string UtilityDel(int count);

    internal class Utilities
    {
        public string GetMarkers(int count)
        {
            return $"Here is {count} markers that you asked for";
        }
        public string GetAttendanceSheet(int count)
        {
            return $"Here is {count} maattendance sheet(s)  that you asked for";
        }
    }
    internal class Trainer
    {
        public string Name { get; set; }
        public Assistant Assistant { get; set; }
        public void AskForHelp()
        {
            if (Assistant != null)
            {
                Utilities utilities = new Utilities();
                UtilityDel markerDel = new UtilityDel(utilities.GetMarkers);
                //utilities.GetMarkers;
                string help = Assistant.HelpTrainer(markerDel, 2);
                Console.WriteLine(help);
            }
        }
    }
    internal class Assistant
    {
        public string Name { get; set; }
        //do not pass complete object containing methods to choose from
        //rather pass a method as an argument to this method through a delegate
        //public string HelpTrainer(Utilities utilities)
        public string HelpTrainer(UtilityDel utilityDel, int count)
        {
            return utilityDel(count);
        }
    }
    internal class Program
    {
        static void Main()
        {

            Assistant assistant = new Assistant { Name = "Anil" };
            Trainer trainer = new Trainer { Name = "Joydip", Assistant = assistant };
            trainer.AskForHelp();

            //how to pass a function as an argument to another function and invoke the passed function            
        }
    }
}
