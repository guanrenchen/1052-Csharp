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
using WP_Final.Classes;

namespace WP_Final.Forms
{
    public partial class DeleteTable : Form
    {
        public DeleteTable()
        {
            InitializeComponent();
        }

        private void DeleteTable_Load(object sender, EventArgs e)
        {
            checkedListBox_Table.Click += CustomForm.checkedListBox_Click;
            button_Cancel.Click += CustomForm.Cancel_Click;

            try
            {
                CustomForm.InitializeCheckedListBox(checkedListBox_Table, false);
                Custom.connOpenData.Open();
                foreach (DataRow row in Custom.connOpenData.GetSchema("Tables").Rows)
                    checkedListBox_Table.Items.Add(row[2].ToString(), false);
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                checkedListBox_Table.SelectedIndex = 0;
                //Delete checked tables
                Custom.connOpenData.Open();
                foreach (DataRow row in Custom.connOpenData.GetSchema("Tables").Rows)
                    if (checkedListBox_Table.CheckedItems.Contains((string)row[2]))
                    {
                        checkedListBox_Table.Items.Remove((string)row[2]);
                        using (SqlCommand cmd = new SqlCommand("DROP TABLE IF EXISTS " + (string)row[2], Custom.connOpenData))
                            cmd.ExecuteNonQuery();
                    }
                CustomForm.ShowDialogPause(this, "Selected Table Deleted.");
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }
        
        private void checkedListBox_Table_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBox_Table.SelectedItem.ToString().Equals("Select All"))
                {
                    dataGridView_Table.DataSource = null;
                    return;
                }

                Custom.connOpenData.Open();
                DataTable table = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + checkedListBox_Table.SelectedItem.ToString(), Custom.connOpenData))
                    adapter.Fill(table);
                dataGridView_Table.DataSource = table;    
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connOpenData.State == ConnectionState.Open) Custom.connOpenData.Close();
            }
        }

    }
}
