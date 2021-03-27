using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProiectEAV
{
    public partial class Form1 : Form
    {
        oficii_postale OP;
        public Form1()
        {
            InitializeComponent();
            // Default home page
            webView1.Navigate("https://www.google.ro/maps/search/oficii+postale+craiova/@44.3080085,23.767188,13z/data=!3m1!4b1?hl=ro");
        }

        public void LoadData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(oficii_postale));
            StreamReader reader = new StreamReader(@"..\..\records.xml");
            OP = (oficii_postale)serializer.Deserialize(reader);
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            foreach (var oficiuPostal in OP.Items)
            {
                OficiiPostale.Items.Add(oficiuPostal.denumire.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Modificata, ToBeReworked
            foreach (var oficiuPostal in OP.Items)
            {
                if (OficiiPostale.Text == oficiuPostal.denumire.ToString())
                {
                    String searchQuerry = "https://www.google.com/maps/search/" + OficiiPostale.Text;
                    webView1.Navigate(searchQuerry);

                    textBoxInfo.Text = oficiuPostal.denumire.ToString() + " este un " + oficiuPostal.tip.ToString() +
                        ". \nAdresa acestei unitati postale este in " + oficiuPostal.adresa.ToString() +
                        ". \nCodul postal al acestei locatii este " + oficiuPostal.cod_postal.ToString() +
                        "\n Adresa de email este: " + oficiuPostal.mail.ToString();
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
            foreach (var oficiuPostal in OP.Items)
            {
                if (OficiiPostale.Text == oficiuPostal.denumire.ToString())
                {
                    webView1.Navigate("https://www.google.com/maps/search/" + OficiiPostale.Text);
                    break;
                }
            }
        }

        // Executia e din acest stackframe e oprita cat ShowDialog() e activa
        // Cand Dialogul de introducere in XML se inchide, executia se reia aici
        private void button2_Click(object sender, EventArgs e)
        {
            Form dialog = new FormDBIN();
            dialog.ShowDialog();
            LoadData();
        }

        private void comboBoxOrase_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var oficiuPostal in OP.Items)
            {
                if (!comboBoxOrase.Items.Contains(oficiuPostal.adresa.ToString().Split(',')[0]))
                    comboBoxOrase.Items.Add(oficiuPostal.adresa.ToString().Split(',')[0]);
            }
        }

        private void comboBoxOrase_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrase.Items.Clear();
            foreach (var oficiuPostal in OP.Items)
            {
                if (comboBoxOrase.Text == oficiuPostal.adresa.ToString().Split(',')[0])
                {
                    listBoxOrase.Items.Add(oficiuPostal.denumire.ToString()
                       + "; " + oficiuPostal.tip.ToString()
                       + "; " + oficiuPostal.adresa.ToString()
                       + "; " + oficiuPostal.cod_postal.ToString()
                       + "; " + oficiuPostal.mail.ToString());
                    listBoxOrase.Items.Add(" "); // @todo, de adaugat linie noua, \n nu merge
                }
            }
        }
    }
}
