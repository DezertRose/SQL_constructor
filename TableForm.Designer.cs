
namespace Diplome1
{
    partial class TableForm
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
            this.table_treeView = new System.Windows.Forms.TreeView();
            this.fill_dataGridView = new System.Windows.Forms.DataGridView();
            this.tabl_name_label = new System.Windows.Forms.Label();
            this.function_comboBox = new System.Windows.Forms.ComboBox();
            this.field_con_label = new System.Windows.Forms.Label();
            this.con_label = new System.Windows.Forms.Label();
            this.exp_label = new System.Windows.Forms.Label();
            this.field_comboBox = new System.Windows.Forms.ComboBox();
            this.field_con_comboBox = new System.Windows.Forms.ComboBox();
            this.con_comboBox = new System.Windows.Forms.ComboBox();
            this.exp_con_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.add_con_button1 = new System.Windows.Forms.Button();
            this.run_button = new System.Windows.Forms.Button();
            this.Out_textBox1 = new System.Windows.Forms.TextBox();
            this.exp_file = new System.Windows.Forms.Button();
            this.clear_button1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add_oport_comboBox1 = new System.Windows.Forms.ComboBox();
            this.add_opp_button2 = new System.Windows.Forms.Button();
            this.join_label2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_table_comboBox1 = new System.Windows.Forms.ComboBox();
            this.sec_table_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.join_field_comboBox1 = new System.Windows.Forms.ComboBox();
            this.join_sec_field_comboBox1 = new System.Windows.Forms.ComboBox();
            this.join_button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.withc_join_comboBox1 = new System.Windows.Forms.ComboBox();
            this.start_with_button2 = new System.Windows.Forms.Button();
            this.end_with_button2 = new System.Windows.Forms.Button();
            this.with_name_textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.table_name_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fiel_name_textBox1 = new System.Windows.Forms.TextBox();
            this.opportunity_field_comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fill_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // table_treeView
            // 
            this.table_treeView.Location = new System.Drawing.Point(0, 48);
            this.table_treeView.Name = "table_treeView";
            this.table_treeView.Size = new System.Drawing.Size(227, 1006);
            this.table_treeView.TabIndex = 0;
            this.table_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // fill_dataGridView
            // 
            this.fill_dataGridView.ColumnHeadersHeight = 29;
            this.fill_dataGridView.Location = new System.Drawing.Point(227, 736);
            this.fill_dataGridView.Name = "fill_dataGridView";
            this.fill_dataGridView.RowHeadersWidth = 51;
            this.fill_dataGridView.Size = new System.Drawing.Size(1485, 237);
            this.fill_dataGridView.TabIndex = 49;
            this.fill_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fill_dataGridView_CellContentClick);
            // 
            // tabl_name_label
            // 
            this.tabl_name_label.Location = new System.Drawing.Point(0, 0);
            this.tabl_name_label.Name = "tabl_name_label";
            this.tabl_name_label.Size = new System.Drawing.Size(100, 23);
            this.tabl_name_label.TabIndex = 48;
            // 
            // function_comboBox
            // 
            this.function_comboBox.FormattingEnabled = true;
            this.function_comboBox.Location = new System.Drawing.Point(259, 122);
            this.function_comboBox.Name = "function_comboBox";
            this.function_comboBox.Size = new System.Drawing.Size(134, 24);
            this.function_comboBox.TabIndex = 5;
            this.function_comboBox.SelectedIndexChanged += new System.EventHandler(this.function_comboBox_SelectedIndexChanged);
            // 
            // field_con_label
            // 
            this.field_con_label.AutoSize = true;
            this.field_con_label.Location = new System.Drawing.Point(842, 93);
            this.field_con_label.Name = "field_con_label";
            this.field_con_label.Size = new System.Drawing.Size(38, 17);
            this.field_con_label.TabIndex = 9;
            this.field_con_label.Text = "Field";
            this.field_con_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // con_label
            // 
            this.con_label.AutoSize = true;
            this.con_label.Location = new System.Drawing.Point(994, 93);
            this.con_label.Name = "con_label";
            this.con_label.Size = new System.Drawing.Size(67, 17);
            this.con_label.TabIndex = 10;
            this.con_label.Text = "Condition";
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.Location = new System.Drawing.Point(1155, 93);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(77, 17);
            this.exp_label.TabIndex = 11;
            this.exp_label.Text = "Expression";
            // 
            // field_comboBox
            // 
            this.field_comboBox.FormattingEnabled = true;
            this.field_comboBox.Location = new System.Drawing.Point(410, 121);
            this.field_comboBox.Name = "field_comboBox";
            this.field_comboBox.Size = new System.Drawing.Size(169, 24);
            this.field_comboBox.TabIndex = 12;
            // 
            // field_con_comboBox
            // 
            this.field_con_comboBox.FormattingEnabled = true;
            this.field_con_comboBox.Location = new System.Drawing.Point(845, 122);
            this.field_con_comboBox.Name = "field_con_comboBox";
            this.field_con_comboBox.Size = new System.Drawing.Size(121, 24);
            this.field_con_comboBox.TabIndex = 14;
            this.field_con_comboBox.SelectedIndexChanged += new System.EventHandler(this.field_con_comboBox_SelectedIndexChanged);
            // 
            // con_comboBox
            // 
            this.con_comboBox.FormattingEnabled = true;
            this.con_comboBox.Location = new System.Drawing.Point(997, 122);
            this.con_comboBox.Name = "con_comboBox";
            this.con_comboBox.Size = new System.Drawing.Size(121, 24);
            this.con_comboBox.TabIndex = 15;
            // 
            // exp_con_textBox
            // 
            this.exp_con_textBox.Location = new System.Drawing.Point(1158, 124);
            this.exp_con_textBox.Name = "exp_con_textBox";
            this.exp_con_textBox.Size = new System.Drawing.Size(136, 22);
            this.exp_con_textBox.TabIndex = 16;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(754, 121);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 17;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_con_button1
            // 
            this.add_con_button1.Location = new System.Drawing.Point(1333, 124);
            this.add_con_button1.Name = "add_con_button1";
            this.add_con_button1.Size = new System.Drawing.Size(75, 23);
            this.add_con_button1.TabIndex = 18;
            this.add_con_button1.Text = "Add";
            this.add_con_button1.UseVisualStyleBackColor = true;
            this.add_con_button1.Click += new System.EventHandler(this.add_con_button1_Click);
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(336, 695);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(108, 41);
            this.run_button.TabIndex = 19;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // Out_textBox1
            // 
            this.Out_textBox1.Location = new System.Drawing.Point(231, 515);
            this.Out_textBox1.Multiline = true;
            this.Out_textBox1.Name = "Out_textBox1";
            this.Out_textBox1.Size = new System.Drawing.Size(1481, 179);
            this.Out_textBox1.TabIndex = 20;
            // 
            // exp_file
            // 
            this.exp_file.Location = new System.Drawing.Point(227, 695);
            this.exp_file.Name = "exp_file";
            this.exp_file.Size = new System.Drawing.Size(105, 41);
            this.exp_file.TabIndex = 21;
            this.exp_file.Text = "Export";
            this.exp_file.UseVisualStyleBackColor = true;
            this.exp_file.Click += new System.EventHandler(this.exp_file_Click);
            // 
            // clear_button1
            // 
            this.clear_button1.Location = new System.Drawing.Point(448, 695);
            this.clear_button1.Name = "clear_button1";
            this.clear_button1.Size = new System.Drawing.Size(111, 41);
            this.clear_button1.TabIndex = 22;
            this.clear_button1.Text = "Clear";
            this.clear_button1.UseVisualStyleBackColor = true;
            this.clear_button1.Click += new System.EventHandler(this.clear_button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Change connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_oport_comboBox1
            // 
            this.add_oport_comboBox1.DisplayMember = "Querry poss";
            this.add_oport_comboBox1.FormattingEnabled = true;
            this.add_oport_comboBox1.Location = new System.Drawing.Point(845, 197);
            this.add_oport_comboBox1.Name = "add_oport_comboBox1";
            this.add_oport_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.add_oport_comboBox1.TabIndex = 24;
            this.add_oport_comboBox1.SelectedIndexChanged += new System.EventHandler(this.add_oport_comboBox1_SelectedIndexChanged);
            // 
            // add_opp_button2
            // 
            this.add_opp_button2.Location = new System.Drawing.Point(1168, 198);
            this.add_opp_button2.Name = "add_opp_button2";
            this.add_opp_button2.Size = new System.Drawing.Size(75, 23);
            this.add_opp_button2.TabIndex = 26;
            this.add_opp_button2.Text = "Add";
            this.add_opp_button2.UseVisualStyleBackColor = true;
            this.add_opp_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // join_label2
            // 
            this.join_label2.AutoSize = true;
            this.join_label2.Location = new System.Drawing.Point(266, 245);
            this.join_label2.Name = "join_label2";
            this.join_label2.Size = new System.Drawing.Size(34, 17);
            this.join_label2.TabIndex = 27;
            this.join_label2.Text = "Join";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "First Table Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Second Table Name";
            // 
            // first_table_comboBox1
            // 
            this.first_table_comboBox1.DisplayMember = "First Join Table";
            this.first_table_comboBox1.FormattingEnabled = true;
            this.first_table_comboBox1.Location = new System.Drawing.Point(410, 280);
            this.first_table_comboBox1.Name = "first_table_comboBox1";
            this.first_table_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.first_table_comboBox1.TabIndex = 30;
            this.first_table_comboBox1.SelectedValueChanged += new System.EventHandler(this.first_table_comboBox1_SelectedValueChanged);
            this.first_table_comboBox1.TextChanged += new System.EventHandler(this.first_table_comboBox1_TextChanged);
            // 
            // sec_table_comboBox1
            // 
            this.sec_table_comboBox1.DisplayMember = "Second Join Table";
            this.sec_table_comboBox1.FormattingEnabled = true;
            this.sec_table_comboBox1.Location = new System.Drawing.Point(409, 314);
            this.sec_table_comboBox1.Name = "sec_table_comboBox1";
            this.sec_table_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.sec_table_comboBox1.TabIndex = 31;
            this.sec_table_comboBox1.SelectedIndexChanged += new System.EventHandler(this.sec_table_comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Field";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Field";
            // 
            // join_field_comboBox1
            // 
            this.join_field_comboBox1.FormattingEnabled = true;
            this.join_field_comboBox1.Location = new System.Drawing.Point(596, 280);
            this.join_field_comboBox1.Name = "join_field_comboBox1";
            this.join_field_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.join_field_comboBox1.TabIndex = 34;
            // 
            // join_sec_field_comboBox1
            // 
            this.join_sec_field_comboBox1.FormattingEnabled = true;
            this.join_sec_field_comboBox1.Location = new System.Drawing.Point(596, 314);
            this.join_sec_field_comboBox1.Name = "join_sec_field_comboBox1";
            this.join_sec_field_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.join_sec_field_comboBox1.TabIndex = 35;
            // 
            // join_button2
            // 
            this.join_button2.Location = new System.Drawing.Point(743, 295);
            this.join_button2.Name = "join_button2";
            this.join_button2.Size = new System.Drawing.Size(75, 23);
            this.join_button2.TabIndex = 36;
            this.join_button2.Text = "Add";
            this.join_button2.UseVisualStyleBackColor = true;
            this.join_button2.Click += new System.EventHandler(this.join_button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(994, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Field";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(842, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Querry poss";
            // 
            // withc_join_comboBox1
            // 
            this.withc_join_comboBox1.FormattingEnabled = true;
            this.withc_join_comboBox1.Location = new System.Drawing.Point(323, 242);
            this.withc_join_comboBox1.Name = "withc_join_comboBox1";
            this.withc_join_comboBox1.Size = new System.Drawing.Size(121, 24);
            this.withc_join_comboBox1.TabIndex = 39;
            // 
            // start_with_button2
            // 
            this.start_with_button2.Location = new System.Drawing.Point(596, 50);
            this.start_with_button2.Name = "start_with_button2";
            this.start_with_button2.Size = new System.Drawing.Size(75, 23);
            this.start_with_button2.TabIndex = 40;
            this.start_with_button2.Text = "Start with";
            this.start_with_button2.UseVisualStyleBackColor = true;
            // 
            // end_with_button2
            // 
            this.end_with_button2.Location = new System.Drawing.Point(880, 50);
            this.end_with_button2.Name = "end_with_button2";
            this.end_with_button2.Size = new System.Drawing.Size(75, 23);
            this.end_with_button2.TabIndex = 41;
            this.end_with_button2.Text = "End with";
            this.end_with_button2.UseVisualStyleBackColor = true;
            // 
            // with_name_textBox1
            // 
            this.with_name_textBox1.Location = new System.Drawing.Point(698, 50);
            this.with_name_textBox1.Name = "with_name_textBox1";
            this.with_name_textBox1.Size = new System.Drawing.Size(159, 22);
            this.with_name_textBox1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(740, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "With name";
            // 
            // table_name_comboBox1
            // 
            this.table_name_comboBox1.Location = new System.Drawing.Point(336, 48);
            this.table_name_comboBox1.Name = "table_name_comboBox1";
            this.table_name_comboBox1.Size = new System.Drawing.Size(208, 24);
            this.table_name_comboBox1.TabIndex = 47;
            this.table_name_comboBox1.SelectedValueChanged += new System.EventHandler(this.table_name_comboBox1_SelectedValueChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Table";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Function";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Field";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 21);
            this.label11.TabIndex = 53;
            this.label11.Text = "Field Name";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // fiel_name_textBox1
            // 
            this.fiel_name_textBox1.Location = new System.Drawing.Point(592, 122);
            this.fiel_name_textBox1.Name = "fiel_name_textBox1";
            this.fiel_name_textBox1.Size = new System.Drawing.Size(145, 22);
            this.fiel_name_textBox1.TabIndex = 54;
            // 
            // opportunity_field_comboBox1
            // 
            this.opportunity_field_comboBox1.FormattingEnabled = true;
            this.opportunity_field_comboBox1.Location = new System.Drawing.Point(997, 197);
            this.opportunity_field_comboBox1.Name = "opportunity_field_comboBox1";
            this.opportunity_field_comboBox1.Size = new System.Drawing.Size(165, 24);
            this.opportunity_field_comboBox1.TabIndex = 55;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 974);
            this.Controls.Add(this.opportunity_field_comboBox1);
            this.Controls.Add(this.fiel_name_textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.with_name_textBox1);
            this.Controls.Add(this.end_with_button2);
            this.Controls.Add(this.start_with_button2);
            this.Controls.Add(this.withc_join_comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.join_button2);
            this.Controls.Add(this.join_sec_field_comboBox1);
            this.Controls.Add(this.join_field_comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sec_table_comboBox1);
            this.Controls.Add(this.first_table_comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.join_label2);
            this.Controls.Add(this.add_opp_button2);
            this.Controls.Add(this.add_oport_comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear_button1);
            this.Controls.Add(this.exp_file);
            this.Controls.Add(this.Out_textBox1);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.add_con_button1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.exp_con_textBox);
            this.Controls.Add(this.con_comboBox);
            this.Controls.Add(this.field_con_comboBox);
            this.Controls.Add(this.field_comboBox);
            this.Controls.Add(this.exp_label);
            this.Controls.Add(this.con_label);
            this.Controls.Add(this.field_con_label);
            this.Controls.Add(this.function_comboBox);
            this.Controls.Add(this.table_name_comboBox1);
            this.Controls.Add(this.tabl_name_label);
            this.Controls.Add(this.fill_dataGridView);
            this.Controls.Add(this.table_treeView);
            this.Name = "TableForm";
            this.Text = "TableForm";
            this.Load += new System.EventHandler(this.TableForm_Load);
            this.Shown += new System.EventHandler(this.TableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fill_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView table_treeView;
        private System.Windows.Forms.DataGridView fill_dataGridView;
        private System.Windows.Forms.Label tabl_name_label;
        private System.Windows.Forms.ComboBox function_comboBox;
        private System.Windows.Forms.Label field_con_label;
        private System.Windows.Forms.Label con_label;
        private System.Windows.Forms.Label exp_label;
        private System.Windows.Forms.ComboBox field_comboBox;
        private System.Windows.Forms.ComboBox field_con_comboBox;
        private System.Windows.Forms.ComboBox con_comboBox;
        private System.Windows.Forms.TextBox exp_con_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button add_con_button1;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.TextBox Out_textBox1;
        private System.Windows.Forms.Button exp_file;
        private System.Windows.Forms.Button clear_button1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox add_oport_comboBox1;
        private System.Windows.Forms.Button add_opp_button2;
        private System.Windows.Forms.Label join_label2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox first_table_comboBox1;
        private System.Windows.Forms.ComboBox sec_table_comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox join_field_comboBox1;
        private System.Windows.Forms.ComboBox join_sec_field_comboBox1;
        private System.Windows.Forms.Button join_button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox withc_join_comboBox1;
        private System.Windows.Forms.Button start_with_button2;
        private System.Windows.Forms.Button end_with_button2;
        private System.Windows.Forms.TextBox with_name_textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox table_name_comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fiel_name_textBox1;
        private System.Windows.Forms.ComboBox opportunity_field_comboBox1;
    }
}