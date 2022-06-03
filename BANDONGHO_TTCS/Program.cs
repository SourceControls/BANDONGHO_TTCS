﻿using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static SqlDataReader myReader;
        public static String login = "";
        public static String password = "";

        public static String database = "BANDONGHO_TTCS";
        public static String mGroup = "";
        public static String mHoTen = "";

        public static FrmMain fMain;
        public static frmLogin fLogin;

        public static string URLBackup = "D:\\Learn\\Ky_2_Nam3\\TTCS\\backup_BANDONGHO";
        public static string fullBKfileName = "full_bk.bak";
        public static string diffBKfileName = "diff_bk.bak";
        public static string logBKfileName = "log_bk.trn";

        public static void closeConnection()
        {
            if(!execSqlNonQuery(
                "alter database BANDONGHO_TTCS set single_user with rollback immediate") ||
                !execSqlNonQuery(
                "alter database BANDONGHO_TTCS set multi_user"))
            {
                return;
            }
        }

        public static int connectToMaster()
        {
            database = "master";
            int res = connectToDB();
            database = "BANDONGHO_TTCS";
            return res;
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
                connstr = "Data Source= DESKTOP-OJUM6M0;Initial Catalog=" + Program.database + ";User ID=" +
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
                if(sqlCmd.ExecuteNonQuery() == 1)
                {
                    throw new Exception("Has error");
                }
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

        public static int ExecSqlNonQuery(String cmd)
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
                return 1;
            }
            finally
            {
                conn.Close();
            }
            return 0;
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
            fLogin = new frmLogin();
            fMain = new FrmMain();
            Program.fLogin.ShowDialog(fMain);
            if(login.Length>0)
            Application.Run(Program.fMain);
        }

    }
}
