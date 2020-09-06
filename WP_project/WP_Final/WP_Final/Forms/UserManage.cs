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
    public partial class UserManage : Form
    {
        public UserManage()
        {
            InitializeComponent();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {
            button_Cancel.Click += CustomForm.Cancel_Click;
            
            LoadUsersDataFromDB();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                Custom.connUsers.Open();
                using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Users", Custom.connUsers))
                    cmd.ExecuteNonQuery();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(Custom.connUsers))
                {
                    bulkCopy.DestinationTableName = "Users";
                    bulkCopy.WriteToServer((DataTable)dataGridView1.DataSource);
                }
                CustomForm.ShowDialogPause(this, "Data applied to database.");
            }
            catch(Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connUsers.State == ConnectionState.Open) Custom.connUsers.Close();
            }
        }

        private void LoadUsersDataFromDB()
        {
            try
            {
                DataTable dt = new DataTable();
                Custom.connUsers.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", Custom.connUsers))
                    adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if (Custom.connUsers.State == ConnectionState.Open) Custom.connUsers.Close();
            }
        }
    }
}
