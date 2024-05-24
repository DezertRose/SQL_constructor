using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diplome1.Classes;

namespace Diplome1
{
    public partial class LoginForm : Form
    {
        public static DB_connector data_base; // change for different db 
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            /* FillGridView();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*void FillGridView() {
            List<DB> region_list = new List<DB>();

            DB region = new DB(); 

            region_list = region.GetData();

            dataGridViewBook.DataSource = region_list;
        
        }*/

        private void Main_form_Load(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
            user_name_textbox.MaxLength = 225;
            password_textbox.MaxLength = 50;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string server_name = server_name_textbox.Text;
            string db_name = db_name_textbox.Text;
            string user_name = user_name_textbox.Text;
            string pass = password_textbox.Text;
            string port = port_textBox1.Text;

            /*SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();*/
            //try
            //{
                int temp = data_base.changeConnection(server_name, db_name, user_name, pass, port);

                if (data_base.stateConnection())
                {
                    TableForm tb_form = new TableForm();
                    Hide();
                    tb_form.ShowDialog();
                    Show();
                }

            /*}
            catch
            {
                MessageBox.Show("Error!");
                server_name_textbox.Clear();
                db_name_textbox.Clear();
                user_name_textbox.Clear();
                password_textbox.Clear();
            }
            finally {
                data_base.closeConnection();
            }*/
        }

        private void autorization_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (autorization_comboBox.SelectedItem.ToString() == "windows autorization")
            {
                data_base = new Windows_MSSQL();
            }
            else
            {
                if (autorization_comboBox.SelectedItem.ToString() == "MySQL autorization") 
                { data_base = new MySQL(); }
                else { data_base = new MSSQL_Autorization(); }
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
