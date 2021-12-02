using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net02
{
    public partial class OrderDetail : Form
    {
        public OrderDetail(DataTable dataTable)
        {
            InitializeComponent();
            lbl_Quantity.Text = dataTable.Rows[0][0].ToString();
            lbl_UnitPrice.Text = dataTable.Rows[0][1].ToString();
            lbl_Discount.Text = dataTable.Rows[0][2].ToString();
            lbl_OrderId.Text = dataTable.Rows[0][3].ToString();
            lbl_ProductId.Text = dataTable.Rows[0][4].ToString();

        }
    }
}
