using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplome1.Classes
{
    class Where
    {
        public string Table { get; set; }
        public string Field_1 { get; set; }
        public string Expression { get; set; }
        public string Text { get;  set; }
        public bool Is_With { get; set; }

        public string With_Name { get; set; }

        public Where(string table, string field_1, string expression, string text, bool is_with, string with_name)
        {
            Table = table;
            Field_1 = field_1;
            Expression = expression;
            Text = text;
            Is_With = is_with;
            With_Name = with_name;
        }

        Where change_value(Where data, string field_1, string expression, string text, bool is_with)
        {

            if (data.Is_With == Is_With)
            {
                if (data.Field_1 == field_1)
                {
                    data.Expression = expression;
                    data.Text = text;
                }
            }
            return data;
        }
    }
}
