using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarHireCompany
{
    public partial class Form1 : Form
    {
        List<Customer> customerList = new List<Customer>();
        List<Vehicle> vehicleList = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();

            Customer dan = new Customer()
            {
                FirstName = "Dan",
                Surname = "French",
                HouseNum = "16",
                Street = "no place",
                DOB = new DateTime(1985, 04, 07)
            };

            customerList.Add(dan);

            Customer dan2 = new Customer()
            {
                FirstName = "Dan2",
                Surname = "French2",
                HouseNum = "162",
                Street = "no place2",
                DOB = new DateTime(1982, 04, 07)
            };

            customerList.Add(dan2);

            Vehicle fiatPanda = new Vehicle()
            {
                Make = "ford",
                Model = "Veyron",
                FuelType = "the souls of dead ants",
                Seats = 5
            };

            vehicleList.Add(fiatPanda);

            dan.HiredVehicle = fiatPanda;

            Console.WriteLine(dan.HiredVehicle.Model);

            UpdateCustomerLstBox(customerList, customerLstBox);
        }

        public void UpdateCustomerLstBox(List<Customer> cList, ListBox listBox)
        {
            foreach (var item in cList)
            {
                listBox.Items.Add(item.FirstName + " " + item.Surname);
            }
        }
    }
}
