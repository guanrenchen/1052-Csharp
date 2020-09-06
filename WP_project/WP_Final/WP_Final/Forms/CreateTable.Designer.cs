namespace WP_Final.Forms
{
    partial class CreateTable
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
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.dataGridView_CSV = new System.Windows.Forms.DataGridView();
            this.groupBox_File = new System.Windows.Forms.GroupBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label_TableName = new System.Windows.Forms.Label();
            this.label_FilePath = new System.Windows.Forms.Label();
            this.textBox_TableName = new System.Windows.Forms.TextBox();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.checkedListBox_Column = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_Row = new System.Windows.Forms.CheckedListBox();
            this.button_Browse = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.groupBox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CSV)).BeginInit();
            this.groupBox_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Data.Controls.Add(this.dataGridView_CSV);
            this.groupBox_Data.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Data.Location = new System.Drawing.Point(11, 11);
            this.groupBox_Data.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Data.Size = new System.Drawing.Size(503, 423);
            this.groupBox_Data.TabIndex = 6;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // dataGridView_CSV
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_CSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_CSV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_CSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_CSV.Location = new System.Drawing.Point(2, 47);
            this.dataGridView_CSV.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_CSV.Name = "dataGridView_CSV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_CSV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_CSV.RowHeadersVisible = false;
            this.dataGridView_CSV.RowHeadersWidth = 60;
            this.dataGridView_CSV.RowTemplate.Height = 35;
            this.dataGridView_CSV.Size = new System.Drawing.Size(499, 374);
            this.dataGridView_CSV.TabIndex = 1;
            // 
            // groupBox_File
            // 
            this.groupBox_File.Controls.Add(this.cartesianChart1);
            this.groupBox_File.Controls.Add(this.label_TableName);
            this.groupBox_File.Controls.Add(this.label_FilePath);
            this.groupBox_File.Controls.Add(this.textBox_TableName);
            this.groupBox_File.Controls.Add(this.textBox_FilePath);
            this.groupBox_File.Controls.Add(this.checkedListBox_Column);
            this.groupBox_File.Controls.Add(this.checkedListBox_Row);
            this.groupBox_File.Controls.Add(this.button_Browse);
            this.groupBox_File.Controls.Add(this.button_Add);
            this.groupBox_File.Controls.Add(this.button_Cancel);
            this.groupBox_File.Controls.Add(this.button_Apply);
            this.groupBox_File.Location = new System.Drawing.Point(518, 11);
            this.groupBox_File.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_File.Name = "groupBox_File";
            this.groupBox_File.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_File.Size = new System.Drawing.Size(447, 423);
            this.groupBox_File.TabIndex = 7;
            this.groupBox_File.TabStop = false;
            this.groupBox_File.Text = "File";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(102, 1);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(10, 10);
            this.cartesianChart1.TabIndex = 8;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label_TableName
            // 
            this.label_TableName.AutoSize = true;
            this.label_TableName.Font = new System.Drawing.Font("PMingLiU", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_TableName.Location = new System.Drawing.Point(27, 314);
            this.label_TableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TableName.Name = "label_TableName";
            this.label_TableName.Size = new System.Drawing.Size(91, 34);
            this.label_TableName.TabIndex = 13;
            this.label_TableName.Text = "Name";
            // 
            // label_FilePath
            // 
            this.label_FilePath.AutoSize = true;
            this.label_FilePath.Font = new System.Drawing.Font("PMingLiU", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_FilePath.Location = new System.Drawing.Point(19, 41);
            this.label_FilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FilePath.Name = "label_FilePath";
            this.label_FilePath.Size = new System.Drawing.Size(72, 34);
            this.label_FilePath.TabIndex = 14;
            this.label_FilePath.Text = "Path";
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_TableName.Location = new System.Drawing.Point(122, 314);
            this.textBox_TableName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TableName.Name = "textBox_TableName";
            this.textBox_TableName.Size = new System.Drawing.Size(310, 52);
            this.textBox_TableName.TabIndex = 11;
            this.textBox_TableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_FilePath.Location = new System.Drawing.Point(93, 41);
            this.textBox_FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.ReadOnly = true;
            this.textBox_FilePath.Size = new System.Drawing.Size(198, 52);
            this.textBox_FilePath.TabIndex = 12;
            // 
            // checkedListBox_Column
            // 
            this.checkedListBox_Column.CheckOnClick = true;
            this.checkedListBox_Column.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox_Column.FormattingEnabled = true;
            this.checkedListBox_Column.Location = new System.Drawing.Point(224, 96);
            this.checkedListBox_Column.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_Column.Name = "checkedListBox_Column";
            this.checkedListBox_Column.Size = new System.Drawing.Size(208, 200);
            this.checkedListBox_Column.TabIndex = 9;
            // 
            // checkedListBox_Row
            // 
            this.checkedListBox_Row.CheckOnClick = true;
            this.checkedListBox_Row.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox_Row.FormattingEnabled = true;
            this.checkedListBox_Row.Location = new System.Drawing.Point(12, 96);
            this.checkedListBox_Row.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_Row.Name = "checkedListBox_Row";
            this.checkedListBox_Row.Size = new System.Drawing.Size(208, 200);
            this.checkedListBox_Row.TabIndex = 10;
            // 
            // button_Browse
            // 
            this.button_Browse.Font = new System.Drawing.Font("PMingLiU", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Browse.Location = new System.Drawing.Point(298, 41);
            this.button_Browse.Margin = new System.Windows.Forms.Padding(5);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(134, 38);
            this.button_Browse.TabIndex = 6;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = true;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("PMingLiU", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Add.Location = new System.Drawing.Point(154, 373);
            this.button_Add.Margin = new System.Windows.Forms.Padding(5);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(142, 41);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("PMingLiU", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Cancel.Location = new System.Drawing.Point(298, 373);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(5);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(142, 41);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Apply
            // 
            this.button_Apply.Font = new System.Drawing.Font("PMingLiU", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Apply.Location = new System.Drawing.Point(7, 373);
            this.button_Apply.Margin = new System.Windows.Forms.Padding(5);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(142, 41);
            this.button_Apply.TabIndex = 8;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 436);
            this.Controls.Add(this.groupBox_File);
            this.Controls.Add(this.groupBox_Data);
            this.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateTable";
            this.Text = "Add Table";
            this.Load += new System.EventHandler(this.CreateTable_Load);
            this.groupBox_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CSV)).EndInit();
            this.groupBox_File.ResumeLayout(false);
            this.groupBox_File.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.GroupBox groupBox_File;
        private System.Windows.Forms.Label label_TableName;
        private System.Windows.Forms.Label label_FilePath;
        private System.Windows.Forms.TextBox textBox_TableName;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.CheckedListBox checkedListBox_Column;
        private System.Windows.Forms.CheckedListBox checkedListBox_Row;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Apply;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.DataGridView dataGridView_CSV;
        private System.Windows.Forms.Button button_Add;
    }
}