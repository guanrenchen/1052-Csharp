namespace Homework2
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            this.label_Timer = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_HitRemain = new System.Windows.Forms.Label();
            this.timer_Game = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Timer.Location = new System.Drawing.Point(875, 245);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(247, 47);
            this.label_Timer.TabIndex = 1;
            this.label_Timer.Text = "label_Timer";
            this.label_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Score.Location = new System.Drawing.Point(875, 66);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(241, 47);
            this.label_Score.TabIndex = 2;
            this.label_Score.Text = "label_Score";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Start.Location = new System.Drawing.Point(869, 375);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(149, 74);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_Exit.Location = new System.Drawing.Point(1062, 375);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(149, 74);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_HitRemain
            // 
            this.label_HitRemain.AutoSize = true;
            this.label_HitRemain.Font = new System.Drawing.Font("PMingLiU", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_HitRemain.Location = new System.Drawing.Point(875, 169);
            this.label_HitRemain.Name = "label_HitRemain";
            this.label_HitRemain.Size = new System.Drawing.Size(336, 47);
            this.label_HitRemain.TabIndex = 2;
            this.label_HitRemain.Text = "label_HitRemain";
            // 
            // timer_Game
            // 
            this.timer_Game.Tick += new System.EventHandler(this.timer_Game_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 656);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_HitRemain);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label_Timer);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_HitRemain;
        private System.Windows.Forms.Timer timer_Game;
    }
}

