using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplome1.Classes
{
    public abstract class DB_connector
    {
        public abstract void openConnection();

        public abstract void closeConnection();
        public abstract int changeConnection(string server, string db, string user = "", string pass = "", string port = "");

        public abstract bool stateConnection();

        public abstract List<List<String>> getData(string command);

        public abstract List<String> getData_List(string command);

        public abstract List<String> getTableName();

        public abstract List<string> getColumn(string table_name);

        public abstract List<List<String>> getDataNode();


    }
}
