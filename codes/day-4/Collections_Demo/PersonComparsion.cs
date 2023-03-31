using System.Collections.Generic;

namespace Collections_Demo
{
    internal class PersonComparsion : IComparer<Person>
    {
        private int _sortChoice;

        public PersonComparsion(int sortChoice)
        {
            _sortChoice = sortChoice;
        }

        public int Compare(Person x, Person y)
        {
            int sortResult = 0;
            switch (_sortChoice)
            {
                case 1:
                    sortResult = x.Id.CompareTo(y.Id);
                    break;

                case 2:
                    sortResult = x.Name.CompareTo(y.Name);
                    break;

                default:
                    sortResult = x.Id.CompareTo(y.Id);
                    break;
            }
            return sortResult;
        }
    }
}
