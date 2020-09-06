namespace WP_Final.Forms
{
    partial class DeleteTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.dataGridView_Table = new System.Windows.Forms.DataGridView();
            this.checkedListBox_Table = new System.Windows.Forms.CheckedListBox();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.groupBox_Table = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).BeginInit();
            this.groupBox_Data.SuspendLayout();
            this.groupBox_Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(6, 355);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(170, 53);
            this.button_Delete.TabIndex = 0;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(182, 355);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(168, 53);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Table
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Table.Location = new System.Drawing.Point(3, 48);
            this.dataGridView_Table.Name = "dataGridView_Table";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Table.RowHeadersVisible = false;
            this.dataGridView_Table.RowTemplate.Height = 35;
            this.dataGridView_Table.Size = new System.Drawing.Size(583, 357);
            this.dataGridView_Table.TabIndex = 1;
            // 
            // checkedListBox_Table
            // 
            this.checkedListBox_Table.CheckOnClick = true;
            this.checkedListBox_Table.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox_Table.FormattingEnabled = true;
            this.checkedListBox_Table.Location = new System.Drawing.Point(0, 48);
            this.checkedListBox_Table.Name = "checkedListBox_Table";
            this.checkedListBox_Table.Size = new System.Drawing.Size(345, 284);
            this.checkedListBox_Table.TabIndex = 2;
            this.checkedListBox_Table.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Table_SelectedIndexChanged);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.dataGridView_Table);
            this.groupBox_Data.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Data.Location = new System.Drawing.Point(11, 12);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(589, 408);
            this.groupBox_Data.TabIndex = 3;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // groupBox_Table
            // 
            this.groupBox_Table.Controls.Add(this.checkedListBox_Table);
            this.groupBox_Table.Controls.Add(this.button_Cancel);
            this.groupBox_Table.Controls.Add(this.button_Delete);
            this.groupBox_Table.Location = new System.Drawing.Point(607, 12);
            this.groupBox_Table.Name = "groupBox_Table";
            this.groupBox_Table.Size = new System.Drawing.Size(357, 408);
            this.groupBox_Table.TabIndex = 3;
            this.groupBox_Table.TabStop = false;
            this.groupBox_Table.Text = "Table";
            // 
            // DeleteTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 436);
            this.Controls.Add(this.groupBox_Table);
            this.Controls.Add(this.groupBox_Data);
            this.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DeleteTable";
            this.Text = "Delete Table";
            this.Load += new System.EventHandler(this.DeleteTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).EndInit();
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.DataGridView dataGridView_Table;
        private System.Windows.Forms.CheckedListBox checkedListBox_Table;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.GroupBox groupBox_Table;
    }
}