using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplome1.Classes
{
    class With_table
    {
        public string TableName { get; set; }
        public List<string> Column_name { get; set; }

        public With_table(string table_name, List<string> column_name) {
            TableName = table_name;
            Column_name = column_name;
        }
    }
}
