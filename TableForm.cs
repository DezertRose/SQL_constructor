using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Diplome1.Classes;

namespace Diplome1
{
    public partial class TableForm : Form
    {
        string[] functions_arr = { "SUM", "AVG", "MAX", "MIN", "COUNT", "EMPTY"};
        string[] condition_arr = { ">", "<", ">=", "<=", "=", "!=" };
        string[] poss_arr = { "order by", "group by" };
        string[] join_arr = { "join", "left join", "right join", "full join"};

        bool is_with_value = false;
        string with_name;
        List<With_table> with_name_list = new List<With_table>();
        List<string> column_name = new List<string>();
        List<string> column_name_temp = new List<string>();

        List<Select> select_list = new List<Select>();
        List<Join> join_list_2 = new List<Join>();
        List<Where> where_list = new List<Where>();
        List<Editional_opp> edd_list = new List<Editional_opp>();

        List<string> group_arr = new List<string>();
        List<string> order_arr = new List<string>();

        string table_dt;
        List<string> first_tb_name = new List<string>();
        string temp_res_field_box;

        public TableForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            insertTree();
            fillConBox();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        void fill_extra_fields() {
            function_comboBox.ValueMember = "Functions";
            function_comboBox.DataSource = functions_arr;

            con_comboBox.ValueMember = "Condition";
            con_comboBox.DataSource = condition_arr;

            add_oport_comboBox1.ValueMember = "Querry poss";
            add_oport_comboBox1.DataSource = poss_arr;

            withc_join_comboBox1.ValueMember = "Join";
            withc_join_comboBox1.DataSource = join_arr;
        }

        void fillFieldConBox(string table_name) {
            if (table_name_comboBox1.Text != null)
            {
                bool is_with_table = false;
                List<String> data_arr = new List<string>();
                foreach (With_table el in with_name_list) {
                    if (table_name == el.TableName) {
                        foreach (string help in el.Column_name) {
                            data_arr.Add(help);
                            is_with_table = true;
                        }

                    }
                }
                if (!is_with_table) { data_arr = LoginForm.data_base.getColumn(table_name); }                             
                field_comboBox.ValueMember = "Field";              
                field_comboBox.DataSource = data_arr;
                
                temp_res_field_box = data_arr[0];
                table_dt = table_name;

                List<String> help_data_arr = new List<string>();
                help_data_arr = data_arr.ToList();
                field_con_comboBox.ValueMember = "Field Condition";
                field_con_comboBox.DataSource = help_data_arr;

                List<String> help_data_arr_temp = new List<string>();
                help_data_arr_temp = help_data_arr.ToList();
                opportunity_field_comboBox1.ValueMember = "Opportunity";
                opportunity_field_comboBox1.DataSource = help_data_arr;
            }
        }

        void fillJoinField(string table_name, string table_name2) {
            List<String> first_table = new List<string>();
            List<String> sec_table = new List<string>();

            first_table = LoginForm.data_base.getColumn(table_name);
            sec_table = LoginForm.data_base.getColumn(table_name2);

            join_field_comboBox1.ValueMember = "first_table_field";
            join_sec_field_comboBox1.ValueMember = "sec_table_field";

            join_field_comboBox1.DataSource = first_table;
            join_sec_field_comboBox1.DataSource = sec_table;

        }

        void fillConBox() {
            List<string> data_arr = new List<string>();
            data_arr = LoginForm.data_base.getTableName();
            table_name_comboBox1.ValueMember = "Table";
            // if (with_name != "") { data_arr.Add(with_name); }
            table_name_comboBox1.DataSource = data_arr;

            List<string> help_arr = new List<string>();
            help_arr = data_arr.ToList();
            List<string> help_arr_two = new List<string>();
            help_arr_two = data_arr.ToList();
            // help_arr.RemoveAt(0);


            first_table_comboBox1.ValueMember = "First Join Table";
            first_table_comboBox1.DataSource = help_arr_two;         

            sec_table_comboBox1.ValueMember = "Second Join Table";
            sec_table_comboBox1.DataSource = help_arr;

            fillFieldConBox(data_arr[0]);
            fillJoinField(help_arr_two[0], help_arr[0]);
            fill_extra_fields();
        }

