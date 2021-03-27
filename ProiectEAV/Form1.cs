using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectEAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Default home page
            webView1.Navigate("https://www.google.ro/maps/search/oficii+postale+craiova/@44.3080085,23.767188,13z/data=!3m1!4b1?hl=ro");
        }

        DataTable dt = new DataTable();
        public void LoadData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CUHAUG6\SQLEXPRESS;" +
                "Initial Catalog=PostOficces;Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM oficii_postale", conn);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            conn.Open();
            sa.Fill(dt);
            conn.Close();
            sa.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                OficiiPostale.Items.Add(Convert.ToString(dt.Rows[i]["denumire"]));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (OficiiPostale.Text == Convert.ToString(dt.Rows[i]["denumire"]))
                {
                    if (!Convert.ToString(dt.Rows[i]["link_gm"]).Equals(""))
                    {
                        webView1.Navigate(Convert.ToString(dt.Rows[i]["link_gm"]));
                    }
                    else 
                    {
                        String searchQuerry = "https://www.google.com/maps/search/" + OficiiPostale.Text;
                        webView1.Navigate(searchQuerry);
                    }

                    textBoxInfo.Text = Convert.ToString(dt.Rows[i]["denumire"]) + " este un " + Convert.ToString(dt.Rows[i]["tip"])
                        + ". \nAdresa acestei unitati postale este in " + Convert.ToString(dt.Rows[i]["adresa"]) + ". \nCodul postal al acestei locatii este " + Convert.ToString(dt.Rows[i]["cod_postal"]) +
                        "\n Adresa de email este: " + Convert.ToString(dt.Rows[i]["mail"]);
                    break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string StringComp = "https://www.google.com/maps/search/" + textBoxCautare.Text;
            webView1.Navigate(StringComp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (OficiiPostale.Text == Convert.ToString(dt.Rows[i]["denumire"]))
                {
                    webView1.Navigate(Convert.ToString(dt.Rows[i]["link_gsv"]));
                    break;
                }
            }
        }

        // Executia e din acest stackframe e oprita cat ShowDialog() e activa
        // Cand Dialogul de introducere in BD se inchide, executia se reia aici
        // Baza de date este actualizata cand un element este introdus
        private void button2_Click(object sender, EventArgs e)
        {
            Form dialog = new FormDBIN();
            dialog.ShowDialog();
            LoadData();
        }

        private void comboBoxOrase_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!comboBoxOrase.Items.Contains(Convert.ToString(dt.Rows[i]["adresa"]).Split(',')[0]))
                    comboBoxOrase.Items.Add(Convert.ToString(dt.Rows[i]["adresa"]).Split(',')[0]);
            }
        }

        private void comboBoxOrase_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrase.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (comboBoxOrase.Text == Convert.ToString(dt.Rows[i]["adresa"]).Split(',')[0])
                {
                    listBoxOrase.Items.Add(Convert.ToString(dt.Rows[i]["denumire"]) 
                       + "; " + Convert.ToString(dt.Rows[i]["tip"])
                       + "; " + Convert.ToString(dt.Rows[i]["adresa"])
                       + "; " + Convert.ToString(dt.Rows[i]["cod_postal"])
                       + "; " + Convert.ToString(dt.Rows[i]["mail"]));
                    listBoxOrase.Items.Add(" "); // @todo, de adaugat linie noua, \n nu merge
                }
            }
        }
    }
}
