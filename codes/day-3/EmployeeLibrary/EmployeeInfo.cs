namespace EmployeeLibrary
{
    public class EmployeeInfo
    {
        private readonly int _id;
        public EmployeeInfo(int id, string name, string projectName = null)
        {
            this._id = id;
            this.Name = name;
            this.ProjectName = projectName;
        }

        public int Id => this._id; 

        //Automatic Property [C# 3.0 (2007)]
        public string Name { get; set; }
        public string ProjectName { get; set; }

        //private static decimal _joiningBonus;
        //init-only read-only property
        public static decimal Joiningbonus { get; } = 1000;

        //private readonly int _someMember;
        public int SomeMember { get; } = 2000;
    }
}
