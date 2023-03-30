namespace InterfaceDemo.Entities
{
    public class Creator
    {
        static IWriter xmlWriter;
        static IWriter textWriter;

        public static IWriter Create(WriterOptions option)
        {
            if (option == WriterOptions.Xml)
            {
                if (xmlWriter == null)
                {
                    xmlWriter = new XmlWriter();
                }
                return xmlWriter;
            }
            if (option == WriterOptions.Text)
            {
                if (textWriter == null)
                {
                    textWriter = new TextWriter();
                }
                return textWriter;
            }
            return null;
        }
    }
}
