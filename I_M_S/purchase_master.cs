using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace I_M_S
{
    public partial class purchase_master : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TSHN4BD;Initial Catalog=IMS;Integrated Security=True");
        public purchase_master()
        {
            InitializeComponent();
        }

        private void ProductPurchaseButton_Click(object sender, EventArgs e)
        {
            int i;
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from stock where product_name='" + PNameComboBox.Text + "'";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            i = Convert.ToInt32(dt3.Rows.Count.ToString());
            if (i == 0)
            {
                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "insert into purchase_master values('" + PNameComboBox.Text + "','" + PqtyTextBox.Text + "','" + label4.Text + "','" + PpriceTextBox.Text + "','" + PtotalTextBox.Text + "','" + PdateDateTimePicker.Value.ToString("dd-MM-yyyy") + "','" + PdealerComboBox.Text + "','" + PpurchaseComboBox.Text + "','" + PexpiryDateTimePicker.Value.ToString("dd-MM-yyyy") + "','" + PprofitTextBox.Text + "')";
                cmd4.ExecuteNonQuery();

                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "insert into stock values('" + PNameComboBox.Text + "','" + PqtyTextBox.Text + "','" + label4.Text + "')";
                cmd5.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "insert into purchase_master values('" + PNameComboBox.Text + "','" + PqtyTextBox.Text + "','" + label4.Text + "','" + PpriceTextBox.Text + "','" + PtotalTextBox.Text + "','" + PdateDateTimePicker.Value.ToString("dd-MM-yyyy") + "','" + PdealerComboBox.Text + "','" + PpurchaseComboBox.Text + "','" + PexpiryDateTimePicker.Value.ToString("dd-MM-yyyy") + "','" + PprofitTextBox.Text + "')";
                cmd6.ExecuteNonQuery();

                SqlCommand cmd7 = con.CreateCommand();
                cmd7.CommandType = CommandType.Text;
                cmd7.CommandText = "update stock set product_qty=product_qty+"+ PqtyTextBox.Text+ " where product_name='"+ PNameComboBox.Text + "'";
                cmd7.ExecuteNonQuery();
            }

            
            MessageBox.Show("Product Purchased Successfully!","Success Message");

            PqtyTextBox.Clear();
            PpriceTextBox.Clear();
            PtotalTextBox.Clear();
            PprofitTextBox.Clear();
            PqtyTextBox.Focus();

        }

        private void purchase_master_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_product_name();
            fill_dealer_name();
        }

        public void fill_product_name()
        {
            PNameComboBox.Items.Clear();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from product_name";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                PNameComboBox.Items.Add(dr2["product_name"].ToString());
            }
        }

        private void PNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from product_name where product_name='"+ PNameComboBox .Text+ "'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                label4.Text = dr2["units"].ToString();
            }
        }

        public void fill_dealer_name()
        {
            
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from dealer_info";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                PdealerComboBox.Items.Add(dr2["dealer_name"].ToString());
            }
        }

        private void PpriceTextBox_Leave(object sender, EventArgs e)
        {
            PtotalTextBox.Text = Convert.ToString(Convert.ToInt32(PqtyTextBox.Text) * Convert.ToInt32(PpriceTextBox.Text));
        }
    }
} 