        void insertTree()
        {
            List<List<string>> tree_data = new List<List<string>>();
            DataTable tree_dt = new DataTable();

            tree_data = LoginForm.data_base.getDataNode();


            tree_data[0].ForEach(colname => tree_dt.Columns.Add(colname));
            foreach (List<string> row in tree_data.Skip(1))
            {   
                tree_dt.Rows.Add(row.ToArray());
            }


            for(int i = 0; i<tree_dt.Rows.Count; i++ )
            {
                TreeNode parentNode = new TreeNode(tree_dt.Rows[i][tree_data[0][0]].ToString());
                while (i + 1 < tree_dt.Rows.Count && (tree_dt.Rows[i][tree_data[0][0]].ToString() == tree_dt.Rows[i + 1][tree_data[0][0]].ToString()))
                {
                    TreeNode childNode = new TreeNode(tree_dt.Rows[i+1][tree_data[0][1]].ToString());
                    childNode.Nodes.Add(tree_dt.Rows[i + 1][tree_data[0][2]].ToString());
                    i++;
                    parentNode.Nodes.Add(childNode);
                }                               
                table_treeView.Nodes.Add(parentNode);
            }

        }
    
        private void TableForm_Load(object sender, EventArgs e)
        {
            
        }

        void insertGrid(string command)
        {
            List<List<string>> data_str = new List<List<string>>();
            DataTable resDT = new DataTable();
            data_str = LoginForm.data_base.getData(command);
            // data_str = LoginForm.data_base.getData("select * from dwh_repo.dim_country");
            data_str[0].ForEach(colname => resDT.Columns.Add(colname));
            foreach (List<string> row in data_str.Skip(1))
            {
                resDT.Rows.Add(row.ToArray());
            }


            fill_dataGridView.DataSource = resDT;
        }

        /*private void table_name_comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (table_name_comboBox1.SelectedValue != null)
            {

                fillFieldConBox(table_name_comboBox1.SelectedValue.ToString());
                /*
                List<String> data_arr = new List<string>();
                data_arr = LoginForm.data_base.getColumn(table_name_comboBox1.SelectedValue.ToString());
                field_comboBox.ValueMember = "Field";
                field_comboBox.DataSource = data_arr;


                List<String> help_data_arr = new List<string>();
                help_data_arr = LoginForm.data_base.getColumn(table_name_comboBox1.SelectedValue.ToString());
                field_con_comboBox.ValueMember = "Field Condition";
                field_con_comboBox.DataSource = help_data_arr;


                List<String> help_data_arr_temp = new List<string>();
                help_data_arr_temp = LoginForm.data_base.getColumn(table_name_comboBox1.SelectedValue.ToString());
                opport_field_comboBox1.ValueMember = "Opport_Condition";
                opport_field_comboBox1.DataSource = help_data_arr_temp;
            }
        }*/

