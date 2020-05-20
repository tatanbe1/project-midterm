using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace projectnew2
{
    public partial class Form8 : Form
    {
        public String text;
        public Form8(string tx)
        {
            InitializeComponent();
            string sql = "SELECT txtname ,txtlastname ,txtjunghwad ,txtschool ,txtaumper, txttumbon ,txtnan ,txtphoneumber ,onmath ,onsci ,oneng ,onthai ,onsoc,ninethai ,ninemath ,ninebio ,ninesoc ,ninephy ,ninemath2 ,nineeng ,ninechem ,ninesci,gatthai ,gateng ,pat1 ,pat2 ,pat3 ,pat4 ,pat5 ,pat6 ,pat7 FROM username WHERE email='" + tx + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read()) // == this is the Read() method was called
                {
                    omath.Text = reader.GetString("onmath");
                    osci.Text = reader.GetString("onsci");
                    oeng.Text = reader.GetString("oneng");
                    othai.Text = reader.GetString("onthai");
                    osoc.Text = reader.GetString("onsoc");
                    thai9.Text = reader.GetString("ninethai");
                    math9.Text = reader.GetString("ninemath");
                    bio9.Text = reader.GetString("ninebio");
                    soc9.Text = reader.GetString("ninesoc");
                    phy9.Text = reader.GetString("ninephy");
                    math29.Text = reader.GetString("ninemath2");
                    eng9.Text = reader.GetString("nineeng");
                    chem9.Text = reader.GetString("ninechem");
                    sci9.Text = reader.GetString("ninesci");
                    thaig.Text = reader.GetString("gatthai");
                    engg.Text = reader.GetString("gateng");
                    p1.Text = reader.GetString("pat1");
                    p2.Text = reader.GetString("pat2");
                    p3.Text = reader.GetString("pat3");
                    p4.Text = reader.GetString("pat4");
                    p5.Text = reader.GetString("pat5");
                    p6.Text = reader.GetString("pat6");
                    p7.Text = reader.GetString("pat7");
                }
            }

            reader.Close();
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE username SET onmath='" + omath.Text + "',onsci='" + osci.Text + "', oneng='" + oeng.Text + "', onthai='" + othai.Text + "', onsoc='" + osoc.Text + "', ninethai='" + thai9.Text + "' ,ninemath='" + math9.Text + "' ,ninebio='" + bio9.Text + "' ,ninesoc='" + soc9.Text + "' ,ninephy='" + phy9.Text + "' ,ninemath2='" + math29.Text + "' ,nineeng='" + eng9.Text + "' ,ninechem='" + chem9.Text + "' ,ninesci='" + sci9.Text + "' ,gatthai='" + thaig.Text + "', gateng='" + engg.Text + "', pat1='" + p1.Text + "', pat2='" + p2.Text + "', pat3='" + p3.Text + "', pat4='" + p4.Text + "', pat5='" + p5.Text + "', pat6='" + p6.Text + "', pat7='" + p7.Text + "' WHERE email = '" + text + "'";
            MySqlConnection con = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("กําหนดเกณฑ์คะเเนนสำเร็จ");
            float total = 0;
            string sql3 = "SELECT * FROM username";
            MySqlConnection con3 = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
            MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
            con3.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                total = 0;
                total = total + float.Parse(omath.Text) * float.Parse(reader3.GetString("onmath"))/100;
                total = total + float.Parse(osci.Text) * float.Parse(reader3.GetString("onsci")) / 100;
                total = total + float.Parse(oeng.Text) * float.Parse(reader3.GetString("oneng")) / 100;
                total = total + float.Parse(othai.Text) * int.Parse(reader3.GetString("onthai")) / 100;
                total = total + float.Parse(osoc.Text) * float.Parse(reader3.GetString("onsoc")) / 100;
                total = total + float.Parse(thai9.Text) * float.Parse(reader3.GetString("ninethai")) / 100;
                total = total + float.Parse(math9.Text) * float.Parse(reader3.GetString("ninemath")) / 100;
                total = total + float.Parse(bio9.Text) * float.Parse(reader3.GetString("ninebio")) / 100;
                total = total + float.Parse(soc9.Text) * float.Parse(reader3.GetString("ninesoc")) / 100;
                total = total + float.Parse(phy9.Text) * float.Parse(reader3.GetString("ninephy")) / 100;
                total = total + float.Parse(math29.Text) * float.Parse(reader3.GetString("ninemath2")) / 100;
                total = total + float.Parse(eng9.Text) * float.Parse(reader3.GetString("nineeng")) / 100;
                total = total + float.Parse(chem9.Text) * float.Parse(reader3.GetString("ninechem")) / 100;
                total = total + float.Parse(sci9.Text) * float.Parse(reader3.GetString("ninesci")) / 100;
                total = total + float.Parse(thaig.Text) * float.Parse(reader3.GetString("gatthai")) / 100;
                total = total + float.Parse(engg.Text) * float.Parse(reader3.GetString("gateng")) / 100;
                total = total + float.Parse(p1.Text) * float.Parse(reader3.GetString("pat1")) / 100;
                total = total + float.Parse(p2.Text) * float.Parse(reader3.GetString("pat2")) / 100;
                total = total + float.Parse(p3.Text) * float.Parse(reader3.GetString("pat3")) / 100;
                total = total + float.Parse(p4.Text) * float.Parse(reader3.GetString("pat4")) / 100;
                total = total + float.Parse(p5.Text) * float.Parse(reader3.GetString("pat5")) / 100;
                total = total + float.Parse(p6.Text) * float.Parse(reader3.GetString("pat6")) / 100;
                total = total + float.Parse(p7.Text) * float.Parse(reader3.GetString("pat7")) / 100;
                string sql2 = "UPDATE username SET totalscore = '"+total+ "' WHERE email='"+reader3.GetString("email")+"'";
                MySqlConnection con2 = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
                MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();
                
            }
            reader3.Close();
            con3.Close();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            datag.Visible = true;
            panel2.Visible = false;
            string sql = "SELECT txtname,txtlastname,email,totalscore FROM username WHERE status!='Admin' ORDER BY totalscore DESC";
            MySqlConnection con = new MySqlConnection("host=localhost;user=projectnew;password=123456;database=projectnew");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            datag.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datag.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void datag_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.live.com");

            var mail = new MailMessage();
            mail.From = new MailAddress(txtmail.Text);
            mail.To.Add(txtreceiver.Text);
            mail.Subject = txthaeder.Text;
            mail.IsBodyHtml = true;
            mail.Body = richTextBox1.Text;

            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential(txtmail.Text, txtpassword.Text);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
            

            MessageBox.Show("ส่งอีเมลสำเร็จ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
