namespace onion_architeture.Models
{
    public class MemoryContactServices : IContactService
    {
        private readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
            {1,new Contact() {Id=1,Name="Ewa",Email="ewa@kropka.pl",Phone="123456789" } },
            {2,new Contact() {Id=2,Name="Iza",Email="iza@kropka.pl",Phone="987654321" } },
        };
        private int _id = 3;
        public void Add(Contact contact)
        {
            contact.Id = _id++;
            _contacts[contact.Id] = contact;
        }

        public void DeleteById(Contact contact)
        {
            _contacts.Remove(contact.Id);
        }

        public List<Contact> FindAll()
        {
            return _contacts.Values.ToList();
        }

        public Contact? FindById(int id)
        {
            return _contacts[id];
        }

        public void Update(Contact contact)
        {
            _contacts[contact.Id] = contact;
        }
    }
}
