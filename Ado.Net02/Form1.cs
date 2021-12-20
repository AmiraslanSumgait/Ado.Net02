using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net02
{


    public partial class Form1 : Form
    {
        string connectionString = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                da = new SqlDataAdapter("SELECT OrderId  FROM Orders", conn);
                dt = new DataTable();
                da.Fill(dt);
                var query = "SELECT OrderId  FROM Orders";
                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    int line = 0;
                    do
                    {
                        while (dataReader.Read())
                        {
                            cbx_Orders.Items.Add(dataReader.GetValue(0));
                        }
                        line++;
                    } while (dataReader.NextResult());
                }
                cbx_Orders.SelectedIndex = 0;
            }
        }

        private void cbx_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(@"Select Customers.CompanyName,ProductName From Orders INNER JOIN Customers
                                               on Orders.CustomerID=Customers.CustomerID INNER JOIN [Order Details]
                                               on Orders.OrderID=[Order Details].OrderID INNER JOIN Products
                                               on [Order Details].ProductID=Products.ProductID
                                               Where Orders.OrderID=" + cbx_Orders.SelectedItem.ToString() , connectionString);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_OrderDetail_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = this.dataGridView1.SelectedRows[0];

            // MessageBox.Show(row.Cells["ColumnName"].Value.ToString());
            //MessageBox.Show(dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString());
            da = new SqlDataAdapter(@"SELECT [Order Details].Quantity,[Order Details].UnitPrice,[Order Details].Discount,[Order Details].OrderID,[Order Details].ProductID from Customers 
           INNER JOIN Orders ON
           Orders.CustomerID=Customers.CustomerID INNER JOIN [Order Details] ON
           [Order Details].OrderID=Orders.OrderID INNER JOIN Products ON
           Products.ProductID=[Order Details].ProductID
           where Products.ProductName=@ProductName", connectionString);
            dt = new DataTable();
            dataGridView1.ClearSelection();
            da.SelectCommand.Parameters.AddWithValue("ProductName", dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString());
            da.Fill(dt);
            OrderDetail orderDetail = new OrderDetail(dt);
            orderDetail.ShowDialog();
            

        }
    }
}
