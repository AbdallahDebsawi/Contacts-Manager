namespace Contacts_Manager
{
    public class Program
    {
       public static List<string> contacts = new List<string>();

        static void Main(string[] args)
        {
            ContactsManager();
        }
        public static void ContactsManager()
        {
            AddContact("Abdallah Debsawi");
            AddContact("soso");
            AddContact("roro");
            AddContact("nono");
            AddContact("Ahmad Mohsen");
            Console.WriteLine("the content list after adding new content");

            Console.WriteLine(string.Join(", ", ViewAllContacts()));
            RemoveContact("Ahmad Mohsen");
            Console.WriteLine("the content list after removing the content");

            Console.WriteLine(string.Join(", ", ViewAllContacts()));
        }

        public static List<string> AddContact(string contact)
        {
            if (!string.IsNullOrWhiteSpace(contact) && !contacts.Contains(contact))
            {
                contacts.Add(contact);
            }
            return new List<string>(contacts);
        }

        public static List<string> RemoveContact(string contact)
        {
            if (contacts.Contains(contact))
            {
                contacts.Remove(contact);
            }
            return new List<string>(contacts);
        }

        public static List<string> ViewAllContacts()
        {
            return new List<string>(contacts);
        }
    }
}