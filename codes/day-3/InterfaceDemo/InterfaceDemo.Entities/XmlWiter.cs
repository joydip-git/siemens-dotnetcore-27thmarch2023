namespace InterfaceDemo.Entities
{
    internal class XmlWriter : IWriter
    {
        public string WriteData(string data)
        {
            return $"{data} written in XML file";
        }
    }
}
