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
    }
}
