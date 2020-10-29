namespace WindowsFormsApp
{
    partial class LoginForm
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
            this.Welcome_label = new System.Windows.Forms.Label();
            this.main_password_input = new System.Windows.Forms.TextBox();
            this.Login_submit = new System.Windows.Forms.Button();
            this.instruction_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Welcome_label.Location = new System.Drawing.Point(336, 46);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(142, 24);
            this.Welcome_label.TabIndex = 0;
            this.Welcome_label.Text = "Welcome Sir";
            // 
            // main_password_input
            // 
            this.main_password_input.BackColor = System.Drawing.SystemColors.HotTrack;
            this.main_password_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_password_input.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_password_input.ForeColor = System.Drawing.Color.GhostWhite;
            this.main_password_input.Location = new System.Drawing.Point(258, 136);
            this.main_password_input.MaxLength = 10;
            this.main_password_input.Name = "main_password_input";
            this.main_password_input.Size = new System.Drawing.Size(287, 36);
            this.main_password_input.TabIndex = 1;
            this.main_password_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.main_password_input.TextChanged += new System.EventHandler(this.Main_password_input_TextChanged);
            this.main_password_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_password_input_KeyDown);
            this.main_password_input.Validating += new System.ComponentModel.CancelEventHandler(this.Main_password_input_Validating);
            // 
            // Login_submit
            // 
            this.Login_submit.BackColor = System.Drawing.Color.DodgerBlue;
            this.Login_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_submit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_submit.ForeColor = System.Drawing.Color.GhostWhite;
            this.Login_submit.Location = new System.Drawing.Point(258, 180);
            this.Login_submit.Name = "Login_submit";
            this.Login_submit.Size = new System.Drawing.Size(287, 33);
            this.Login_submit.TabIndex = 2;
            this.Login_submit.Text = "SUBMIT";
            this.Login_submit.UseVisualStyleBackColor = false;
            this.Login_submit.Click += new System.EventHandler(this.Login_submit_Click);
            // 
            // instruction_label
            // 
            this.instruction_label.AutoSize = true;
            this.instruction_label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.instruction_label.Location = new System.Drawing.Point(290, 102);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(226, 24);
            this.instruction_label.TabIndex = 3;
            this.instruction_label.Text = "Set a new password";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Login_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.instruction_label);
            this.Controls.Add(this.Login_submit);
            this.Controls.Add(this.main_password_input);
            this.Controls.Add(this.Welcome_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahmudunnabi Rain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.TextBox main_password_input;
        private System.Windows.Forms.Button Login_submit;
        private System.Windows.Forms.Label instruction_label;
    }
}

