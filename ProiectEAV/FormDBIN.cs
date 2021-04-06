using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProiectEAV
{
    public partial class FormDBIN : Form
    {
        public FormDBIN()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" &&
                textBox2.Text != "" &&
                textBox3.Text != "" &&
                textBox4.Text != "" &&
                textBox5.Text != "")
            {
                var rand = new Random();
                XDocument doc = XDocument.Load(@"..\..\records.xml");

                XElement root = new XElement("OP");
                root.Add(new XElement("id", rand.Next(100)));
                root.Add(new XElement("denumire", textBox1.Text));
                root.Add(new XElement("tip", textBox2.Text));
                root.Add(new XElement("adresa", textBox3.Text));
                root.Add(new XElement("cod_postal", textBox4.Text));
                root.Add(new XElement("mail", textBox5.Text));
                doc.Element("oficii_postale").Add(root);
                doc.Save(@"..\..\records.xml");

            }
            this.Close();
        }

        private void FormDBIN_Load(object sender, EventArgs e)
        {

        }
    }
}
