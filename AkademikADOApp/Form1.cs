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
    public partial class Form1 : Form //feat: create Form1 class for main form
    {
        //Connection string
        string connString = //feat: add SQL Server connection string
            "Data Source=(local)\\SQLEXPRESS;Initial Catalog=DBAkademikADO;Integrated Security=True"; //memasukan sql server

        //Object SQLconnection
        SqlConnection conn; // mengoneksikan sql
        public Form1()
        {
            InitializeComponent(); //feat: initialize Form1 constructor
        }

        private void button1_Click(object sender, EventArgs e) //feat: add button1 click event handler
        {
            try
            {
                conn = new SqlConnection(connString); //feat: create SqlConnection instance
                conn.Open();
                lblStatus.Text = "Status : Database Connected"; //membuat status database terkoneksi
                MessageBox.Show("Koneksi ke database berhasil!"); //membuat pesan koneksi ke database berhasil
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
