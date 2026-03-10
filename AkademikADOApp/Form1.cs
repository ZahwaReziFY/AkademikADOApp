using System; //memakai sistem
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data.SqlClient; 

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        //Connection string
        string connString = 
            "Data Source=(local)\\SQLEXPRESS;Initial Catalog=DBAkademikADO;Integrated Security=True";

        //Object SQLconnection
        SqlConnection conn; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                lblStatus.Text = "Status : Database Connected";
                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
