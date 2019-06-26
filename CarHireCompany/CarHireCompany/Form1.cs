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
                customerLstBox.Items.Add(item.FirstName + " " + item.Surname + " " + item.HouseNum + " " + item.Street + " " + item.City);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer
            {
                FirstName = Firstnametxt.Text,
                Surname = SecondNametxt.Text,
                HouseNum = housenumtxt.Text,
                Street = street_txt.Text,
                City = city_txt.Text,
            };
            customerList.Add(c);
            UpdateCustomerLstBox();
            customerLstBox.Enabled = false;
            button1.Enabled = false;
            Firstnametxt.Enabled = false;
            SecondNametxt.Enabled = false;
            btn_reset.Visible = true;
            }

        private void Createvehiclebtn_Click(object sender, EventArgs e)
        {
            Vehicle v = new Vehicle
            {
                Make = Vehicletxt.Text
            };
            vehicleList.Add(v);
            UpdateVehicleLstBox();
            Createvehiclebtn.Enabled = false;
            Vehicletxt.Enabled = false;
            btn_resetvehicle.Visible = true;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            customerLstBox.Items.Clear();
            customerLstBox.Enabled = true;
            button1.Enabled = true;
            Firstnametxt.Enabled = true;
            SecondNametxt.Enabled = true;
            btn_reset.Visible = false;
            Firstnametxt.Text = string.Empty;
            SecondNametxt.Text = string.Empty;
        }

        private void btn_resetvehicle_Click(object sender, EventArgs e)
        {
            vehicleLstBox.Items.Clear();
            vehicleLstBox.Enabled = false;
            Createvehiclebtn.Enabled = true;
            btn_resetvehicle.Visible = false;
            Vehicletxt.Enabled = true;
            Vehicletxt.Text = string.Empty;
        }
    }
}
