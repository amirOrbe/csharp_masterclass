using System;
using System.Collections.Generic;
using System.Collections;

namespace Section_9
{
    // TODO

    class Contact
    {

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void Call()
        {
            System.Console.WriteLine($"Calling to {Name}. Phone number is {PhoneNumber}");
        }

        public Contact(string name, string phone)
        {
            Name = name;
            PhoneNumber = phone;
        }
    }

    class PhoneBook : IEnumerable<Contact>
    {

        public List<Contact> Contacts;

        public PhoneBook()
        {
            Contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }

        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
        {
            return Contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public static class Program
    {
        static public void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
    }
}
