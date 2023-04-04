using System;
using System.Collections;
using System.Collections.Generic;

namespace Section_9
{
    internal class Contact
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

    internal class PhoneBook : IEnumerable<Contact>
    {

        private List<Contact> contacts;

        public PhoneBook()
        {
            contacts = new List<Contact>{
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
        }

        IEnumerator<Contact> IEnumerable<Contact>.GetEnumerator()
        {
            return contacts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook)
            {
                contact.Call();
            }
        }
    }
}
