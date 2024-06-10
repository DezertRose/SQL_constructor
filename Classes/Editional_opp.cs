using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplome1.Classes
{
    class Editional_opp
    {
        public string Function { get; set; }
        public string Field { get; set; }

        public string Table_name { get; set; }
        public bool Is_With { get; set; }

        public string With_Name { get; set; }

        public Editional_opp(string func, string field, string table_name, bool is_with, string with_name) {
            Function = func;
            Field = field;
            Table_name = table_name;
            Is_With = is_with;
            With_Name = with_name;
        }
    }
}
