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
    public partial class dealer_info : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TSHN4BD;Initial Catalog=IMS;Integrated Security=True");
        public dealer_info()
        {
            InitializeComponent();
        }

        private void dealer_info_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
        }

        private void AddDButton_Click(object sender, EventArgs e)
        {
            DNameTextBox.Focus();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into dealer_info values('" + DNameTextBox.Text + "','" + DCNameTextBox.Text + "','" + DContactTextBox.Text + "','" + DAddressTextBox.Text + "','" + DCityTextBox.Text + "')";
            cmd1.ExecuteNonQuery();
            display();
            MessageBox.Show("Record Inserted Successfully!","Success Message");
            DNameTextBox.Clear();
            DCNameTextBox.Clear();
            DContactTextBox.Clear();
            DAddressTextBox.Clear();
            DCityTextBox.Clear();
            DNameTextBox.Focus();

        }

        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DealerDataGridView.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DealerDataGridView.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dealer_info where ID='"+id+"'";
            cmd.ExecuteNonQuery();
            display();
            MessageBox.Show("Record Deleted Successfully!", "Success Message");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int id = Convert.ToInt32(DealerDataGridView.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info where ID='"+id+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                UpdateDNTextBox.Text = dr["dealer_name"].ToString();
                UpdateDCNTextBox.Text = dr["dealer_company_name"].ToString();
                UpdateDCTextBox.Text = dr["contact"].ToString();
                UpdateDATextBox.Text = dr["address"].ToString();
                UpdateDCityTextBox.Text = dr["city"].ToString();
            }
        }

        private void UpdateDButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DealerDataGridView.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dealer_info set dealer_name='"+ UpdateDNTextBox.Text + "',dealer_company_name='"+ UpdateDCNTextBox.Text + "',contact='"+ UpdateDCTextBox.Text + "',address='" + UpdateDATextBox.Text + "',city='" + UpdateDCityTextBox.Text + "' where ID='" + id + "'";
            cmd.ExecuteNonQuery();
            panel2.Visible = false;
            display();
            MessageBox.Show("Record Update Successfully!", "Success Message");
            DNameTextBox.Focus();
        }
    }
}