        private void add_button_Click(object sender, EventArgs e)
        {
            string table_name_temp = table_dt;
            string field_temp = "";
            string function_temp = functions_arr[0];
            string field_name = "";
            string with_name_temp = "";

            if (table_name_comboBox1.SelectedValue != null) {
                table_name_temp = table_name_comboBox1.SelectedValue.ToString();
            }
            if (field_comboBox.SelectedValue != null)
            {
                field_temp = field_comboBox.SelectedValue.ToString();
            }
            else {
                List<String> help_data_arr = new List<string>();
                help_data_arr = LoginForm.data_base.getColumn(table_name_temp);
                field_temp = help_data_arr[0];
            }
            if (function_comboBox.SelectedValue != null) {
                function_temp = function_comboBox.SelectedValue.ToString();
            }
            
            first_tb_name.Add(table_name_temp);

            if (fiel_name_textBox1.Text != "")
            {
                field_name = fiel_name_textBox1.Text;
            }
            else { field_name = table_name_temp + "_" + field_temp; }

            if (with_name != "" && is_with_value) {
                bool is_field = false;

                if (with_name_list?.Count > 0)
                {
                    foreach (With_table el in with_name_list)
                    {
                        if (el.TableName == with_name)
                        {
                            el.Column_name.Add(field_name);
                            is_field = true;
                        }
                    }
                    if (!is_field)
                    {
                        List<string> help = new List<string>();
                        help.Add(field_name);
                        With_table temp = new With_table(with_name, help);
                        with_name_list.Add(temp);
                    }
                }
                else
                {
                    List<string> help = new List<string>();
                    help.Add(field_name);
                    With_table temp = new With_table(with_name, help);
                    with_name_list.Add(temp);
                }

                column_name_temp.Add(field_name);
                with_name_temp = with_name;
            }       

            Select select_temp = new Select(table_name_temp, function_temp, field_temp, field_name, is_with_value, with_name_temp);

            bool is_insert_row = false;
            
            if (select_list?.Count > 0) {
                foreach (Select el in select_list.ToList()) {
                    if (el.Is_With == select_temp.Is_With && el.With_Name == with_name_temp) {
                        if (el.Field == select_temp.Field && el.Table == select_temp.Table) {
                            el.Function = select_temp.Function;
                            el.Field_Name = select_temp.Field_Name;
                            el.Field = select_temp.Field;
                            is_insert_row = true;
                        }
                    }
                }
                if (!is_insert_row)
                {
                    select_list.Add(select_temp);
                }
            }
            else
            {
                select_list.Add(select_temp);
            }

            show_res();

        }

        private void add_con_button1_Click(object sender, EventArgs e)
        {
            string temp_table = table_dt;
            bool is_insert = false;
            string with_name_temp = "";

            if (table_name_comboBox1.SelectedValue.ToString() != null) {
                temp_table = table_name_comboBox1.SelectedValue.ToString();
            }
            string temp_res_con_field = functions_arr[0];
            if (field_con_comboBox.SelectedValue != null)
            {
                temp_res_con_field = field_con_comboBox.SelectedValue.ToString();
            }

            string temp_res_con_box = condition_arr[0];
            if (con_comboBox.SelectedValue != null)
            {
                temp_res_con_box = con_comboBox.SelectedValue.ToString();
            }

            if (with_name != "" && is_with_value) { with_name_temp = with_name;}

            if (exp_con_textBox.Text != null)
            {
                Where where_temp = new Where(temp_table, temp_res_con_field, temp_res_con_box, exp_con_textBox.Text, is_with_value, with_name_temp);

                if (where_list?.Count > 0)
                {
                    foreach (Where el in where_list)
                    {
                        if (el.Is_With == where_temp.Is_With && with_name_temp == el.With_Name)
                        {
                            if (el.Table == where_temp.Table && el.Field_1 == where_temp.Field_1)
                            {
                                el.Expression = where_temp.Expression;
                                el.Text = where_temp.Text;
                                is_insert = true;
                            }
                        }


                    }
                    if (!is_insert)
                    {
                        where_list.Add(where_temp);
                    }
                }
                else { where_list.Add(where_temp); }
            }
            else { MessageBox.Show("Fill data into Expression field!"); }
            show_res();
        }

