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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        void removebg(PictureBox pb,PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM username WHERE email='" + textBox1.Text + "' AND password='"+textBox3.Text+"'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    if (reader.GetString("status") == "Admin")
                    {
                        this.Hide();
                        Form8 fm8 = new Form8(textBox1.Text);
                        fm8.text = textBox1.Text;
                        fm8.Show();
                        break;
                    }
                    else
                    {
                        this.Hide();
                        Form9 fm9 = new Form9(textBox1.Text);
                        fm9.text = textBox1.Text;
                        fm9.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("E-mail หรือ Password ไม่ถูกต้อง กรุณาลองใหม่อีกครั้ง");
            }
            reader.Close();
            con.Close();
        }
    }
}
