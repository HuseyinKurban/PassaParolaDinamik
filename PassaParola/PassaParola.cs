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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using Button = System.Windows.Forms.Button;

namespace PassaParola
{
    public partial class PassaParola : Form
    {
        public PassaParola()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        string cevap;


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbPassaParola;Integrated Security=True;");

        string[] harfler = new string[] { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V" };

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linklbl.Text = "Sonraki Soru";
            linklbl.Enabled = false;
            soruno++;
            this.Text = "PassaParola SoruNo: " + soruno;
            txtcevap.Text = "";
            txtcevap.Enabled = true;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblSoru where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", soruno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                rchtxtsoru.Text = dr[1].ToString();
                cevap = dr[2].ToString();

            }
            baglanti.Close();


            if (soruno < 23)
            {
                try
                {
                    button15.Text = harfler[soruno];
                    button15.BackColor = Color.Yellow;
                }
                catch (Exception)
                {


                }


            }

            if (soruno == 23)
            {
                rchtxtsoru.Text = "";
                txtcevap.Text = "";
                txtcevap.Enabled = false;
                this.Text = "PassaParola";
                linklbl.Text = "Başla";
                soruno = 0;
                dogru = 0;
                yanlis = 0;


                MessageBox.Show("Doğru Sayısı: " + lbldogru.Text + "\nYanlış Sayısı: " + lblyanlis.Text + "\nBoş Sayısı: " + lblbos.Text, "OYUN BİTTİ");
            }


        }

        private void txtcevap_KeyDown(object sender, KeyEventArgs e)
        {
            linklbl.Enabled = true;
            if (e.KeyCode == Keys.Enter)
            {
                Button btn = new Button();
                btn.Text = harfler[soruno];
                btn.Name = "btn" + harfler[soruno];
                btn.Size = new Size(56, 47);

                if (soruno <= 7)
                {
                    btn.Location = new Point(12 + 62 * (soruno - 1), 12);
                }
                else if (soruno > 7 && soruno <= 12)
                {
                    btn.Location = new Point(383, 65 + 53 * (soruno - 8));
                }
                else if (soruno > 12 && soruno <= 18)
                {
                    btn.Location = new Point(322 - 62 * (soruno - 13), 278);
                }
                else if (soruno > 18 && soruno <= 24)
                {
                    btn.Location = new Point(12, 225 - 53 * (soruno - 19));
                }

                if (txtcevap.Text == cevap)
                {
                    btn.BackColor = Color.Green;
                    dogru++;
                    lbldogru.Text = dogru.ToString();
                }
                else
                {
                    btn.BackColor = Color.Red;
                    yanlis++;
                    lblyanlis.Text = yanlis.ToString();
                }
                Controls.Add(btn);

            }

        }
    }
}

