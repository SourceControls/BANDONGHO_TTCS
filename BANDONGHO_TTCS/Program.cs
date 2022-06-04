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
        public static String login = "";
        public static String password = "";

        public static String database = "BANDONGHO_TTCS";
        public static String mGroup = "";
        public static String mHoTen = "";

        public static frmLogin fLogin;



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
                    mHoTen =  myReader.GetString(1);
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
        public static bool execSqlNonQuery(String cmd)
        {
            SqlCommand sqlCmd = new SqlCommand(cmd, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại!\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
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
                Application.Run(Program.fLogin);
        }

    }
}
