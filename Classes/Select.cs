using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplome1.Classes
{
    class Select
    {
        public string Table { get; set; }
        public string Function { get; set; }
        public string Field { get; set; }
        public string Field_Name { get; set; }
        public bool Is_With { get; set; }

        public string With_Name { get; set; }

        public Select(string table, string function, string field, string field_name, bool is_with, string with_name)
        {
            Table = table;
            Function = function;
            Field = field;
            Field_Name = field_name;
            Is_With = is_with;
            With_Name = with_name;
        }

        Select change_value(Select data, string function, string field, string field_name, bool is_with)
        {

            if (data.Is_With == Is_With)
            {
                if (data.Field == field)
                {
                    data.Function = function;
                    data.Field_Name = field_name;
                }
            }
            return data;
        }

    }
}
