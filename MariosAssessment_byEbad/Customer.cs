using MariosAssessment_byEbad.Documents;
using MariosAssessment_byEbad.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MariosAssessment_byEbad
{
    public partial class Customer : Form
    {
        private readonly IRepository<CustomerDocument> repository;
        public Customer()
        {
            InitializeComponent();
        }
        private string CustomerName = string.Empty;
        private bool isActive;

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerName = textBox1.Text;
            isActive = checkBox1.Checked;

            if (string.IsNullOrEmpty(CustomerName)) MessageBox.Show("Please Enter customer Name", "Error");
            if (isActive) MessageBox.Show("Please Select status of customer","Error");

            var document = new CustomerDocument()
            {
                Name = CustomerName,
                isActive = isActive,
            };

            if(document.CustomerId != null)repository.Update(document);
            
            if (document.CustomerId == null) repository.Add(document);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedUserId = customerList.SelectedIndex;
            var data = repository.GetById(selectedUserId);


            textBox1 .Text = data.Name;
            checkBox1.Checked = data.isActive;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            int userId = customerList.SelectedIndex;
            if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            repository.Delete(userId);
        }
    }
}
