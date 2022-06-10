using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BANDONGHO_TTCS_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String login = "sa";
        public static String password = "123";


        public static String database = "BANDONGHO_TTCS";
        public static String maKH = "";
        public static String hoTen = "";
        public static String SDT = "";
        public static String matKhau = "";
        public static FrmMain frmMain;



        public static int connectToDB()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                // Khoi tao connection string
                connstr = "Data Source= LOCALHOST;Initial Catalog=" + Program.database + ";User ID=" +
                    Program.login + ";Password=" + Program.password + "; MultipleActiveResultSets = true;";
                Program.conn.ConnectionString = connstr;
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối server Connect to database!" + ex.Message);
                return 0;
            }
            return 1;
        }
        public static DataTable ExecSqlDatatable(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int execSqlNonQueryReturnStatus(String cmd)
        {
            SqlDataReader myReader = Program.ExecSqlDataReader(cmd);
            if(myReader == null)
            {
                return -1;
            }
            if (myReader.HasRows)
            {
                myReader.Read();
                return myReader.GetInt32(0);
            }
            else { return -1; }
        }

        public static bool execSqlNonQuery(String cmd)
        {
            SqlCommand sqlCmd = new SqlCommand(cmd, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại!\n" + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

     public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myReader;
            SqlCommand sqlCmd = new SqlCommand(cmd, conn);
            sqlCmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myReader = sqlCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
            return myReader;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            connectToDB();

            frmMain = new FrmMain();
            Application.Run(frmMain);

        }

    }
}
