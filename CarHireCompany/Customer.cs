using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHireCompany
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string HouseNum { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public DateTime DOB { get; set; }
        public Vehicle HiredVehicle { get; set; }
    }
}
