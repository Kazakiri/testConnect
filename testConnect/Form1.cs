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
using System.IO;

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
            listBox1.DataSource = null;
            getMysql.Enabled = true;

            string dbHost = textIP.Text;//資料庫位址
            string dbUser = textUser.Text;//資料庫使用者帳號
            string dbPass = textPass.Text;//資料庫使用者密碼
            string dbName = textDB.Text;//資料庫名稱

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" +
                dbPass + ";database=" + dbName;
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command;
            MySqlDataAdapter tablesAdapter = new MySqlDataAdapter();
            DataSet tables = new DataSet();
            string sql = "SHOW TABLES FROM stocker";

            //open
            conn.Open();
            command = new MySqlCommand(sql, conn);
            tablesAdapter.SelectCommand = command;
            tablesAdapter.Fill(tables);
            tablesAdapter.Dispose();
            command.Dispose();
            conn.Close();

            listBox1.DisplayMember = "Tables_in_stocker";
            listBox1.ValueMember = "Tables_in_stocker";
            listBox1.DataSource = tables.Tables[0];


        }

        private void getMysql_Click(object sender, EventArgs e)
        {
            mysqlGridView1.DataSource = null;

            string dbHost = textIP.Text;//資料庫位址
            string dbUser = textUser.Text;//資料庫使用者帳號
            string dbPass = textPass.Text;//資料庫使用者密碼
            string dbName = textDB.Text;//資料庫名稱

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" +
                dbPass + ";database=" + dbName;

            string tdate = mysqlTdate.Text; //抓取tdate

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            //建立 DataSet
            DataSet dataSet = new DataSet();

            //使用 MySqlDataAdapter 查詢資料，並將結果存回 DataSet 當做名為 test1 的 DataTable
            string sql = "SELECT * " +
                "FROM " + listBox1.Text + "\n" +
                "WHERE tdate like '" + tdate + "%'\n";
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql, conn);
            dataAdapter1.Fill(dataSet, "test1");

            //關掉
            dataAdapter1.Dispose();
            command.Dispose();
            conn.Close();

            // test1 的 DataTable
            DataTable dataTable = dataSet.Tables["test1"];

            mysqlGridView1.DataSource = dataSet;
            mysqlGridView1.DataMember = "test1";

            mysqlCountLable.Text = "總計:" + Convert.ToString(dataTable.Rows.Count);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MDBGridView2.DataSource = null;

            string tdate = MDBTdate.Text;
            string tables = listBox1.Text;

            OpenFileDialog file = new OpenFileDialog();

            string sql = "SELECT serial " +
                         "FROM " + tables + "\n" +
                         "WHERE tdate like '" + tdate + "%'\n" +
                         "GROUP BY serial\n" +
                         "ORDER BY serial";

            DataTable dt = GetOleDbDataTable("pdadata2.mdb", sql);
            MDBGridView2.DataSource = dt;
            MDBLable.Text = "總計:" + Convert.ToString(dt.Rows.Count);
           

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

        private void chooseMDB_Click(object sender, EventArgs e)
        {

        }

        private void remarkButton_Click(object sender, EventArgs e)
        {
            mysqlGridView1.DataSource = null;

            string dbHost = textIP.Text;//資料庫位址
            string dbUser = textUser.Text;//資料庫使用者帳號
            string dbPass = textPass.Text;//資料庫使用者密碼
            string dbName = textDB.Text;//資料庫名稱

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" +
                dbPass + ";database=" + dbName;

            string tdate = mysqlTdate.Text; //抓取tdate

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            //建立 DataSet
            DataSet dataSet = new DataSet();

            //使用 MySqlDataAdapter 查詢資料，並將結果存回 DataSet 當做名為 test1 的 DataTable
            string sql = "SELECT remark,no,name,lotno,count(remark) as '數量' " +
                "FROM " + listBox1.Text + "\n" +
                "WHERE tdate like '" + tdate + "%'\n" +
                "GROUP BY remark,no";
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql, conn);
            dataAdapter1.Fill(dataSet, "test1");

            //關掉
            dataAdapter1.Dispose();
            command.Dispose();
            conn.Close();

            // test1 的 DataTable
            DataTable dataTable = dataSet.Tables["test1"];

            mysqlGridView1.DataSource = dataSet;
            mysqlGridView1.DataMember = "test1";

            mysqlCountLable.Text = "總計:" + Convert.ToString(dataTable.Rows.Count);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {


            /*                          準備印                                    */
            string path = @"C:\Users\yuchi\Dropbox\BT10\TEST\qrcode.txt";
            string triggerPath = @"C:\Users\yuchi\Dropbox\BT10\TEST.txt";

            try
            {
                //決定qrcode.txt內容

                //客戶編號;客戶名稱 板號;B001/客戶編號:客戶編號
                string qrcode = "";
                qrcode = qrcode + Convert.ToString(mysqlGridView1.Rows[1].Cells[2].Value) + ";" +
                Convert.ToString(mysqlGridView1.Rows[1].Cells[2].Value) +
                Convert.ToString(mysqlGridView1.Rows[1].Cells[3].Value) +
                Convert.ToString(mysqlGridView1.Rows[1].Cells[19].Value) + ";B001/" +
                Convert.ToString(mysqlGridView1.Rows[1].Cells[2].Value) + ":" +
                Convert.ToString(mysqlGridView1.Rows[1].Cells[2].Value);

                int mdateMin = 99999999;
                int mdateMax = 0;
                foreach (DataGridViewRow dr in mysqlGridView1.Rows)
                {
                    qrcode = qrcode + "/" + Convert.ToString(dr.Cells["no"].Value) + ":"
                        + Convert.ToString(dr.Cells["serial"].Value) +
                        ":1:1";
                    if (Convert.ToInt32(dr.Cells["mdate"].Value) < mdateMin)
                    {
                        mdateMin = Convert.ToInt32(dr.Cells["mdate"].Value);
                    }

                    if (Convert.ToInt32(dr.Cells["mdate"].Value) > mdateMax)
                    {
                        mdateMax = Convert.ToInt32(dr.Cells["mdate"].Value);
                    }
                }

                qrcode = qrcode + ";" + Convert.ToString(mdateMin) + "~" + Convert.ToString(mdateMax) + ";1";

                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    // Note that no lock is put on the
                    // file and the possibility exists
                    // that another process could do
                    // something with it between
                    // the calls to Exists and Delete.
                    File.Delete(path);
                }

                // Create the file.

                using (FileStream fs = File.Create(path))
                {
                    // Add some information to the file.
                    StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
                    sw.Write(qrcode, false, Encoding.Unicode);
                    sw.Close();
                    fs.Close();
                }

                // Open the stream and read it back.
                /*using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(s);
                    }
                }*/
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            FileStream fst = File.Create(triggerPath);
            fst.Close();
        }



        private void selectRemarkButton_Click(object sender, EventArgs e)
        {
            mysqlGridView1.DataSource = null;

            string dbHost = textIP.Text;//資料庫位址
            string dbUser = textUser.Text;//資料庫使用者帳號
            string dbPass = textPass.Text;//資料庫使用者密碼
            string dbName = textDB.Text;//資料庫名稱

            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" +
                dbPass + ";database=" + dbName;

            string tdate = mysqlTdate.Text; //抓取tdate

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();

            //建立 DataSet
            DataSet dataSet = new DataSet();

            //使用 MySqlDataAdapter 查詢資料，並將結果存回 DataSet 當做名為 test1 的 DataTable
            string sql = "SELECT * " +
                "FROM " + listBox1.Text + "\n" +
                "WHERE remark = '" + remarkText.Text + "'\n" +
                "AND tdate like '" + tdate + "%'\n";
            MySqlDataAdapter dataAdapter1 = new MySqlDataAdapter(sql, conn);
            dataAdapter1.Fill(dataSet, "test1");

            //關掉
            dataAdapter1.Dispose();
            command.Dispose();
            conn.Close();

            // test1 的 DataTable
            DataTable dataTable = dataSet.Tables["test1"];

            mysqlGridView1.DataSource = dataSet;
            mysqlGridView1.DataMember = "test1";

            mysqlCountLable.Text = "總計:" + Convert.ToString(dataTable.Rows.Count);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(mysqlGridView1.Rows[0].Cells[1].Value));
        }
    }
}
