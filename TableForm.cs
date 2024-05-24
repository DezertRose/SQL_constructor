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

namespace Diplome1
{
    public partial class TableForm : Form
    {
        string[] functions_arr = { "SUM", "AVG", "MAX", "MIN", "COUNT" };
        string[] condition_arr = { ">", "<", ">=", "<=", "=", "!=" };
        List<string> value_arr = new List<string>();
        List<string> where_arr = new List<string>();
        string table_dt;
        string temp_res_field_box;

        public TableForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            insertTree();
            fillConBox();
            // insertGrid();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        void fill_extra_fields() {
            function_comboBox.ValueMember = "Functions";
            function_comboBox.DataSource = functions_arr;

            con_comboBox.ValueMember = "Condition";
            con_comboBox.DataSource = condition_arr;
        }

        void fillFieldConBox(string table_name) {
            if (table_name_comboBox1.Text != null)
            {
                List<String> data_arr = new List<string>();
                data_arr = LoginForm.data_base.getColumn(table_name);
                field_comboBox.ValueMember = "Field";
                field_comboBox.DataSource = data_arr;
                temp_res_field_box = data_arr[0];
                table_dt = table_name;

                List<String> help_data_arr = new List<string>();
                help_data_arr = LoginForm.data_base.getColumn(table_name);
                field_con_comboBox.ValueMember = "Field Condition";
                field_con_comboBox.DataSource = help_data_arr;
            }
        }

        void fillConBox() {
            List<string> data_arr = new List<string>();
            data_arr = LoginForm.data_base.getTableName();
            table_name_comboBox1.ValueMember = "Table";
            table_name_comboBox1.DataSource = data_arr;

            fillFieldConBox(data_arr[0]);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void colum_area_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void condition_label_Click(object sender, EventArgs e)
        {

        }

        private void table_name_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void table_name_comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (table_name_comboBox1.SelectedValue != null)
            {
                List<String> data_arr = new List<string>();
                data_arr = LoginForm.data_base.getColumn(table_name_comboBox1.SelectedValue.ToString());
                field_comboBox.ValueMember = "Field";
                field_comboBox.DataSource = data_arr;


                List<String> help_data_arr = new List<string>();
                help_data_arr = LoginForm.data_base.getColumn(table_name_comboBox1.SelectedValue.ToString());
                field_con_comboBox.ValueMember = "Field Condition";
                field_con_comboBox.DataSource = help_data_arr;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (field_comboBox.SelectedValue != null) {
                temp_res_field_box = field_comboBox.SelectedValue.ToString();
            }
            string temp_res_fun_box = functions_arr[0];
            if (function_comboBox.SelectedValue != null) {
                temp_res_fun_box = function_comboBox.SelectedValue.ToString();
            }

            bool is_insert_row = false;
            
            if (value_arr?.Count > 0) {
                for(int i=0; i < value_arr.Count; i++) {
                    if (value_arr[i] == temp_res_field_box) {
                        value_arr[i - 1] = temp_res_fun_box;
                        is_insert_row = true;
                    }
                }
                if (!is_insert_row) {
                    value_arr.Add(temp_res_fun_box);
                    value_arr.Add(temp_res_field_box);
                }
            }
            else
            {
                value_arr.Add(temp_res_fun_box);
                value_arr.Add(temp_res_field_box);
            }

        }

        private void add_con_button1_Click(object sender, EventArgs e)
        {
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

            if (exp_con_textBox.Text != null)
            {
                bool is_insert = false;
                if (where_arr?.Count > 0)
                {
                    for (int i = 0; i < where_arr.Count; i++)
                    {
                        if (where_arr[i] == temp_res_con_field)
                        {

                            where_arr[i + 1] = exp_con_textBox.Text.ToString();
                            where_arr[i + 2] = temp_res_con_box;
                            i = i + 2;
                            is_insert = true;
                        }
                    }
                    if (!is_insert)
                    {
                        where_arr.Add(temp_res_con_field);
                        where_arr.Add(temp_res_con_box);
                        where_arr.Add(exp_con_textBox.Text.ToString());
                    }
                }
                else
                {
                    where_arr.Add(temp_res_con_field);
                    where_arr.Add(temp_res_con_box);
                    where_arr.Add(exp_con_textBox.Text.ToString());
                }
            }
            else { MessageBox.Show("Fill data into Expression field!"); }

        }

        private void run_button_Click(object sender, EventArgs e)
        {
            if (table_name_comboBox1.SelectedValue.ToString() != null) {
                table_dt = table_name_comboBox1.SelectedValue.ToString();
            }

            string command = "select ";
            int t = 1;
            if (value_arr?.Count > 0)
            {
                foreach (string el in value_arr)
                {
                    if (t % 2 == 0)
                    {

                        if (t == value_arr.Count)
                        {
                            string help = el + ") from " + table_dt;
                            command += help;
                        }
                        else
                        {
                            command += el + "), ";
                        }
                    }
                    else
                    {
                        if (t % 2 != 0)
                        {
                            command += el + "(";
                        }
                    }
                    t++;
                }
            }
            else {
                command = "select * from table_dt";
            }

            t = 1;
            if (where_arr?.Count > 0)
            {
                command += " where ";
                foreach (string el in where_arr)
                {
                    if (t % 3 == 0)
                    {
                        if (t == where_arr.Count)
                        {
                            command += " '"+el + "' ";
                        }
                        else
                        {
                            command += el + "' and ";
                        }
                    }
                    else
                    {
                        if (t % 2 == 0)
                        {
                            command += el + " ";
                        }
                        else
                        {
                            if (t % 3 != 0 && t % 2 != 0) { command += el + " "; }
                        }
                    }
                    t++;
                }
            }
            Out_textBox1.Text = command;
            try
            {
                insertGrid(command);
            }
            catch {
                MessageBox.Show("Something wrong with script!");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exp_file_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            String file = @"D:\Data"+ rnd.Next() + ".csv";
            String separator = "',";
            StringBuilder output = new StringBuilder();
            string connection = Out_textBox1.Text;

            List<List<string>> data_str = new List<List<string>>();
            DataTable resDT = new DataTable();

            data_str = LoginForm.data_base.getData(connection);
            // data_str = LoginForm.data_base.getData("select * from dwh_repo.dim_country");

            data_str[0].ForEach(colname => resDT.Columns.Add(colname));
            output.AppendLine(string.Join(separator, data_str[0]));

            foreach (List<string> row in data_str.Skip(1))
            {
                resDT.Rows.Add(row.ToArray());
                output.AppendLine(string.Join(separator, row));
            }

            try
            {
                File.AppendAllText(file, output.ToString());
            }
            catch (Exception ex) {
                Console.WriteLine("Data could not be written to the csv file.");
                return;
            }

        }

        void clear_all() {
            value_arr.Clear();
            where_arr.Clear();
            Out_textBox1.Text = "";
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
    }
}
