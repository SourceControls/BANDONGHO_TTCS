using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BANDONGHO_TTCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String login = "";
        public static String password = "";

        public static String database = "BANDONGHO_TTCS";
        public static String mGroup = "";
        public static String mHoTen = "";
        public static SqlDataReader myReader;
        public static FrmLogin fLogin;

        // Đường dẫn tới thư mục project
        public static string URL_BACKUP = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + 
            "\\backup\\";
        public static string FULL_BK_FILE_NAME = "full_bk.bak";
        public static string DIFF_BK_FILE_NAME = "diff_bk.bak";
        public static string LOG_BK_FILE_NAME = "log_bk.trn";

        private static string cmdSingleUser = "ALTER DATABASE BANDONGHO_TTCS SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
        private static string cmdMultiUser = "ALTER DATABASE BANDONGHO_TTCS SET MULTI_USER";

        public static void closeConnection()
        {
            if(!ExecSqlNonQuery(cmdSingleUser) || !ExecSqlNonQuery(cmdMultiUser))
            {
                return;
            }
        }

        public static void setSingleUser()
        {
            ExecSqlNonQuery(cmdSingleUser);
        }

        public static void setMultiUser()
        {
            ExecSqlNonQuery(cmdMultiUser);
        }

        public static int connectToMaster()
        {
            database = "master";
            int res = connectToDBMaster();
            database = "BANDONGHO_TTCS";
            return res;
        }

        public static int connectToDBMaster()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                // Khoi tao connection string
                connstr = "Data Source= MYLAPTOP;Initial Catalog=" + Program.database + ";User ID=" +
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
        public static int connectToDB()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            try
            {
                // Khoi tao connection string
                connstr = "Data Source= MYLAPTOP;Initial Catalog=" + Program.database + ";User ID=" +
                    Program.login + ";Password=" + Program.password + "; MultipleActiveResultSets = true;";
                Program.conn.ConnectionString = connstr;
                conn.Open();
                SqlDataReader myReader = Program.ExecSqlDataReader("EXEC SP_LAY_HO_TEN_VA_GROUP '" + login + "'");
                if (myReader == null)
                {
                    return -1;
                }
                else if (myReader.HasRows)
                {
                    myReader.Read();
                    mGroup = myReader.GetString(0);
                    mHoTen = myReader.GetString(1);
                }
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
        public static void excuteCommandBKAndRestore(string cmd)
        {
            SqlCommand sqlCmd = new SqlCommand(cmd, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thực thi sql non query, chi tiết: " + ex.Message);
            }
            finally
            {
                Program.conn.Close();
            }
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

        public static bool ExecSqlNonQuery(String cmd)
        {
            SqlCommand sqlCmd = new SqlCommand(cmd, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                if (sqlCmd.ExecuteNonQuery() == 1)
                    throw new Exception("Has error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi sql non query, chi tiết: " + ex.Message);
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
            fLogin = new FrmLogin();
                Application.Run(Program.fLogin);
        }

    }
}
