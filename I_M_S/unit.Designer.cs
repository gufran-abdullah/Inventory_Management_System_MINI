namespace I_M_S
{
    partial class unit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(unit));
            this.label1 = new System.Windows.Forms.Label();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.AddUnitButton = new System.Windows.Forms.Button();
            this.UnitDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteUnitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UnitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Name";
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTextBox.Location = new System.Drawing.Point(101, 184);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(188, 23);
            this.UnitTextBox.TabIndex = 0;
            // 
            // AddUnitButton
            // 
            this.AddUnitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddUnitButton.FlatAppearance.BorderSize = 0;
            this.AddUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUnitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddUnitButton.Location = new System.Drawing.Point(101, 223);
            this.AddUnitButton.Name = "AddUnitButton";
            this.AddUnitButton.Size = new System.Drawing.Size(188, 25);
            this.AddUnitButton.TabIndex = 1;
            this.AddUnitButton.Text = "Add Unit";
            this.AddUnitButton.UseVisualStyleBackColor = false;
            this.AddUnitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UnitDataGridView
            // 
            this.UnitDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UnitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitDataGridView.Location = new System.Drawing.Point(295, 68);
            this.UnitDataGridView.Name = "UnitDataGridView";
            this.UnitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnitDataGridView.Size = new System.Drawing.Size(425, 298);
            this.UnitDataGridView.TabIndex = 3;
            // 
            // DeleteUnitButton
            // 
            this.DeleteUnitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteUnitButton.FlatAppearance.BorderSize = 0;
            this.DeleteUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUnitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUnitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteUnitButton.Location = new System.Drawing.Point(295, 378);
            this.DeleteUnitButton.Name = "DeleteUnitButton";
            this.DeleteUnitButton.Size = new System.Drawing.Size(188, 28);
            this.DeleteUnitButton.TabIndex = 4;
            this.DeleteUnitButton.Text = "Delete Selected Unit";
            this.DeleteUnitButton.UseVisualStyleBackColor = false;
            this.DeleteUnitButton.Click += new System.EventHandler(this.DeleteUnitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 23);
            this.label2.MaximumSize = new System.Drawing.Size(109, 26);
            this.label2.MinimumSize = new System.Drawing.Size(109, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Unit";
            // 
            // unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UnitDataGridView);
            this.Controls.Add(this.DeleteUnitButton);
            this.Controls.Add(this.AddUnitButton);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "unit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNITS";
            this.Load += new System.EventHandler(this.unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.Button AddUnitButton;
        private System.Windows.Forms.DataGridView UnitDataGridView;
        private System.Windows.Forms.Button DeleteUnitButton;
        private System.Windows.Forms.Label label2;
    }
}