
namespace Ado.Net02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_Orders = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_OrderDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_Orders
            // 
            this.cbx_Orders.FormattingEnabled = true;
            this.cbx_Orders.Location = new System.Drawing.Point(12, 33);
            this.cbx_Orders.Name = "cbx_Orders";
            this.cbx_Orders.Size = new System.Drawing.Size(131, 21);
            this.cbx_Orders.TabIndex = 0;
            this.cbx_Orders.SelectedIndexChanged += new System.EventHandler(this.cbx_Orders_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_OrderDetail
            // 
            this.btn_OrderDetail.Location = new System.Drawing.Point(619, 100);
            this.btn_OrderDetail.Name = "btn_OrderDetail";
            this.btn_OrderDetail.Size = new System.Drawing.Size(119, 33);
            this.btn_OrderDetail.TabIndex = 2;
            this.btn_OrderDetail.Text = "Order Details";
            this.btn_OrderDetail.UseVisualStyleBackColor = true;
            this.btn_OrderDetail.Click += new System.EventHandler(this.btn_OrderDetail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 417);
            this.Controls.Add(this.btn_OrderDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_Orders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Orders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_OrderDetail;
    }
}

