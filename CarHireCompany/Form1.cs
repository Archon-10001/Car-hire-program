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
        }

        public void UpdateVehicleLstBox()
        {
            vehicleLstBox.Items.Clear();
            foreach (var item in vehicleList)
            {
                vehicleLstBox.Items.Add(item.Make);
            }
        }
        public void UpdateCustomerLstBox()
        {
            customerLstBox.Items.Clear();
            foreach (var item in customerList)
            {
                customerLstBox.Items.Add(item.FirstName + " " + item.Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer
            {
                FirstName = Firstnametxt.Text,
                Surname = SecondNametxt.Text
            };
            customerList.Add(c);
            UpdateCustomerLstBox();
        }

        private void Createvehiclebtn_Click(object sender, EventArgs e)
        {
            Vehicle v = new Vehicle
            {
                Make = Vehicletxt.Text
            };
            vehicleList.Add(v);
            UpdateVehicleLstBox();
        }
    }
}