        string get_line_with(List<Select> temp_arr_select, List<Where> where_arr_temp, List<Join> join_arr_temp, List<Editional_opp> opp_arr_temp, string table_name, string with_name)
        {
            string command = "";

            for (int i = 0; i < temp_arr_select.Count(); i++)
            {
                string help = "";
                if (with_name == temp_arr_select[i].With_Name)
                {

                    if (temp_arr_select[i].Function == "EMPTY")
                    {
                        help += temp_arr_select[i].Table + "." + temp_arr_select[i].Field + " as " + temp_arr_select[i].Field_Name;
                    }
                    else
                    {
                        help += temp_arr_select[i].Function + "(" + temp_arr_select[i].Table + "." + temp_arr_select[i].Field + ") as " + temp_arr_select[i].Function + "_" + temp_arr_select[i].Field_Name;
                    }
                    if (i + 1 == temp_arr_select.Count()) { help += " from " + table_name + " "; }
                    else { help += ", "; }
                    command += help;
                }
            }         

            if (join_arr_temp?.Count > 0)
            {
                foreach (Join jn in join_arr_temp)
                {
                    string help = "";
                    if (with_name == jn.With_Name && jn.Is_With)
                    {
                        help += jn.Which_Join + " " + jn.Table_2 + " on " + jn.Table_2 + "." + jn.Field_2 + "=" + jn.Table_1 + "." + jn.Field_1 + " ";
                    }
                    command += help;
                }
            }

            if (where_arr_temp?.Count > 0)
            {

                string help = "";
                for (int i = 0; i < where_arr_temp.Count(); i++)
                {
                    
                    if (where_arr_temp[0].With_Name == with_name && where_arr_temp[0].Is_With)
                    {
                        double retNum;
                        help += where_arr_temp[i].Table + "." + where_arr_temp[i].Field_1 + " " + where_arr_temp[i].Expression;
                        if (Double.TryParse(Convert.ToString(where_arr_temp[i].Text), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum))
                        {
                            help += " " + where_arr_temp[i].Text + " ";
                        }
                        else {
                            help += " '" + where_arr_temp[i].Text + "' ";
                        }
                        if (i + 1 != where_arr_temp.Count()) { help += "and "; }
                    }
                }
                command += " where " + help;
            }

            string order = "";
            string group = "";

            if (opp_arr_temp?.Count > 0)
            {
                foreach (Editional_opp el in opp_arr_temp)
                {
                    if (el.Function == "group by" && el.With_Name == with_name)
                    {
                        group += " " + el.Table_name + "." + el.Field + ", ";
                    }
                    else { 
                        if(el.Function == "order by" && el.With_Name == with_name)
                        {
                            order += " " + el.Table_name + "." + el.Field + ", ";
                        }

                    }
                }
            }
            if (group != "") { command += " group by " + group.Remove(group.Length-2); }
            if (order != "") { command += " order by " + order.Remove(order.Length - 2); }
            return command;
        }

        string get_line(List<Select> temp_arr, string table_name) {
            string command = "";
            for (int i = 0; i < temp_arr.Count(); i++)
            {
                string help = "";

                if (temp_arr[i].Function == "EMPTY")
                {
                    help += temp_arr[i].Table + "." + temp_arr[i].Field + " as " + temp_arr[i].Field_Name;
                }
                else
                {
                    help += temp_arr[i].Function + "(" + temp_arr[i].Table + "." + temp_arr[i].Field + ") as " + temp_arr[i].Function + "_" + temp_arr[i].Field_Name;
                }


                if (i + 1 == temp_arr.Count()) { help += " from " + table_name + " "; }

                else { help += ", "; }
                command += help;
            }
            return command;
        }

