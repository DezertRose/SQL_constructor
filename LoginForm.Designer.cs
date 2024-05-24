
namespace Diplome1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.dataBase_label = new System.Windows.Forms.Label();
            this.server_label = new System.Windows.Forms.Label();
            this.db_name_textbox = new System.Windows.Forms.TextBox();
            this.server_name_textbox = new System.Windows.Forms.TextBox();
            this.autorization_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.port_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autorization";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // user_name_textbox
            // 
            this.user_name_textbox.Location = new System.Drawing.Point(239, 210);
            this.user_name_textbox.Name = "user_name_textbox";
            this.user_name_textbox.Size = new System.Drawing.Size(504, 22);
            this.user_name_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(239, 246);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(504, 22);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(390, 304);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(166, 51);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // dataBase_label
            // 
            this.dataBase_label.AutoSize = true;
            this.dataBase_label.Location = new System.Drawing.Point(101, 177);
            this.dataBase_label.Name = "dataBase_label";
            this.dataBase_label.Size = new System.Drawing.Size(113, 17);
            this.dataBase_label.TabIndex = 8;
            this.dataBase_label.Text = "Data Base name";
            // 
            // server_label
            // 
            this.server_label.AutoSize = true;
            this.server_label.Location = new System.Drawing.Point(101, 143);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(91, 17);
            this.server_label.TabIndex = 9;
            this.server_label.Text = "Server Name";
            // 
            // db_name_textbox
            // 
            this.db_name_textbox.Location = new System.Drawing.Point(239, 177);
            this.db_name_textbox.Name = "db_name_textbox";
            this.db_name_textbox.Size = new System.Drawing.Size(504, 22);
            this.db_name_textbox.TabIndex = 10;
            // 
            // server_name_textbox
            // 
            this.server_name_textbox.Location = new System.Drawing.Point(239, 143);
            this.server_name_textbox.Name = "server_name_textbox";
            this.server_name_textbox.Size = new System.Drawing.Size(343, 22);
            this.server_name_textbox.TabIndex = 11;
            // 
            // autorization_comboBox
            // 
            this.autorization_comboBox.AllowDrop = true;
            this.autorization_comboBox.FormattingEnabled = true;
            this.autorization_comboBox.Items.AddRange(new object[] {
            "windows autorization",
            "sql autorization",
            "MySQL autorization"});
            this.autorization_comboBox.Location = new System.Drawing.Point(239, 109);
            this.autorization_comboBox.Name = "autorization_comboBox";
            this.autorization_comboBox.Size = new System.Drawing.Size(343, 24);
            this.autorization_comboBox.TabIndex = 12;
            this.autorization_comboBox.SelectedIndexChanged += new System.EventHandler(this.autorization_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Connection type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Port";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // port_textBox1
            // 
            this.port_textBox1.Location = new System.Drawing.Point(643, 145);
            this.port_textBox1.Name = "port_textBox1";
            this.port_textBox1.Size = new System.Drawing.Size(100, 22);
            this.port_textBox1.TabIndex = 15;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.port_textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.autorization_comboBox);
            this.Controls.Add(this.server_name_textbox);
            this.Controls.Add(this.db_name_textbox);
            this.Controls.Add(this.server_label);
            this.Controls.Add(this.dataBase_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.user_name_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = " Login";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label dataBase_label;
        private System.Windows.Forms.Label server_label;
        private System.Windows.Forms.TextBox db_name_textbox;
        private System.Windows.Forms.TextBox server_name_textbox;
        private System.Windows.Forms.ComboBox autorization_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox port_textBox1;
    }
}

