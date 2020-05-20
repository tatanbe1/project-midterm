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
    public partial class Form9 : Form
    {
        public String text;
        public Form9(string tx)
        {
            InitializeComponent();
            /*string sql = "SELECT txtname ,txtlastname ,txtjunghwad ,txtschool ,txtaumper, txttumbon ,txtnan ,txtphoneumber ,onmath ,onsci ,oneng ,onthai ,onsoc,ninethai ,ninemath ,ninebio ,ninesoc ,ninephy ,ninemath2 ,nineeng ,ninechem ,ninesci,gatthai ,gateng ,pat1 ,pat2 ,pat3 ,pat4 ,pat5 ,pat6 ,pat7 FROM username WHERE email='" + tx + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) // == this is the Read() method was called
                {
                    txtname.Text = reader.GetString("txtname");
                    txtlastname.Text = reader.GetString("txtlastname");
                    txtjunghwad.Text = reader.GetString("txtjunghwad");
                    txtschool.Text = reader.GetString("txtschool");
                    txtaumper.Text = reader.GetString("txtaumper");
                    txttumbon.Text = reader.GetString("txttumbon");
                    txtnan.Text = reader.GetString("txtnan");
                    txtphoneumber.Text = reader.GetString("txtphoneumber");
                    onmath.Text = reader.GetString("onmath");
                    onsci.Text = reader.GetString("onsci");
                    oneng.Text = reader.GetString("oneng");
                    onthai.Text = reader.GetString("onthai");
                    onsoc.Text = reader.GetString("onsoc");
                    ninethai.Text = reader.GetString("ninethai");
                    ninemath.Text = reader.GetString("ninemath");
                    ninebio.Text = reader.GetString("ninebio");
                    ninesoc.Text = reader.GetString("ninesoc");
                    ninephy.Text = reader.GetString("ninephy");
                    ninemath2.Text = reader.GetString("ninemath2");
                    nineeng.Text = reader.GetString("nineeng");
                    ninechem.Text = reader.GetString("ninechem");
                    ninesci.Text = reader.GetString("ninesci");
                    gatthai.Text = reader.GetString("gatthai");
                    gateng.Text = reader.GetString("gateng");
                    pat1.Text = reader.GetString("pat1");
                    pat2.Text = reader.GetString("pat2");
                    pat3.Text = reader.GetString("pat3");
                    pat4.Text = reader.GetString("pat4");
                    pat5.Text = reader.GetString("pat5");
                    pat6.Text = reader.GetString("pat6");
                    pat7.Text = reader.GetString("pat7");
                }
            }

            reader.Close();
            con.Close();*/
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel12.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel18.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel29.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            panel29.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE username SET txtname='" + txtname.Text + "' ,txtlastname='" + txtlastname.Text + "' ,txtjunghwad='" + txtjunghwad.Text + "' ,txtschool='" + txtschool.Text + "' ,txtaumper='" + txtaumper.Text + "' ,txttumbon='" + txttumbon.Text + "', txtnan='" + txtnan.Text + "' ,txtphoneumber='" + txtphoneumber.Text + "' ,onmath='" + onmath.Text + "', onsci='" + onsci.Text + "', oneng='" + oneng.Text + "', onthai='" + onthai.Text + "', onsoc='" + onsoc.Text + "', ninethai='" + ninethai.Text + "' ,ninemath='" + ninemath.Text + "' ,ninebio='" + ninebio.Text + "' ,ninesoc='" + ninesoc.Text + "' ,ninephy='" + ninephy.Text + "' ,ninemath2='" + ninemath2.Text + "' ,nineeng='" + nineeng.Text + "' ,ninechem='" + ninechem.Text + "' ,ninesci='" + ninesci.Text + "' ,gatthai='" + gatthai.Text + "', gateng='" + gateng.Text + "', pat1='" + pat1.Text + "', pat2='" + pat2.Text + "', pat3='" + pat3.Text + "', pat4='" + pat4.Text + "', pat5='" + pat5.Text + "', pat6='" + pat6.Text + "', pat7='" + pat7.Text + "' WHERE email = '" + text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            panel40.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
