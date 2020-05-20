using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectnew2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtpassword.Text!=textBox3.Text)
            {
                MessageBox.Show("รหัสไม่ตรงกันกรุณาลองอีกครั้ง");

            }
            else
            {
                string sql = "SELECT * FROM username WHERE email='" + txtemail.Text + "' OR username='" + txtusername.Text + "'";
                MySqlConnection con = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Username หรือ E-mail ของท่านมีผู้ใช้เเล้ว กรุณาลองใหม่อีกครั้ง");
                    reader.Close();
                    con.Close();

                }
                else
                {
                    reader.Close();
                    con.Close();
                    con.Open();
                    sql = "INSERT INTO username (username,password,email) VALUES('" + txtusername.Text + "', '" + txtpassword.Text + "', '" + txtemail.Text + "')";
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    Form9 fm9 = new Form9(txtemail.Text);
                    fm9.text = txtemail.Text;
                    fm9.Show();
                }
            }
        }
    }
}