        string show_res()
        {
            string command = "";
            string with_command = "";
            
            if (table_name_comboBox1.SelectedValue.ToString() != null) { table_dt = table_name_comboBox1.SelectedValue.ToString(); }

            if (select_list?.Count > 0)
            {
                List<Select> temp_list_with = new List<Select>();

                foreach (Select el in select_list) {
                    if (el.Is_With)
                    {
                        temp_list_with.Add(el);
                    }
                }
                if (temp_list_with?.Count > 0)
                {
                    string temp = "";
                    string first_table = temp_list_with[0].Table;
                    int count = 0;
                    string is_with = "";
                    foreach (Select el in temp_list_with.OrderBy(o => o.With_Name).ToList()) {
                        count++;
                        if (el.With_Name != temp) {
                            if (count != 1) { is_with += "), "; }
                            is_with += " " + el.With_Name + " as (select ";
                            temp = el.With_Name;
                            first_table = el.Table;
                            is_with += get_line_with(temp_list_with.Where(o=> o.With_Name == temp).ToList(), where_list.Where(w => w.Is_With).ToList(), join_list_2.Where(j => j.Is_With).ToList(), edd_list.Where(e=>e.Is_With).ToList(), first_table, temp);
                            
                        }
                    }
                    if (is_with != "") { with_command += "with " + is_with + " ) "; }
                }


                List<Select> temp_list = new List<Select>();
                foreach (Select el in select_list)
                {
                    if (!el.Is_With)
                    {
                        temp_list.Add(el);
                    }
                }
                if (temp_list?.Count > 0)
                {
                    command = "select "+get_line(temp_list, temp_list[0].Table);
                }

                if (join_list_2?.Count > 0)
                {

                    foreach (Join jn in join_list_2)
                    {
                        string help = "";
                        if (!jn.Is_With) {
                            help += jn.Which_Join + " " + jn.Table_2 + " on " + jn.Table_2 + "." + jn.Field_2 + "=" + jn.Table_1 + "." + jn.Field_1 + " ";
                            command += help;
                        }
                    }
                }
            }
            else
            {
                command = "select * from" + table_dt;
            }

            if (where_list?.Count > 0)
            {
               
                string help = "";
                for (int i = 0; i < where_list.Count(); i++)
                {

                    if (!where_list[i].Is_With)
                    {
                        double retNum;
                        DateTime dt;
                        help += where_list[i].Table + "." + where_list[i].Field_1 + " " + where_list[i].Expression;
                        if (Double.TryParse(Convert.ToString(where_list[i].Text), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum))
                        {
                            help += " " + where_list[i].Text + " ";
                        }
                        else
                        {
                            /*if (DateTime.TryParse(where_list[i].Text, out dt))
                            {
                                help += " date'" + where_list[i].Text + "' ";
                            }
                            else {*/
                                help += " '" + where_list[i].Text + "' ";
                           // }
                        }
                        if (i + 1 != where_list.Count()) { help += "and "; }
                    }
                }
                if (help != "") { command += " where " + help; }
            }
            

            if (edd_list?.Count > 0)
            {
                string order = "";
                string group = "";
                foreach (Editional_opp el in edd_list.Where(e=> !e.Is_With))
                {
                        if (el.Function == "group by")
                        {
                            group += " " + el.Table_name + "." + el.Field + ", ";
                        }
                        else
                        {
                            if (el.Function == "order by")
                            {

                                order += " " + el.Table_name + "." + el.Field + ", ";
                            }

                        }
                }
                
                if (group != "") { command += " group by " + group.Remove(group.Length - 1); }
                if (order != "") { command += " order by " + order.Remove(group.Length - 1); }
                
            }

            string db_command = with_command + command;
            Out_textBox1.Text = db_command;
            return db_command;
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            try
            {
                insertGrid(show_res());
            }
            catch {
                MessageBox.Show("Упс!Щось пішло не так!");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exp_file_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"D:\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "Data" + rnd.Next() + ".csv";
            sfd.DefaultExt = "csv";
            sfd.Filter = "csv files (.csv) | *.csv";

            String file = @"D:\Data"+ rnd.Next() + ".csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();

            string connection = Out_textBox1.Text;

            List<List<string>> data_str = new List<List<string>>();
            DataTable resDT = new DataTable();

            data_str = LoginForm.data_base.getData(connection);
            
            data_str[0].ForEach(colname => resDT.Columns.Add(colname));

            output.AppendLine(string.Join(separator, data_str[0]));

            foreach (List<string> row in data_str.Skip(1)) 
            {

                resDT.Rows.Add(row.ToArray());
                output.AppendLine(string.Join(separator, row));
            }

            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Stream sfd_file = sfd.OpenFile();
                    StreamWriter sw = new StreamWriter(sfd_file, Encoding.GetEncoding(1251));
                    foreach (List<string> el in data_str.Skip(1))
                    {
                        sw.WriteLine(string.Join(separator, el));
                    }
                    sw.Close();
                    sfd_file.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Не можу записати до данного csv файлу.");
                return;
            }

        }

