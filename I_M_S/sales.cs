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
    public partial class sales : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TSHN4BD;Initial Catalog=IMS;Integrated Security=True");
        DataTable dt = new DataTable();
        int tot = 0;
        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            dt.Clear();
            dt.Columns.Add("Product");
            dt.Columns.Add("Price");
            dt.Columns.Add("QTY");
            dt.Columns.Add("Total");
        }

        private void SalesPTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SalePListBox.Visible = true;
            SalePListBox.Items.Clear();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stock where product_name like('"+ SalesPTextBox.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SalePListBox.Items.Add(dr["product_name"].ToString());
            }

        }

        private void SalesPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SalePListBox.Focus();
                SalePListBox.SelectedIndex = 0;
            }
        }

        private void SalePListBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.SalePListBox.SelectedIndex = this.SalePListBox.SelectedIndex + 1;
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.SalePListBox.SelectedIndex = this.SalePListBox.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    SalesPTextBox.Text = SalePListBox.SelectedItem.ToString();
                    SalePListBox.Visible = false;
                    SalesPriceTextBox.Focus();
                }

            }
            catch (Exception ex)
            {

            }
         
        }

        private void SalesPriceTextBox_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select top 1 * from purchase_master where product_name='"+ SalesPTextBox.Text + "' order by ID desc";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                SalesPriceTextBox.Text = dr1["product_price"].ToString();
            }



        }

        private void SalesqtyTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                SalestotalTextBox.Text = Convert.ToString(Convert.ToInt32(SalesPriceTextBox.Text) * Convert.ToInt32(SalesqtyTextBox.Text));
            }
            catch (Exception ex)
            {

            }
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from stock where product_name='"+ SalesPTextBox.Text + "'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                stock = Convert.ToInt32(dr2["product_qty"].ToString());
            }

            if(Convert.ToInt32(SalesqtyTextBox.Text) > stock)
            {
                MessageBox.Show("Insufficient Stock!","Stock Message");
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["Product"] = SalesPTextBox.Text;
                dr["Price"] = SalesPriceTextBox.Text;
                dr["QTY"] = SalesqtyTextBox.Text;
                dr["Total"] = SalestotalTextBox.Text;
                dt.Rows.Add(dr);
                SalesBillDataGridView.DataSource = dt;

                tot = tot + Convert.ToInt32(dr["total"].ToString());
                label11.Text = tot.ToString();
            }

            SalesPTextBox.Clear();
            SalesPriceTextBox.Clear();
            SalesqtyTextBox.Clear();
            SalestotalTextBox.Clear();
        }

        private void SaleDButton_Click(object sender, EventArgs e)
        {
            try
            {
                tot = 0;
                dt.Rows.RemoveAt(Convert.ToInt32(SalesBillDataGridView.CurrentCell.RowIndex.ToString()));
                foreach (DataRow dr in dt.Rows)
                {
                    tot = tot + Convert.ToInt32(dr["total"].ToString());
                    label11.Text = tot.ToString();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void SaleSPButton_Click(object sender, EventArgs e)
        {
            string order_id = "";
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into order_user values('"+ SalesFNTextBox.Text + "','"+ SalesLNTextBox.Text + "','"+ SalesBTComboBox.Text + "','"+ SalesBDDateTimePicker.Value.ToString("dd-MM-yyyy") + "')";
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select top 1 * from order_user order by ID desc";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                order_id = dr3["ID"].ToString();
            }


            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "insert into order_item values('" + order_id.ToString() + "','" + dr["product"].ToString() + "','" + dr["price"].ToString() + "','" + dr["qty"].ToString() + "','" + dr["total"].ToString() + "')";
                cmd4.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["qty"].ToString());
                pname = dr["product"].ToString();

                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "update stock set product_qty=product_qty-"+ qty +" where product_name='"+pname.ToString()+"'";
                cmd5.ExecuteNonQuery();

            }

            SalesFNTextBox.Clear();
            SalesLNTextBox.Clear();
            SalesPTextBox.Clear();
            SalesPriceTextBox.Clear();
            SalesqtyTextBox.Clear();
            SalestotalTextBox.Clear();
            label11.Text = "";

            dt.Clear();
            SalesBillDataGridView.DataSource = dt;
            MessageBox.Show("Record Inserted Successfully!","Success Message");

        }

        private void SaveandPrintButton_Click(object sender, EventArgs e)
        {
            string order_id = "";
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into order_user values('" + SalesFNTextBox.Text + "','" + SalesLNTextBox.Text + "','" + SalesBTComboBox.Text + "','" + SalesBDDateTimePicker.Value.ToString("dd-MM-yyyy") + "')";
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select top 1 * from order_user order by ID desc";
            cmd3.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                order_id = dr3["ID"].ToString();
            }


            foreach (DataRow dr in dt.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "insert into order_item values('" + order_id.ToString() + "','" + dr["product"].ToString() + "','" + dr["price"].ToString() + "','" + dr["qty"].ToString() + "','" + dr["total"].ToString() + "')";
                cmd4.ExecuteNonQuery();

                qty = Convert.ToInt32(dr["qty"].ToString());
                pname = dr["product"].ToString();

                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "update stock set product_qty=product_qty-" + qty + " where product_name='" + pname.ToString() + "'";
                cmd5.ExecuteNonQuery();

            }

            SalesFNTextBox.Clear();
            SalesLNTextBox.Clear();
            SalesPTextBox.Clear();
            SalesPriceTextBox.Clear();
            SalesqtyTextBox.Clear();
            SalestotalTextBox.Clear();
            label11.Text = "";

            dt.Clear();
            SalesBillDataGridView.DataSource = dt;

            generate_bill gb = new generate_bill();
            gb.get_value(Convert.ToInt32(order_id.ToString()));
            gb.Show();
        }
    }
}
