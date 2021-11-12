using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WebAddressBookTests
{
    [TestClass]
    public class ContactData
    {
        private string contactFirstName;
        private string contactLastName;

        public string ContactFirstName
        {
            get
            {
                return contactFirstName;
            }
            set
            {
                contactFirstName = value;
            }
        }

        public string ContactLastName
        {
            get
            {
                return contactLastName;
            }
            set
            {
                contactLastName = value;
            }
        }

        public ContactData(string contactFirstName, string contactLastName)
        {
            this.contactFirstName = contactFirstName;
            this.contactLastName = contactLastName;
        }
    }
}
