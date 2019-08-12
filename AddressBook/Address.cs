using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Address
    {
        private const string TEXT_FILE_NAME = "Address.txt"; 
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public static void writeAddress(Address address)
        {
            var addressData = $"{address.Name}, {address.EmailAddress}, {address.PhoneNumber}";
            FileHelper.WriteTextFile(TEXT_FILE_NAME, addressData);

        }
    }
}
