namespace InterfaceDemo.Entities
{
    internal class TextWriter : IWriter
    {
        public string WriteData(string data)
        {
            return $"{data} written in text file";
        }
    }
}
