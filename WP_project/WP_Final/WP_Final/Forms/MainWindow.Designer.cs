namespace WP_Final.Forms
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Chart = new System.Windows.Forms.GroupBox();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.button_Analyze = new System.Windows.Forms.Button();
            this.button_Draw = new System.Windows.Forms.Button();
            this.checkedListBox_Row = new System.Windows.Forms.CheckedListBox();
            this.comboBox_Chart = new System.Windows.Forms.ComboBox();
            this.label_Chart = new System.Windows.Forms.Label();
            this.comboBox_Table = new System.Windows.Forms.ComboBox();
            this.label_Table = new System.Windows.Forms.Label();
            this.groupBox_Analysis = new System.Windows.Forms.GroupBox();
            this.button_SortOrder = new System.Windows.Forms.Button();
            this.button_ShowChartDialog = new System.Windows.Forms.Button();
            this.comboBox_Column = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox_Chart.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.groupBox_Analysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1910, 48);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(87, 40);
            this.userToolStripMenuItem.Text = "User";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(216, 40);
            this.registerToolStripMenuItem.Text = "Manage";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(216, 40);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTableToolStripMenuItem,
            this.deleteTableToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(88, 40);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // addTableToolStripMenuItem
            // 
            this.addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            this.addTableToolStripMenuItem.Size = new System.Drawing.Size(273, 40);
            this.addTableToolStripMenuItem.Text = "Add Table";
            this.addTableToolStripMenuItem.Click += new System.EventHandler(this.addTableToolStripMenuItem_Click);
            // 
            // deleteTableToolStripMenuItem
            // 
            this.deleteTableToolStripMenuItem.Name = "deleteTableToolStripMenuItem";
            this.deleteTableToolStripMenuItem.Size = new System.Drawing.Size(273, 40);
            this.deleteTableToolStripMenuItem.Text = "Delete Table";
            this.deleteTableToolStripMenuItem.Click += new System.EventHandler(this.deleteTableToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(92, 40);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relationToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(106, 40);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // relationToolStripMenuItem
            // 
            this.relationToolStripMenuItem.Name = "relationToolStripMenuItem";
            this.relationToolStripMenuItem.Size = new System.Drawing.Size(216, 40);
            this.relationToolStripMenuItem.Text = "Relation";
            this.relationToolStripMenuItem.Click += new System.EventHandler(this.relationToolStripMenuItem_Click);
            // 
            // groupBox_Chart
            // 
            this.groupBox_Chart.Controls.Add(this.cartesianChart1);
            this.groupBox_Chart.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Chart.Location = new System.Drawing.Point(530, 51);
            this.groupBox_Chart.Name = "groupBox_Chart";
            this.groupBox_Chart.Size = new System.Drawing.Size(1368, 967);
            this.groupBox_Chart.TabIndex = 13;
            this.groupBox_Chart.TabStop = false;
            this.groupBox_Chart.Text = "Chart";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cartesianChart1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cartesianChart1.Location = new System.Drawing.Point(3, 48);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1362, 916);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.DataClick += new LiveCharts.Events.DataClickHandler(this.cartesianChart1_DataClick);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.button_Analyze);
            this.groupBox_Data.Controls.Add(this.button_Draw);
            this.groupBox_Data.Controls.Add(this.checkedListBox_Row);
            this.groupBox_Data.Controls.Add(this.comboBox_Chart);
            this.groupBox_Data.Controls.Add(this.label_Chart);
            this.groupBox_Data.Controls.Add(this.comboBox_Table);
            this.groupBox_Data.Controls.Add(this.label_Table);
            this.groupBox_Data.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Data.Location = new System.Drawing.Point(12, 551);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(512, 467);
            this.groupBox_Data.TabIndex = 6;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "Data";
            // 
            // button_Analyze
            // 
            this.button_Analyze.Location = new System.Drawing.Point(341, 41);
            this.button_Analyze.Name = "button_Analyze";
            this.button_Analyze.Size = new System.Drawing.Size(160, 47);
            this.button_Analyze.TabIndex = 10;
            this.button_Analyze.Text = "Analyze";
            this.button_Analyze.UseVisualStyleBackColor = true;
            this.button_Analyze.Click += new System.EventHandler(this.button_Analyze_Click);
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(341, 95);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(162, 43);
            this.button_Draw.TabIndex = 9;
            this.button_Draw.Text = "Draw";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // checkedListBox_Row
            // 
            this.checkedListBox_Row.CheckOnClick = true;
            this.checkedListBox_Row.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkedListBox_Row.FormattingEnabled = true;
            this.checkedListBox_Row.Location = new System.Drawing.Point(8, 152);
            this.checkedListBox_Row.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBox_Row.MultiColumn = true;
            this.checkedListBox_Row.Name = "checkedListBox_Row";
            this.checkedListBox_Row.Size = new System.Drawing.Size(493, 292);
            this.checkedListBox_Row.TabIndex = 8;
            // 
            // comboBox_Chart
            // 
            this.comboBox_Chart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Chart.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Chart.FormattingEnabled = true;
            this.comboBox_Chart.Location = new System.Drawing.Point(120, 96);
            this.comboBox_Chart.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_Chart.Name = "comboBox_Chart";
            this.comboBox_Chart.Size = new System.Drawing.Size(215, 64);
            this.comboBox_Chart.TabIndex = 5;
            // 
            // label_Chart
            // 
            this.label_Chart.AutoSize = true;
            this.label_Chart.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Chart.Location = new System.Drawing.Point(10, 96);
            this.label_Chart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Chart.Name = "label_Chart";
            this.label_Chart.Size = new System.Drawing.Size(99, 37);
            this.label_Chart.TabIndex = 4;
            this.label_Chart.Text = "Chart";
            // 
            // comboBox_Table
            // 
            this.comboBox_Table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Table.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Table.FormattingEnabled = true;
            this.comboBox_Table.Location = new System.Drawing.Point(120, 43);
            this.comboBox_Table.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_Table.Name = "comboBox_Table";
            this.comboBox_Table.Size = new System.Drawing.Size(215, 64);
            this.comboBox_Table.Sorted = true;
            this.comboBox_Table.TabIndex = 5;
            this.comboBox_Table.TextChanged += new System.EventHandler(this.UpdateTable);
            this.comboBox_Table.Click += new System.EventHandler(this.UpdateComboBoxTable);
            // 
            // label_Table
            // 
            this.label_Table.AutoSize = true;
            this.label_Table.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Table.Location = new System.Drawing.Point(10, 43);
            this.label_Table.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_Table.Name = "label_Table";
            this.label_Table.Size = new System.Drawing.Size(100, 37);
            this.label_Table.TabIndex = 4;
            this.label_Table.Text = "Table";
            // 
            // groupBox_Analysis
            // 
            this.groupBox_Analysis.Controls.Add(this.button_SortOrder);
            this.groupBox_Analysis.Controls.Add(this.button_ShowChartDialog);
            this.groupBox_Analysis.Controls.Add(this.comboBox_Column);
            this.groupBox_Analysis.Controls.Add(this.dataGridView1);
            this.groupBox_Analysis.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox_Analysis.Location = new System.Drawing.Point(12, 51);
            this.groupBox_Analysis.Name = "groupBox_Analysis";
            this.groupBox_Analysis.Size = new System.Drawing.Size(512, 494);
            this.groupBox_Analysis.TabIndex = 7;
            this.groupBox_Analysis.TabStop = false;
            this.groupBox_Analysis.Text = "Analysis";
            // 
            // button_SortOrder
            // 
            this.button_SortOrder.Location = new System.Drawing.Point(272, 447);
            this.button_SortOrder.Name = "button_SortOrder";
            this.button_SortOrder.Size = new System.Drawing.Size(115, 42);
            this.button_SortOrder.TabIndex = 9;
            this.button_SortOrder.Text = "desc";
            this.button_SortOrder.UseVisualStyleBackColor = true;
            this.button_SortOrder.Click += new System.EventHandler(this.button_SortOrder_Click);
            // 
            // button_ShowChartDialog
            // 
            this.button_ShowChartDialog.Location = new System.Drawing.Point(393, 446);
            this.button_ShowChartDialog.Name = "button_ShowChartDialog";
            this.button_ShowChartDialog.Size = new System.Drawing.Size(113, 43);
            this.button_ShowChartDialog.TabIndex = 8;
            this.button_ShowChartDialog.Text = "Show";
            this.button_ShowChartDialog.UseVisualStyleBackColor = true;
            this.button_ShowChartDialog.Click += new System.EventHandler(this.button_ShowChartDialog_Click);
            // 
            // comboBox_Column
            // 
            this.comboBox_Column.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Column.Font = new System.Drawing.Font("PMingLiU", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_Column.FormattingEnabled = true;
            this.comboBox_Column.Location = new System.Drawing.Point(8, 445);
            this.comboBox_Column.Name = "comboBox_Column";
            this.comboBox_Column.Size = new System.Drawing.Size(258, 64);
            this.comboBox_Column.Sorted = true;
            this.comboBox_Column.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(506, 391);
            this.dataGridView1.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1910, 1030);
            this.Controls.Add(this.groupBox_Analysis);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_Chart);
            this.Font = new System.Drawing.Font("PMingLiU", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.Text = "Normal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_Chart.ResumeLayout(false);
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.groupBox_Analysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_Chart;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.CheckedListBox checkedListBox_Row;
        private System.Windows.Forms.ComboBox comboBox_Chart;
        private System.Windows.Forms.Label label_Chart;
        private System.Windows.Forms.ComboBox comboBox_Table;
        private System.Windows.Forms.Label label_Table;
        private System.Windows.Forms.GroupBox groupBox_Analysis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ShowChartDialog;
        private System.Windows.Forms.ComboBox comboBox_Column;
        private System.Windows.Forms.Button button_Analyze;
        private System.Windows.Forms.Button button_SortOrder;
    }
}