using Microsoft.Data.SqlClient;
using System.Data;
namespace DMS_quary_data


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //idk
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        private void connect()
        {
            string server = @".\sqlexpress";
            string db = "Minimart";
            string strCon = string.Format(@"Data Source={0};Initial Catalog={1};" + "Integrated Security=True;Encrypt=False", server, db);
            conn =new SqlConnection(strCon);
            conn.Open();
        }

        private void disconnect()
        {
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
            //string sql = "select * from Categories";
            //da = new SqlDataAdapter(sql,conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //
        }

        private void showData()
        {
            string sql = "select * from Categories";
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
