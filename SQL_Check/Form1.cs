
using System.Data;
using System.Data.SqlClient;

namespace SQL_Check
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection("Server=MSI\\SQLEXPRESS; Database=Northwind; Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                lbl_status.Text = "You are disconnected from the server";
                btn_change.Text = "Connect";
            }
            else
            {
                conn.Open();
                lbl_status.Text = "You are connected to the server";
                btn_change.Text = "Disconnect";
            }
        }
    }
}