using MariosAssessment_byEbad.Documents;
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
    public partial class OrderDetails : Form
    {
        public OrderDetails(object orderData)
        {
            
            InitializeComponent();
            if (orderData is OrderDetailsDocument)
            {
                PopulateItemsGrid((IEnumerable<OrderDetailsDocument>)orderData);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void PopulateItemsGrid(IEnumerable<OrderDetailsDocument> orders)
        {
            orderItemsGrid.Rows.Clear();

            if (orderItemsGrid.Columns.Count == 0)
            {
                orderItemsGrid.Columns.Add("Name", "Item Name");
                orderItemsGrid.Columns.Add("Quantity", "Quantity");
                orderItemsGrid.Columns.Add("UnitPrice", "Unit Price");
                orderItemsGrid.Columns.Add("TotalPrice", "Total Price");
            }
            foreach (var detail in orders)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = detail.Item });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = detail.Qty });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = detail.Price });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = detail.Qty * detail.Price });
                orderItemsGrid.Rows.Add(row);
            }
        }
    }
}
