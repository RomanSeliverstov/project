using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace furniture
{
    class WorkWithBase
    {
        private MySqlConnectionStringBuilder mysqlCS;
        private DataTable DataTable;
        private MySqlCommand command;
        private MySqlConnection con;
        private MySqlDataReader dr;
        
        private MySqlConnectionStringBuilder connectToBase()
        {
            string connectionString = "Server=127.0.0.1;Database=furniture;Uid=root;CharSet=utf8";
            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder(connectionString);
            return mysqlCSB;

        }
        public DataTable GetComments(string queryString)
        {
           DataTable = new DataTable();
           mysqlCS = connectToBase();

                using (con = new MySqlConnection())
            {
               
               con.ConnectionString = mysqlCS.ConnectionString;
               command = new MySqlCommand(queryString, con);

                try
                {
                    con.Open();

                    using (dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            DataTable.Load(dr);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return DataTable;
        }


        public void InsertIntoTable()
        {
            DataTable = new DataTable();
            mysqlCS = connectToBase();
            string queryString = @"";

            using (con = new MySqlConnection())
            {

                con.ConnectionString = mysqlCS.ConnectionString;
                command = new MySqlCommand(queryString, con);
                MySqlDataReader MyReader2;
                con.Open();
                MyReader2 = command.ExecuteReader();
                con.Close();
             }

        }
        public void UpdateTable() {  }
        public void ImportData() {
            string constring = "server=localhost;user=root;pwd=qwerty;database=test;";
            string file = "C:\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        
        
        
        }
        public void ExportData() {
            string constring = "server=localhost;user=root;pwd=;database=furniture;";
            string file = "sqlbackup.sql";
            using (con = new MySqlConnection(constring))
            {
                using (command = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(command))
                    {
                        command.Connection = con;
                        con.Open();
                        mb.ExportToFile(file);
                        con.Close();
                    }
                }
            }
        
        }

    }
}
