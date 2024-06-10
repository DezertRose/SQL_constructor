using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplome1.Classes
{
    class Join
    {
        public string Which_Join { get; set; }
        public string Table_1 { get; set; }
        public string Table_2 { get; set; }
        public string Field_1 { get; set; }
        public string Field_2 { get; set; }
        public bool Is_With { get; set; }

        public string With_Name { get; set; }

        public Join(string which_join, string table_1, string table_2, string field_1, string field_2, bool is_with, string with_name)
        {
            Which_Join = which_join;
            Table_1 = table_1;
            Table_2 = table_2;
            Field_1 = field_1;
            Field_2 = field_2;
            Is_With = is_with;
            With_Name = with_name;
        }

        public Join change_value(Join data, Join data2)
        {

            if (data.Is_With == data2.Is_With)
            {
                if ((data.Table_1 == data2.Table_1 && data.Table_2 == data2.Table_2) || (data.Table_1 == data2.Table_2 && data.Table_2 == data2.Table_1))
                {
                    data.Field_1 = data2.Field_1;
                    data.Field_2 = data2.Field_2;
                    data.Which_Join = data2.Which_Join;
                }
            }
            return data;
        }

    }
}
