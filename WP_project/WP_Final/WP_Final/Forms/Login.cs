using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WP_Final.Classes;

namespace WP_Final.Forms
{
    public partial class Login : Form
    {
        public static bool administrator = false;

        public Login()
        {
            InitializeComponent();
            textBox_Id.ForeColor = Color.Gray;
            textBox_Password.ForeColor = Color.Gray;
            administrator = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            button_Exit.Click += CustomForm.Exit_Click;

            textBox_Id.Enter += CustomForm.textBox_Id_Enter;
            textBox_Id.Leave += CustomForm.textBox_Id_Leave;
            textBox_Password.Enter += CustomForm.textBox_Password_Enter;
            textBox_Password.Leave += CustomForm.textBox_Password_Leave;

            textBox_Id.Text = CustomForm.DEFAULT_ID;
            textBox_Password.Text = CustomForm.DEFAULT_PASSWORD;
        }
            
        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Custom.connUsers.Open();
                string query = "SELECT * FROM Users WHERE username = '" + textBox_Id.Text + "' AND password = '" + textBox_Password.Text + "'";
                if (textBox_Id.Text.Equals("admin") && textBox_Password.Text.Equals("admin")){
                    if (Custom.connUsers.State == ConnectionState.Open) Custom.connUsers.Close();
                    administrator = true;
                    CustomForm.SwitchToForm(this, new MainWindow());
                }
                else if (new SqlCommand(@query, Custom.connUsers).ExecuteReader().Read())
                {
                    if (Custom.connUsers.State == ConnectionState.Open) Custom.connUsers.Close();
                    administrator = false;
                    CustomForm.SwitchToForm(this, new MainWindow());
                }
                else
                {
                    CustomForm.ShowDialogPause(this, "Login Failed");
                }
            }
            catch (Exception ex)
            {
                CustomForm.ShowDialogException(this, ex);
            }
            finally
            {
                if(Custom.connUsers.State == ConnectionState.Open) Custom.connUsers.Close();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
