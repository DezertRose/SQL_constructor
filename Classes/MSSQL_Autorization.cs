using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Diplome1.Classes
{
    class MSSQL_Autorization : DB_connector
    {
        static SqlConnection sqlConnection;
        string tree_dt_connection = "SELECT sc.TABLE_NAME, sc.COLUMN_NAME, sc.DATA_TYPE " +
                "FROM INFORMATION_SCHEMA.COLUMNS sc WHERE TABLE_NAME in (select s.name from SYSOBJECTS s where " +
                "s.xtype = 'U') order by sc.TABLE_NAME, sc.COLUMN_NAME";
        public override void openConnection() {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) { sqlConnection.Open(); }
        }

        public override void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) { sqlConnection.Close(); }
        }

        public override int changeConnection(string server, string db, string user, string pass, string port = "") {
            if (sqlConnection != null) { closeConnection(); };
            try
            {
                string sql_connection = @"Data Source=" + server + ";Initial Catalog=" + db +
                    ";User ID=" + user + ";Password=" + pass + ";";

                sqlConnection = new SqlConnection(sql_connection);
                sqlConnection.Open();
                return 0;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Invalid connection info!");
            }
            return 1;
        }
        public override bool stateConnection() {
            return sqlConnection.State == System.Data.ConnectionState.Open;
        }

        public override List<List<String>> getData(string command)
        {
            List<List<string>> dataList = new List<List<string>>();
            if (stateConnection())
            {
                SqlCommand cm = new SqlCommand(command, sqlConnection);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr != null)
                {
                    List<String> temp_list = new List<string>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        temp_list.Add(dr.GetName(i));
                    }
                    dataList.Add(temp_list);

                    while (dr.Read())
                    {

                        int temp = 0;
                        List<string> help_list = new List<string>();
                        while (dr.FieldCount != temp)
                        {
                            help_list.Add(dr.GetValue(temp).ToString());
                            temp++;
                        }
                        dataList.Add(help_list);
                    }
                }
                dr.Close(); 
            }
            return dataList;
        }


        public override List<List<String>> getDataNode()
        {
            List<List<string>> dataListNode = new List<List<string>>();
            dataListNode = getData("SELECT sc.TABLE_NAME, sc.COLUMN_NAME, sc.DATA_TYPE " +
                "FROM INFORMATION_SCHEMA.COLUMNS sc WHERE TABLE_NAME in (select s.name from SYSOBJECTS s where " +
                "s.xtype = 'U') order by sc.TABLE_NAME, sc.COLUMN_NAME");
            return dataListNode;
        }


        public override List<string> getData_List(string command)
        {
            List<string> dataList = new List<string>();
            if (stateConnection())
            {
                SqlCommand cm = new SqlCommand(command, sqlConnection);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        dataList.Add(dr["name"].ToString());
                    }
                }
                dr.Close();
            }
            return dataList;
        }

        public override List<string> getTableName() {
            List<string> data_arr = new List<string>();
            data_arr = getData_List("select distinct s.name as name from SYSOBJECTS s where s.xtype = 'U' ");

            return data_arr;
        }

        public override List<string> getColumn(string table_name)
        {
            List<string> data_arr = new List<string>();
            data_arr = getData_List("SELECT sc.COLUMN_NAME as name FROM INFORMATION_SCHEMA.COLUMNS sc WHERE TABLE_NAME = '" +
                table_name + "' group by sc.COLUMN_NAME");

            return data_arr;
        }

    }
}
