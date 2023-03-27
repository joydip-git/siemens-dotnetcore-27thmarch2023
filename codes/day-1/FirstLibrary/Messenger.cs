namespace Common
{
    namespace Data
    {
        public class SqlDataAccess
        {
            public string GetData()
            {
                return "data";
            }            
        }
        public class OracleDataAccess
        {
            public string GetData()
            {
                return "data";
            }
        }
    }

    namespace Drawing
    {
        public class Rectangle
        {
            public void DrwRectangle()
            {

            }
        }
    }

    public class Messenger
    {
        public string GetMessage(string name)
        {
            return "Hello...." + name;
        }
    }
}
