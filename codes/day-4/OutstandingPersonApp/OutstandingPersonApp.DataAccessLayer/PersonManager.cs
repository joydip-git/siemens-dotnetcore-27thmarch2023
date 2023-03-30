using OutstandingPersonApp.Entities;
using OutstandingPersonApp.Repository;

namespace OutstandingPersonApp.DataAccessLayer
{
    public class PersonManager
    {
        public bool AddPerson(Person person)
        {
            bool status = false;
            Person[] all = PersonRepository.People;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] == null)
                {
                    all[i] = person;
                    status = true;
                    break;
                }
            }
            return status;
        }
        public Person[] GetPeople()
        {
            return PersonRepository.People;
        }
        public Person GetPersonById(int id)
        {
            Person[] all = PersonRepository.People;
            Person found = null;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] != null)
                {
                    if (all[i].Id == id)
                    {
                        found = all[i];
                        break;
                    }
                }
            }
            return found;
        }
        public bool DeletePerson(int id)
        {
            bool status = false;
            Person[] all = PersonRepository.People;
            int index = -1;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] != null)
                {
                    if (all[i].Id == id)
                    {
                        index = i;
                        break;
                    }
                }
            }
            if(index != -1)
            {
                all[index] = null;
                status = true;
            }
            return status;
        }
        public bool UpdatePerson(Person person)
        {
            bool status = false;
            Person[] all = PersonRepository.People;
            int index = -1;
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] != null)
                {
                    if (all[i].Id == person.Id)
                    {
                        index = i;
                        break;
                    }
                }
            }
            if (index != -1)
            {
                all[index] = person;
                status = true;
            }
            return status;
        }
    }
}