        void clear_all() {
            select_list.Clear();
            where_list.Clear();
            join_list_2.Clear();
            group_arr.Clear();
            order_arr.Clear();

            Out_textBox1.Text = "";
            fiel_name_textBox1.Text = "";
            with_name_textBox1.Text = "";
            exp_con_textBox.Text = "";

            fill_dataGridView.DataSource = null;
            fillConBox();

        }

        private void clear_button1_Click(object sender, EventArgs e)
        {
            clear_all();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_all();
            LoginForm loginForm = new LoginForm();
            Hide();
            loginForm.ShowDialog();
            Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opportunity_field_comboBox1.SelectedValue.ToString() != null)
            {
                string help = "";
                if (with_name != "" && is_with_value) { help = with_name; }
                if (add_oport_comboBox1.SelectedValue.ToString() == "order by")
                {
                    Editional_opp temp = new Editional_opp("order by", opportunity_field_comboBox1.SelectedValue.ToString(), table_name_comboBox1.SelectedValue.ToString(), is_with_value, help);
                    edd_list.Add(temp);
                }
                else
                {
                    if (add_oport_comboBox1.SelectedValue.ToString() == "group by")
                    {
                        Editional_opp temp = new Editional_opp("group by", opportunity_field_comboBox1.SelectedValue.ToString(), table_name_comboBox1.SelectedValue.ToString(), is_with_value, help);
                        edd_list.Add(temp);
                    }

                }
            }
            show_res();
        }

