using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProiectEAV
{
    public partial class FormDBIN : Form
    {
        public string TYPE = "";
        Root ListOfOffices;
        public FormDBIN(string TYPE)
        {
            this.TYPE = TYPE;
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
                if (TYPE.Equals("XML"))
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
                else if (TYPE.Equals("JSON"))
                {
                    var rand = new Random();
                    OP obj = new OP();

                    obj.id = rand.Next(100).ToString();
                    obj.denumire = textBox1.Text;
                    obj.tip = textBox2.Text;
                    obj.adresa = textBox3.Text;
                    obj.cod_postal = textBox4.Text;
                    obj.mail = textBox5.Text;

                    StreamReader reader = new StreamReader(@"..\..\records.json");
                    string jsonString = reader.ReadToEnd();
                    ListOfOffices = JsonConvert.DeserializeObject<Root>(jsonString);
                    ListOfOffices.oficii_postale.OP.Add(obj);
                    reader.Close();

                    File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\records.json"), JsonConvert.SerializeObject(ListOfOffices, Formatting.Indented));

                }
                else if (TYPE.Equals("DB"))
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CUHAUG6\SQLEXPRESS;" +
                        "Initial Catalog=PostOficces;Integrated Security=SSPI;");
                    string querry = "INSERT INTO oficii_postale " +
                        "(denumire, tip, adresa, cod_postal," +
                        " mail) " +
                        "values ('" + textBox1.Text +
                        "', '" + textBox2.Text +
                        "', '" + textBox3.Text +
                        "', '" + textBox4.Text +
                        "', '" + textBox5.Text + "');";
                    SqlCommand cmd = new SqlCommand(querry, conn);
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                    cmd.Dispose();
                    conn.Dispose();
                    this.Close();
                }

            }
            MessageBox.Show("Oficiu postal adaugat!");
            this.Close();
        }

        private void FormDBIN_Load(object sender, EventArgs e)
        {

        }
    }
}
