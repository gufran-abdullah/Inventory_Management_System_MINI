namespace I_M_S
{
    partial class sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesBDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SalesBTComboBox = new System.Windows.Forms.ComboBox();
            this.SalesLNTextBox = new System.Windows.Forms.TextBox();
            this.SalesFNTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalePListBox = new System.Windows.Forms.ListBox();
            this.SalestotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesqtyTextBox = new System.Windows.Forms.TextBox();
            this.SalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesPTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SalesBillDataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SaleDButton = new System.Windows.Forms.Button();
            this.SaleSPButton = new System.Windows.Forms.Button();
            this.SaveandPrintButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBillDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalesBDDateTimePicker);
            this.panel1.Controls.Add(this.SalesBTComboBox);
            this.panel1.Controls.Add(this.SalesLNTextBox);
            this.panel1.Controls.Add(this.SalesFNTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 144);
            this.panel1.TabIndex = 1;
            // 
            // SalesBDDateTimePicker
            // 
            this.SalesBDDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBDDateTimePicker.Location = new System.Drawing.Point(105, 108);
            this.SalesBDDateTimePicker.Name = "SalesBDDateTimePicker";
            this.SalesBDDateTimePicker.Size = new System.Drawing.Size(266, 23);
            this.SalesBDDateTimePicker.TabIndex = 3;
            // 
            // SalesBTComboBox
            // 
            this.SalesBTComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBTComboBox.FormattingEnabled = true;
            this.SalesBTComboBox.Items.AddRange(new object[] {
            "CASH",
            "DEBIT"});
            this.SalesBTComboBox.Location = new System.Drawing.Point(105, 77);
            this.SalesBTComboBox.Name = "SalesBTComboBox";
            this.SalesBTComboBox.Size = new System.Drawing.Size(162, 24);
            this.SalesBTComboBox.TabIndex = 3;
            // 
            // SalesLNTextBox
            // 
            this.SalesLNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLNTextBox.Location = new System.Drawing.Point(105, 46);
            this.SalesLNTextBox.Name = "SalesLNTextBox";
            this.SalesLNTextBox.Size = new System.Drawing.Size(162, 23);
            this.SalesLNTextBox.TabIndex = 1;
            // 
            // SalesFNTextBox
            // 
            this.SalesFNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesFNTextBox.Location = new System.Drawing.Point(105, 15);
            this.SalesFNTextBox.Name = "SalesFNTextBox";
            this.SalesFNTextBox.Size = new System.Drawing.Size(162, 23);
            this.SalesFNTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bill Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bill Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SalePListBox);
            this.panel2.Controls.Add(this.SalestotalTextBox);
            this.panel2.Controls.Add(this.SalesqtyTextBox);
            this.panel2.Controls.Add(this.SalesPriceTextBox);
            this.panel2.Controls.Add(this.SalesPTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(398, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 144);
            this.panel2.TabIndex = 2;
            // 
            // SalePListBox
            // 
            this.SalePListBox.FormattingEnabled = true;
            this.SalePListBox.Location = new System.Drawing.Point(250, 21);
            this.SalePListBox.Name = "SalePListBox";
            this.SalePListBox.Size = new System.Drawing.Size(120, 108);
            this.SalePListBox.TabIndex = 8;
            this.SalePListBox.Visible = false;
            this.SalePListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalePListBox_KeyDown);
            // 
            // SalestotalTextBox
            // 
            this.SalestotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalestotalTextBox.Location = new System.Drawing.Point(82, 110);
            this.SalestotalTextBox.Name = "SalestotalTextBox";
            this.SalestotalTextBox.Size = new System.Drawing.Size(162, 23);
            this.SalestotalTextBox.TabIndex = 7;
            // 
            // SalesqtyTextBox
            // 
            this.SalesqtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesqtyTextBox.Location = new System.Drawing.Point(82, 81);
            this.SalesqtyTextBox.Name = "SalesqtyTextBox";
            this.SalesqtyTextBox.Size = new System.Drawing.Size(162, 23);
            this.SalesqtyTextBox.TabIndex = 6;
            this.SalesqtyTextBox.Leave += new System.EventHandler(this.SalesqtyTextBox_Leave);
            // 
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPriceTextBox.Location = new System.Drawing.Point(82, 49);
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.Size = new System.Drawing.Size(162, 23);
            this.SalesPriceTextBox.TabIndex = 5;
            this.SalesPriceTextBox.Enter += new System.EventHandler(this.SalesPriceTextBox_Enter);
            // 
            // SalesPTextBox
            // 
            this.SalesPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPTextBox.Location = new System.Drawing.Point(82, 18);
            this.SalesPTextBox.Name = "SalesPTextBox";
            this.SalesPTextBox.Size = new System.Drawing.Size(162, 23);
            this.SalesPTextBox.TabIndex = 4;
            this.SalesPTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesPTextBox_KeyDown);
            this.SalesPTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SalesPTextBox_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "QTY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Product";
            // 
            // SalesButton
            // 
            this.SalesButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SalesButton.FlatAppearance.BorderSize = 0;
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SalesButton.Location = new System.Drawing.Point(788, 111);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(143, 30);
            this.SalesButton.TabIndex = 9;
            this.SalesButton.Text = "Sell";
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // SalesBillDataGridView
            // 
            this.SalesBillDataGridView.AllowUserToAddRows = false;
            this.SalesBillDataGridView.AllowUserToDeleteRows = false;
            this.SalesBillDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesBillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesBillDataGridView.Location = new System.Drawing.Point(13, 198);
            this.SalesBillDataGridView.Name = "SalesBillDataGridView";
            this.SalesBillDataGridView.ReadOnly = true;
            this.SalesBillDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesBillDataGridView.Size = new System.Drawing.Size(765, 299);
            this.SalesBillDataGridView.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(784, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(835, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "0";
            // 
            // SaleDButton
            // 
            this.SaleDButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaleDButton.FlatAppearance.BorderSize = 0;
            this.SaleDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleDButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SaleDButton.Location = new System.Drawing.Point(788, 341);
            this.SaleDButton.Name = "SaleDButton";
            this.SaleDButton.Size = new System.Drawing.Size(143, 30);
            this.SaleDButton.TabIndex = 11;
            this.SaleDButton.Text = "Delete";
            this.SaleDButton.UseVisualStyleBackColor = false;
            this.SaleDButton.Click += new System.EventHandler(this.SaleDButton_Click);
            // 
            // SaleSPButton
            // 
            this.SaleSPButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaleSPButton.FlatAppearance.BorderSize = 0;
            this.SaleSPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleSPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleSPButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SaleSPButton.Location = new System.Drawing.Point(788, 377);
            this.SaleSPButton.Name = "SaleSPButton";
            this.SaleSPButton.Size = new System.Drawing.Size(143, 30);
            this.SaleSPButton.TabIndex = 12;
            this.SaleSPButton.Text = "Save";
            this.SaleSPButton.UseVisualStyleBackColor = false;
            this.SaleSPButton.Click += new System.EventHandler(this.SaleSPButton_Click);
            // 
            // SaveandPrintButton
            // 
            this.SaveandPrintButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveandPrintButton.FlatAppearance.BorderSize = 0;
            this.SaveandPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveandPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveandPrintButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveandPrintButton.Location = new System.Drawing.Point(788, 413);
            this.SaveandPrintButton.Name = "SaveandPrintButton";
            this.SaveandPrintButton.Size = new System.Drawing.Size(143, 30);
            this.SaveandPrintButton.TabIndex = 12;
            this.SaveandPrintButton.Text = "Save | Print Bill";
            this.SaveandPrintButton.UseVisualStyleBackColor = false;
            this.SaveandPrintButton.Click += new System.EventHandler(this.SaveandPrintButton_Click);
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(943, 509);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SalesBillDataGridView);
            this.Controls.Add(this.SaveandPrintButton);
            this.Controls.Add(this.SaleSPButton);
            this.Controls.Add(this.SaleDButton);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(959, 548);
            this.MinimumSize = new System.Drawing.Size(959, 548);
            this.Name = "sales";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALES";
            this.Load += new System.EventHandler(this.sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBillDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker SalesBDDateTimePicker;
        private System.Windows.Forms.ComboBox SalesBTComboBox;
        private System.Windows.Forms.TextBox SalesLNTextBox;
        private System.Windows.Forms.TextBox SalesFNTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox SalePListBox;
        private System.Windows.Forms.TextBox SalestotalTextBox;
        private System.Windows.Forms.TextBox SalesqtyTextBox;
        private System.Windows.Forms.TextBox SalesPriceTextBox;
        private System.Windows.Forms.TextBox SalesPTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.DataGridView SalesBillDataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SaleDButton;
        private System.Windows.Forms.Button SaleSPButton;
        private System.Windows.Forms.Button SaveandPrintButton;
    }
}