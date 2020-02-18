using NUnit.Framework;
using Evolent.Services;
using Evolent.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{

    public class ContactControllerTest
    {

        
        private IContactService _contactService;
        [SetUp]
        public void ContactControllerTestSet(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Test]
        public async void AddContact()
        {
            Contact contact = new Contact() { FirstName = "AKT", LastName = "Khalid", EMail = "Khalid@gmail.com", PhoneNumber = "945015748", Status = true };

            int result = await _contactService.AddContact(contact);
            Assert.AreEqual(1, result);
        }



        [Test]
        public async void EditContact()
        {
            Contact contact = new Contact() { ContactID = 2, FirstName = "AKT", LastName = "Khalid", EMail = "Khalid@gmail.com", PhoneNumber = "945015748", Status = true };

            int  result = await _contactService.UpdateContact(contact);
            Assert.AreEqual(1, result);
        }

        [Test]
        public async void DeleteContact()
        {

            int result = await _contactService.DeleteContact(1);
            Assert.AreEqual(1, result);
        }
    }
}