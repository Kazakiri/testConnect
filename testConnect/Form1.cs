using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace testConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbHost = "127.0.0.1";//資料庫位址
            string dbUser = "root";//資料庫使用者帳號
            string dbPass = "ganto1184";//資料庫使用者密碼
            string dbName = "stocker";//資料庫名稱
         
            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" +
                dbPass + ";database=" + dbName;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            //建立 DataSet
            DataSet dataSet = new DataSet();

            //使用 MySqlDataAdapter 查詢資料，並將結果存回 DataSet 當做名為 test1 的 DataTable
            string sql = "SELECT * " +
                "FROM collect1\n" +
                "WHERE tdate like '170901%'\n" +
                "ORDER BY serial";
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql, conn);
            dataAdapter1.Fill(dataSet, "test1");

            // test1 的 DataTable
            DataTable dataTable = dataSet.Tables["test1"];

            mysqlGridView1.DataSource = dataSet;
            mysqlGridView1.DataMember = "test1";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT serial, Count(serial) AS serial之筆數 " +
                            "FROM collect1\n"+
                            "WHERE tdate like '170901%'\n" +
                            "GROUP BY serial\n"+
                            "ORDER BY serial";

            DataTable dt = GetOleDbDataTable("pdadata2.mdb", sql);
            MDBGridView2.DataSource = dt;
        }


        private void compareGrid_Click(object sender, EventArgs e)
        {
            string[] mysqlserial = new string[mysqlGridView1.RowCount];
            string[] MDBserial = new string[MDBGridView2.RowCount];
            int i = 0;
            foreach (DataGridViewRow dr in MDBGridView2.Rows)
            {
                string col = Convert.ToString(dr.Cells["serial"].Value);
                MDBserial[i] = col;
                i++;
            }
            
            int y = 0;
            foreach (DataGridViewRow dr in mysqlGridView1.Rows)
            {
                string col = Convert.ToString(dr.Cells["serial"].Value);
                mysqlserial[y] = col;
                y++;
            }
            compareResult.Text = CompareSerial(mysqlserial, MDBserial);
            if (CompareSerial(mysqlserial, MDBserial) == "")
            {
                MessageBox.Show("正常");
            }
        }

        public static string CompareSerial(string[] sql, string[] mdb)
        {
            var intersect = sql.Intersect(mdb);
            var diff = mdb.Except(intersect);
            string test = "";
            foreach (string s in diff)
            {
                test = test + s + "\n";
            }
            return test;
        }

        public static OleDbConnection OleDbOpenConn(string Database)
        {
            string cnstr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Database);
            OleDbConnection icn = new OleDbConnection();
            icn.ConnectionString = cnstr;
            if (icn.State == ConnectionState.Open) icn.Close();
            icn.Open();
            return icn;
        }

        public static DataTable GetOleDbDataTable(string Database, string OleDbString)
        {
            DataTable myDataTable = new DataTable();
            OleDbConnection icn = OleDbOpenConn(Database);
            OleDbDataAdapter da = new OleDbDataAdapter(OleDbString, icn);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            myDataTable = ds.Tables[0];
            if (icn.State == ConnectionState.Open) icn.Close();
            return myDataTable;
        }

        private void MDBGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void compareResult_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