        private void field_con_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_oport_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void function_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void first_table_comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_table_comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (first_table_comboBox1.SelectedValue != null)
            {
                List<String> data_arr = new List<string>();
                data_arr = LoginForm.data_base.getColumn(first_table_comboBox1.SelectedValue.ToString());
                join_field_comboBox1.ValueMember = "first_table_field";
                if (column_name?.Count > 0){
                    foreach (String el in column_name) { data_arr.Add(el); }
                }
                join_field_comboBox1.DataSource = data_arr;
                
            }
        }

        private void sec_table_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sec_table_comboBox1.SelectedValue != null)
            {
                List<String> help_data_arr = new List<string>();
                help_data_arr = LoginForm.data_base.getColumn(sec_table_comboBox1.SelectedValue.ToString());
                join_sec_field_comboBox1.ValueMember = "sec_table_field";
                if (column_name?.Count >0)
                {
                    foreach (String el in column_name) { help_data_arr.Add(el); }
                }
                join_sec_field_comboBox1.DataSource = help_data_arr;
            }
        }

        private void join_button2_Click(object sender, EventArgs e)
        {

            if (join_field_comboBox1.SelectedValue != null && sec_table_comboBox1.SelectedValue != null && first_table_comboBox1.SelectedValue != null && sec_table_comboBox1.SelectedValue != null)
            {
                string temp_join;
                string temp_table_1;
                string temp_table_2;
                string temp_field_1;
                string temp_field_2;
                string with_name_temp = "";
                
                if (withc_join_comboBox1.SelectedValue != null) {
                    temp_join = withc_join_comboBox1.SelectedValue.ToString();
                }
                else { temp_join = join_arr[0]; }
                if (first_table_comboBox1.SelectedValue != null)
                {
                    temp_table_1 = first_table_comboBox1.SelectedValue.ToString();
                }
                else { temp_table_1 = table_dt; }
                if (sec_table_comboBox1.SelectedValue != null)
                {
                    temp_table_2 = sec_table_comboBox1.SelectedValue.ToString();
                }
                else { temp_table_2 = table_dt; }
                if (join_field_comboBox1.SelectedValue != null)
                {
                    temp_field_1 = join_field_comboBox1.SelectedValue.ToString();
                }
                else {
                    List<string> help_arr = new List<string>();
                    help_arr = LoginForm.data_base.getColumn(temp_table_1);
                    temp_field_1 = help_arr[0]; }
                if (join_sec_field_comboBox1.SelectedValue != null)
                {
                    temp_field_2 = join_sec_field_comboBox1.SelectedValue.ToString();
                }
                else {
                    List<string> help_arr = new List<string>();
                    help_arr = LoginForm.data_base.getColumn(temp_table_2);
                    temp_field_2 = help_arr[0];
                }
                if (is_with_value) { with_name_temp = with_name; }

                Join temp_join_obj = new Join(temp_join, temp_table_1, temp_table_2, temp_field_1, temp_field_2, is_with_value, with_name_temp);

                bool is_insert_row = false;

                if (join_list_2?.Count > 0)
                {

                    foreach (Join el in join_list_2.ToList()) {
                        if (el.Is_With == temp_join_obj.Is_With && el.With_Name == temp_join_obj.With_Name) {
                            if ((el.Table_1 == temp_join_obj.Table_1 && el.Table_2 == temp_join_obj.Table_2) || (el.Table_1 == temp_join_obj.Table_2 && el.Table_2 == temp_join_obj.Table_1))
                            {
                                el.Field_1 = temp_join_obj.Field_1;
                                el.Field_2 = temp_join_obj.Field_2;
                                el.Which_Join = temp_join_obj.Which_Join;
                                is_insert_row = true;
                            }
                        }
                        
                    }
                    if (!is_insert_row)
                    {
                        join_list_2.Add(temp_join_obj);
                    }
                }
                else {
                    join_list_2.Add(temp_join_obj);
                }
                show_res();
            }
            else { MessageBox.Show("Field the fiels!"); }
        }

        private void fill_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void table_name_comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (table_name_comboBox1.SelectedValue != null)
            {
                fillFieldConBox(table_name_comboBox1.SelectedValue.ToString());
            }
        }

        private void start_with_button2_Click(object sender, EventArgs e)
        {
            is_with_value = true;
            if (with_name_textBox1.Text != null)
            {
                with_name = with_name_textBox1.Text;

            }
            else { MessageBox.Show("Заповни назву табличного виразу!"); }
        }

        private void end_with_button2_Click(object sender, EventArgs e)
        {
            is_with_value = false;
            column_name = column_name_temp.ToList();

            List<string> data_arr = new List<string>();
            data_arr = LoginForm.data_base.getTableName();
            table_name_comboBox1.ValueMember = "Table";
            if (with_name_list?.Count > 0) { 
                foreach(With_table el in with_name_list){
                    data_arr.Add(el.TableName);
                }
            }
            table_name_comboBox1.DataSource = data_arr;

            List<string> help_arr = new List<string>();



            help_arr = data_arr.ToList();
            List<string> help_arr_two = new List<string>();
            help_arr_two = data_arr.ToList();
            // help_arr.RemoveAt(0);


            first_table_comboBox1.ValueMember = "First Join Table";
            first_table_comboBox1.DataSource = help_arr_two;

            sec_table_comboBox1.ValueMember = "Second Join Table";
            sec_table_comboBox1.DataSource = help_arr;

            fillFieldConBox(data_arr[0]);
            fillJoinField(help_arr_two[0], help_arr[0]);
            fill_extra_fields();

        }

        private void with_name_textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
