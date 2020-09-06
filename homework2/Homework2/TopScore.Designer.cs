namespace Homework2
{
    partial class TopScore
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Challenger = new System.Windows.Forms.TextBox();
            this.label_Challenger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Exit.Location = new System.Drawing.Point(211, 256);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(119, 68);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "EXIT";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Save.Location = new System.Drawing.Point(42, 256);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(119, 68);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_Challenger
            // 
            this.textBox_Challenger.Location = new System.Drawing.Point(12, 217);
            this.textBox_Challenger.Name = "textBox_Challenger";
            this.textBox_Challenger.Size = new System.Drawing.Size(352, 33);
            this.textBox_Challenger.TabIndex = 1;
            this.textBox_Challenger.Text = "your name";
            this.textBox_Challenger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Challenger
            // 
            this.label_Challenger.AutoSize = true;
            this.label_Challenger.Location = new System.Drawing.Point(137, 169);
            this.label_Challenger.Name = "label_Challenger";
            this.label_Challenger.Size = new System.Drawing.Size(95, 21);
            this.label_Challenger.TabIndex = 2;
            this.label_Challenger.Text = "your score";
            this.label_Challenger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 336);
            this.Controls.Add(this.label_Challenger);
            this.Controls.Add(this.textBox_Challenger);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Exit);
            this.Name = "TopScore";
            this.Text = "TopScore";
            this.Load += new System.EventHandler(this.TopScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_Challenger;
        private System.Windows.Forms.Label label_Challenger;
    }
}