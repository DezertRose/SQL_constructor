
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
            this.table_name_comboBox1 = new System.Windows.Forms.ComboBox();
            this.fun_label = new System.Windows.Forms.Label();
            this.function_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.condition_label = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.fill_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // table_treeView
            // 
            this.table_treeView.Location = new System.Drawing.Point(0, 48);
            this.table_treeView.Name = "table_treeView";
            this.table_treeView.Size = new System.Drawing.Size(227, 678);
            this.table_treeView.TabIndex = 0;
            this.table_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // fill_dataGridView
            // 
            this.fill_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fill_dataGridView.Location = new System.Drawing.Point(227, 450);
            this.fill_dataGridView.Name = "fill_dataGridView";
            this.fill_dataGridView.RowHeadersWidth = 51;
            this.fill_dataGridView.RowTemplate.Height = 24;
            this.fill_dataGridView.Size = new System.Drawing.Size(952, 276);
            this.fill_dataGridView.TabIndex = 1;
            this.fill_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabl_name_label
            // 
            this.tabl_name_label.AutoSize = true;
            this.tabl_name_label.Location = new System.Drawing.Point(270, 48);
            this.tabl_name_label.Name = "tabl_name_label";
            this.tabl_name_label.Size = new System.Drawing.Size(85, 17);
            this.tabl_name_label.TabIndex = 2;
            this.tabl_name_label.Text = "Table Name";
            this.tabl_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // table_name_comboBox1
            // 
            this.table_name_comboBox1.FormattingEnabled = true;
            this.table_name_comboBox1.Location = new System.Drawing.Point(376, 48);
            this.table_name_comboBox1.Name = "table_name_comboBox1";
            this.table_name_comboBox1.Size = new System.Drawing.Size(168, 24);
            this.table_name_comboBox1.TabIndex = 3;
            this.table_name_comboBox1.SelectedIndexChanged += new System.EventHandler(this.table_name_comboBox1_SelectedIndexChanged);
            this.table_name_comboBox1.SelectedValueChanged += new System.EventHandler(this.table_name_comboBox1_SelectedValueChanged);
            // 
            // fun_label
            // 
            this.fun_label.AutoSize = true;
            this.fun_label.Location = new System.Drawing.Point(270, 93);
            this.fun_label.Name = "fun_label";
            this.fun_label.Size = new System.Drawing.Size(62, 17);
            this.fun_label.TabIndex = 4;
            this.fun_label.Text = "Function";
            this.fun_label.Click += new System.EventHandler(this.colum_area_label_Click);
            // 
            // function_comboBox
            // 
            this.function_comboBox.FormattingEnabled = true;
            this.function_comboBox.Location = new System.Drawing.Point(269, 124);
            this.function_comboBox.Name = "function_comboBox";
            this.function_comboBox.Size = new System.Drawing.Size(134, 24);
            this.function_comboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Field";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // condition_label
            // 
            this.condition_label.AutoSize = true;
            this.condition_label.Location = new System.Drawing.Point(267, 171);
            this.condition_label.Name = "condition_label";
            this.condition_label.Size = new System.Drawing.Size(88, 17);
            this.condition_label.TabIndex = 7;
            this.condition_label.Text = "Fill Condition";
            this.condition_label.Click += new System.EventHandler(this.condition_label_Click);
            // 
            // field_con_label
            // 
            this.field_con_label.AutoSize = true;
            this.field_con_label.Location = new System.Drawing.Point(270, 205);
            this.field_con_label.Name = "field_con_label";
            this.field_con_label.Size = new System.Drawing.Size(38, 17);
            this.field_con_label.TabIndex = 9;
            this.field_con_label.Text = "Field";
            this.field_con_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // con_label
            // 
            this.con_label.AutoSize = true;
            this.con_label.Location = new System.Drawing.Point(411, 205);
            this.con_label.Name = "con_label";
            this.con_label.Size = new System.Drawing.Size(67, 17);
            this.con_label.TabIndex = 10;
            this.con_label.Text = "Condition";
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.Location = new System.Drawing.Point(574, 205);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(77, 17);
            this.exp_label.TabIndex = 11;
            this.exp_label.Text = "Expression";
            // 
            // field_comboBox
            // 
            this.field_comboBox.FormattingEnabled = true;
            this.field_comboBox.Location = new System.Drawing.Point(439, 123);
            this.field_comboBox.Name = "field_comboBox";
            this.field_comboBox.Size = new System.Drawing.Size(169, 24);
            this.field_comboBox.TabIndex = 12;
            // 
            // field_con_comboBox
            // 
            this.field_con_comboBox.FormattingEnabled = true;
            this.field_con_comboBox.Location = new System.Drawing.Point(269, 225);
            this.field_con_comboBox.Name = "field_con_comboBox";
            this.field_con_comboBox.Size = new System.Drawing.Size(121, 24);
            this.field_con_comboBox.TabIndex = 14;
            // 
            // con_comboBox
            // 
            this.con_comboBox.FormattingEnabled = true;
            this.con_comboBox.Location = new System.Drawing.Point(410, 224);
            this.con_comboBox.Name = "con_comboBox";
            this.con_comboBox.Size = new System.Drawing.Size(121, 24);
            this.con_comboBox.TabIndex = 15;
            // 
            // exp_con_textBox
            // 
            this.exp_con_textBox.Location = new System.Drawing.Point(566, 225);
            this.exp_con_textBox.Name = "exp_con_textBox";
            this.exp_con_textBox.Size = new System.Drawing.Size(100, 22);
            this.exp_con_textBox.TabIndex = 16;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(660, 123);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 17;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_con_button1
            // 
            this.add_con_button1.Location = new System.Drawing.Point(705, 226);
            this.add_con_button1.Name = "add_con_button1";
            this.add_con_button1.Size = new System.Drawing.Size(75, 23);
            this.add_con_button1.TabIndex = 18;
            this.add_con_button1.Text = "Add";
            this.add_con_button1.UseVisualStyleBackColor = true;
            this.add_con_button1.Click += new System.EventHandler(this.add_con_button1_Click);
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(454, 280);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(114, 47);
            this.run_button.TabIndex = 19;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // Out_textBox1
            // 
            this.Out_textBox1.Location = new System.Drawing.Point(233, 347);
            this.Out_textBox1.Name = "Out_textBox1";
            this.Out_textBox1.Size = new System.Drawing.Size(915, 22);
            this.Out_textBox1.TabIndex = 20;
            // 
            // exp_file
            // 
            this.exp_file.Location = new System.Drawing.Point(227, 415);
            this.exp_file.Name = "exp_file";
            this.exp_file.Size = new System.Drawing.Size(105, 37);
            this.exp_file.TabIndex = 21;
            this.exp_file.Text = "Export";
            this.exp_file.UseVisualStyleBackColor = true;
            this.exp_file.Click += new System.EventHandler(this.exp_file_Click);
            // 
            // clear_button1
            // 
            this.clear_button1.Location = new System.Drawing.Point(600, 280);
            this.clear_button1.Name = "clear_button1";
            this.clear_button1.Size = new System.Drawing.Size(114, 47);
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
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 726);
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
            this.Controls.Add(this.condition_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.function_comboBox);
            this.Controls.Add(this.fun_label);
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
        private System.Windows.Forms.ComboBox table_name_comboBox1;
        private System.Windows.Forms.Label fun_label;
        private System.Windows.Forms.ComboBox function_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label condition_label;
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
    }
}