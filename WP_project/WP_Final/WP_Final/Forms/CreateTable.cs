using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_Final.Classes;

namespace WP_Final.Forms
{
    public partial class CreateTable : Form
    {
        public CreateTable()
        {
            InitializeComponent();
        }

        private void CreateTable_Load(object sender, EventArgs e)
        {
            checkedListBox_Row.Click += CustomForm.checkedListBox_Click;
            checkedListBox_Column.Click += CustomForm.checkedListBox_Click;
            button_Cancel.Click += CustomForm.Cancel_Click;
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {

            try{
                dataGridView_CSV.DataSource = null;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "CSV files (*.csv)|*.csv";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    textBox_FilePath.Text = ofd.FileName;
                    textBox_TableName.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                    dataGridView_CSV.DataSource = Custom.CsvToDataTable(ofd.FileName);
                    UpdateCheckedListBoxes();
                }
            }catch(Exception ex){
                CustomForm.ShowDialogException(this, ex);
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            try{
                DataTable dt = (DataTable)dataGridView_CSV.DataSource;
                for (int i = 1; i < dt.Columns.Count; ++i)
                    if (!checkedListBox_Column.CheckedItems.Contains(dt.Columns[i].ColumnName))
                        dt.Columns.RemoveAt(i--);
                for (int i = 0; i < dt.Rows.Count; ++i)
                    if (!checkedListBox_Row.CheckedItems.Contains(dt.Rows[i][0].ToString()))
                        dt.Rows.RemoveAt(i--);
                UpdateCheckedListBoxes();
            }catch(Exception ex){
                CustomForm.ShowDialogException(this, ex);
            }finally{
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView_CSV.DataSource;

                // make sure the table fit the standard
                int stringTypeCount = 0;
                foreach (DataColumn col in dt.Columns)
                    if (col.DataType.IsEquivalentTo(typeof(string)))
                        ++stringTypeCount;
                if (stringTypeCount != 1 || !dt.Columns[0].DataType.IsEquivalentTo(typeof(string)))
                {
                    CustomForm.ShowDialogPause(this, "Error : First column must be the one and only string type column");
                    return;
                }
                
                // create script & update table to database
                string script = Custom.CreateSqlTableFromDataTable(textBox_TableName.Text, dt);
                using (SqlCommand cmd = new SqlCommand(script, Custom.connOpenData))
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(Custom.connOpenData)){
                    bulkCopy.DestinationTableName = textBox_TableName.Text;
                    Custom.connOpenData.Open();
                    cmd.ExecuteNonQuery();
                    bulkCopy.WriteToServer(dt);
                }
                CustomForm.ShowDialogPause(this, "Table added to database.");
            }catch(Exception ex){
                CustomForm.ShowDialogException(this, ex);
            }finally{
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }
        
        private void UpdateCheckedListBoxes()
        {
            try{
                DataTable dt = (DataTable)dataGridView_CSV.DataSource;
                CustomForm.InitializeCheckedListBox(checkedListBox_Row, true);
                CustomForm.InitializeCheckedListBox(checkedListBox_Column, true);
                foreach (DataRow row in dt.Rows)
                    checkedListBox_Row.Items.Add(row[0].ToString(), true);
                foreach (DataColumn col in dt.Columns)
                    checkedListBox_Column.Items.Add(col.ColumnName, true);

                // make sure first column cannot be removed
                checkedListBox_Column.Items.RemoveAt(1);

            }catch(Exception ex){
                CustomForm.ShowDialogException(this, ex);
            }
        }
        
    }
}
