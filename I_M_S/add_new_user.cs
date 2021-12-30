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
    public partial class add_new_user : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TSHN4BD;Initial Catalog=IMS;Integrated Security=True");
        public add_new_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registeration where username='" + UNameTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into registeration values('"+ FNameTextBox.Text + "','"+ LNameTextBox.Text + "','"+ UNameTextBox.Text + "','"+ PasswordTextBox.Text + "','"+ EmailTextBox.Text + "','"+ ContactTextBox.Text + "')";
                cmd1.ExecuteNonQuery();
                MessageBox.Show("New User Registered Successfully!","Success Message");
                FNameTextBox.Clear();
                LNameTextBox.Clear();
                UNameTextBox.Clear();
                PasswordTextBox.Clear();
                EmailTextBox.Clear();
                ContactTextBox.Clear();
                FNameTextBox.Focus();
                display();
            }
            else
            {
                MessageBox.Show("This username already registered. Please Choose anyother username.", "Error Message");
                UNameTextBox.Clear();
                FNameTextBox.Focus();
            }
        }

        private void add_new_user_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
        }

        public void display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registeration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            UserInfoDataGridView.DataSource = dt;
        }

        private void UserDelButton_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(UserInfoDataGridView.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from registeration where ID='"+id+"'";
            cmd.ExecuteNonQuery();
            display();
            MessageBox.Show("Record Deleted Successfully!", "Success Message");
            
        }

    }
}
