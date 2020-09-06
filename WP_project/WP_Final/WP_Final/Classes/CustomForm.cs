using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Final.Classes
{
    class CustomForm
    {
        public const string DEFAULT_ID = "ID";
        public const string DEFAULT_PASSWORD = "password";

        // FORM TRANSISTION
        public static void SwitchToForm(Form oldForm, Form newForm)
        {
            oldForm.Hide();
            newForm.ShowDialog();
            oldForm.Close();
        }

        // FORM PAUSE
        public static void ShowDialogPause(Form form, string message)
        {
            form.Enabled = false;
            MessageBox.Show(message);
            form.Enabled = true;
        }
        public static void ShowDialogPause(Form oldForm, Form newForm)
        {
            oldForm.Enabled = false;
            newForm.ShowDialog();
            oldForm.Enabled = true;
        }
        public static void ShowDialogException(Form form, Exception ex)
        {
            form.Enabled = false;
            MessageBox.Show(ex.ToString());
            form.Enabled = true;
        }

        public static void Cancel_Click(object sender, EventArgs e)
        {
            ((Control)sender).FindForm().Close();
        }

        public static void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void InitializeCheckedListBox(CheckedListBox clb, bool firstItemChecked)
        {
            clb.Items.Clear();
            clb.Items.Add("Select All", firstItemChecked);
        }

        public static void checkedListBox_Click(object sender, EventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;
            if (clb.SelectedIndex != 0) return;
            bool checkAll = !clb.CheckedIndices.Contains(0);
            for (int i = 1; i < clb.Items.Count; ++i) clb.SetItemChecked(i, checkAll);
        }

        public static void textBox_Id_Enter(object sender, EventArgs e)
        {
            TextBox textBox_Id = (TextBox)sender;
            if (textBox_Id.Text.Equals(DEFAULT_ID))
            {
                textBox_Id.Text = "";
                textBox_Id.ForeColor = System.Drawing.Color.Black;
            }
        }

        public static void textBox_Id_Leave(object sender, EventArgs e)
        {
            TextBox textBox_Id = (TextBox)sender;
            if (textBox_Id.Text.Equals(""))
            {
                textBox_Id.Text = DEFAULT_ID;
                textBox_Id.ForeColor = System.Drawing.Color.Gray;
            }
        }

        public static void textBox_Password_Enter(object sender, EventArgs e)
        {
            TextBox textBox_Password = (TextBox)sender;
            if (textBox_Password.PasswordChar != '*')
            {
                textBox_Password.Text = "";
                textBox_Password.PasswordChar = '*';
                textBox_Password.ForeColor = System.Drawing.Color.Black;
            }
        }

        public static void textBox_Password_Leave(object sender, EventArgs e)
        {
            TextBox textBox_Password = (TextBox)sender;
            if (textBox_Password.Text.Equals(""))
            {
                textBox_Password.Text = DEFAULT_PASSWORD;
                textBox_Password.PasswordChar = '\0';
                textBox_Password.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
