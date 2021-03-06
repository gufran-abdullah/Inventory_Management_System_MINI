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
    public partial class unit : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TSHN4BD;Initial Catalog=IMS;Integrated Security=True");
        public unit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from units where unit='"+ UnitTextBox.Text + "'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            count = Convert.ToInt32(dt2.Rows.Count.ToString());
            if (count == 0)
            {
                UnitTextBox.Focus();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into units values('" + UnitTextBox.Text + "')";
                cmd1.ExecuteNonQuery();
                display();
                MessageBox.Show("Record Inserted Successfully!", "Success Message");
                UnitTextBox.Clear();
                UnitTextBox.Focus();
            }
            else
            {
                MessageBox.Show("This type of unit already existes. Enter anyother one.", "Error Message");
            }
        }

        private void unit_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from units";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            UnitDataGridView.DataSource = dt;
        }

        private void DeleteUnitButton_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(UnitDataGridView.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from units where ID='" + id + "'";
            cmd.ExecuteNonQuery();
            display();
            MessageBox.Show("Record Deleted Successfully!", "Success Message");
        }
    }
}
