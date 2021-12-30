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
    public partial class add__product_name : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TSHN4BD;Initial Catalog=IMS;Integrated Security=True");
        public add__product_name()
        {
            InitializeComponent();
        }

        private void add__product_name_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fill_unit_dd();
            fill_dg();
        }

        public void fill_unit_dd()
        {
            SelectUnitComboBox.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                SelectUnitComboBox.Items.Add(dr["unit"].ToString());
            }
        }

        public void fill_dg()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_name";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ProductNameDataGridView.DataSource = dt;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductNameTextBox.Focus();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into product_name values('" + ProductNameTextBox.Text + "','"+ SelectUnitComboBox.SelectedItem.ToString() + "')";
            cmd1.ExecuteNonQuery();
            fill_dg();
            MessageBox.Show("Record Inserted Successfully!", "Success Message");
            ProductNameTextBox.Clear();
            ProductNameTextBox.Focus();
        }


        private void ProductNameDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            int i = Convert.ToInt32(ProductNameDataGridView.SelectedCells[0].Value.ToString());

            UpdateUnitComboBox.Items.Clear();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from units";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                UpdateUnitComboBox.Items.Add(dr2["unit"].ToString());
            }

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product_name where ID='" + i + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                UpdatePNameTextBox.Text = dr["product_name"].ToString();
                UpdateUnitComboBox.SelectedItem = dr["units"].ToString();
            }
        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(ProductNameDataGridView.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update product_name set product_name='"+ UpdatePNameTextBox.Text + "',units='"+ UpdateUnitComboBox.SelectedItem.ToString() + "' where ID='" + i + "'";
            cmd.ExecuteNonQuery();
            panel2.Visible = false;
            fill_dg();
            MessageBox.Show("Record Updated Successfully!","Success Message");
        }
    }
}
