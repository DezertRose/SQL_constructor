using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diplome1.Classes
{
    class MySQL : DB_connector
    {
        static MySqlConnection sqlConnection;
        string db_name;
        public override void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) { sqlConnection.Open(); }
        }

        public override void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) { sqlConnection.Close(); }
        }

        public override int changeConnection(string server, string db, string user, string pass, string port)
        {

            if (sqlConnection != null) { closeConnection(); };
            string sql_connection = "Server="+ server + "; Port="+ port + "; Database="+db+"; Uid="+user+"; Pwd="+pass+";";
            db_name = db;
            try
            {
                sqlConnection = new MySqlConnection(sql_connection);
                sqlConnection.Open();
                return 0;
            }
            catch { System.Windows.Forms.MessageBox.Show("Invalid connection info!"); }

            return 1;
        }

        public override bool stateConnection()
        {
            return sqlConnection.State == System.Data.ConnectionState.Open;
        }

        public override List<List<String>> getData(string command)
        {
            List<List<string>> dataList = new List<List<string>>();
            if (stateConnection())
            {
                MySqlCommand cm = new MySqlCommand(command, sqlConnection);
                MySqlDataReader dr = cm.ExecuteReader();
                if (dr != null)
                {
                    List<string> temp_list = new List<string>();

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
            string command = "select table_name, column_name, DATA_TYPE from information_schema.columns where table_schema = '" + db_name + "' order by TABLE_NAME, COLUMN_NAME";

            dataListNode = getData(command);
            return dataListNode;
        }

        public override List<String> getData_List(string command)
        {
            List<string> dataList = new List<string>();
            if (stateConnection())
            {
                MySqlCommand cm = new MySqlCommand(command, sqlConnection);
                MySqlDataReader dr = cm.ExecuteReader();
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


        public override List<string> getTableName()
        {
            List<string> data_arr = new List<string>();
            data_arr = getData_List("SELECT t.TABLE_NAME as name FROM information_schema.tables t where t.TABLE_SCHEMA = '" + db_name + "'");

            return data_arr;
        }

        public override List<string> getColumn(string table_name)
        {
            List<string> data_arr = new List<string>();
            data_arr = getData_List("select column_name as name from information_schema.columns where table_schema = '"+db_name+"' and table_name = '"
                +table_name+"'order by ordinal_position");

            return data_arr;
        }
    }
}
