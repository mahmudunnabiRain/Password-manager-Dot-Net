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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.signup_password_input = new System.Windows.Forms.TextBox();
            this.signup_submit = new System.Windows.Forms.Button();
            this.instruction_label = new System.Windows.Forms.Label();
            this.signup_panel = new System.Windows.Forms.Panel();
            this.checkBox_signup_show_pass = new System.Windows.Forms.CheckBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.checkBox_show_login_pass = new System.Windows.Forms.CheckBox();
            this.login_label = new System.Windows.Forms.Label();
            this.login_pass_input = new System.Windows.Forms.TextBox();
            this.signup_panel.SuspendLayout();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signup_password_input
            // 
            this.signup_password_input.BackColor = System.Drawing.Color.Black;
            this.signup_password_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_password_input.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password_input.ForeColor = System.Drawing.Color.GhostWhite;
            this.signup_password_input.Location = new System.Drawing.Point(79, 142);
            this.signup_password_input.MaxLength = 10;
            this.signup_password_input.Name = "signup_password_input";
            this.signup_password_input.Size = new System.Drawing.Size(287, 36);
            this.signup_password_input.TabIndex = 1;
            this.signup_password_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.signup_password_input.UseSystemPasswordChar = true;
            this.signup_password_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_password_input_KeyDown);
            this.signup_password_input.Validating += new System.ComponentModel.CancelEventHandler(this.Main_password_input_Validating);
            // 
            // signup_submit
            // 
            this.signup_submit.BackColor = System.Drawing.Color.DarkGreen;
            this.signup_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_submit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_submit.ForeColor = System.Drawing.Color.GhostWhite;
            this.signup_submit.Location = new System.Drawing.Point(79, 188);
            this.signup_submit.Name = "signup_submit";
            this.signup_submit.Size = new System.Drawing.Size(287, 33);
            this.signup_submit.TabIndex = 2;
            this.signup_submit.Text = "SUBMIT";
            this.signup_submit.UseVisualStyleBackColor = false;
            this.signup_submit.Click += new System.EventHandler(this.Signup_submit_Click);
            // 
            // instruction_label
            // 
            this.instruction_label.AutoSize = true;
            this.instruction_label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.instruction_label.Location = new System.Drawing.Point(140, 108);
            this.instruction_label.Name = "instruction_label";
            this.instruction_label.Size = new System.Drawing.Size(166, 24);
            this.instruction_label.TabIndex = 3;
            this.instruction_label.Text = "Set a new PIN";
            // 
            // signup_panel
            // 
            this.signup_panel.BackColor = System.Drawing.Color.Transparent;
            this.signup_panel.Controls.Add(this.checkBox_signup_show_pass);
            this.signup_panel.Controls.Add(this.instruction_label);
            this.signup_panel.Controls.Add(this.signup_password_input);
            this.signup_panel.Controls.Add(this.signup_submit);
            this.signup_panel.Location = new System.Drawing.Point(169, 12);
            this.signup_panel.Name = "signup_panel";
            this.signup_panel.Size = new System.Drawing.Size(437, 337);
            this.signup_panel.TabIndex = 4;
            this.signup_panel.Visible = false;
            // 
            // checkBox_signup_show_pass
            // 
            this.checkBox_signup_show_pass.AutoSize = true;
            this.checkBox_signup_show_pass.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_signup_show_pass.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox_signup_show_pass.Location = new System.Drawing.Point(372, 148);
            this.checkBox_signup_show_pass.Name = "checkBox_signup_show_pass";
            this.checkBox_signup_show_pass.Size = new System.Drawing.Size(61, 23);
            this.checkBox_signup_show_pass.TabIndex = 4;
            this.checkBox_signup_show_pass.Text = "Show";
            this.checkBox_signup_show_pass.UseVisualStyleBackColor = true;
            this.checkBox_signup_show_pass.CheckedChanged += new System.EventHandler(this.CheckBox_signup_show_pass_CheckedChanged);
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.Transparent;
            this.login_panel.Controls.Add(this.checkBox_show_login_pass);
            this.login_panel.Controls.Add(this.login_label);
            this.login_panel.Controls.Add(this.login_pass_input);
            this.login_panel.Location = new System.Drawing.Point(169, 12);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(437, 337);
            this.login_panel.TabIndex = 5;
            this.login_panel.Visible = false;
            // 
            // checkBox_show_login_pass
            // 
            this.checkBox_show_login_pass.AutoSize = true;
            this.checkBox_show_login_pass.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_login_pass.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox_show_login_pass.Location = new System.Drawing.Point(372, 148);
            this.checkBox_show_login_pass.Name = "checkBox_show_login_pass";
            this.checkBox_show_login_pass.Size = new System.Drawing.Size(61, 23);
            this.checkBox_show_login_pass.TabIndex = 4;
            this.checkBox_show_login_pass.Text = "Show";
            this.checkBox_show_login_pass.UseVisualStyleBackColor = true;
            this.checkBox_show_login_pass.CheckedChanged += new System.EventHandler(this.CheckBox_show_login_pass_CheckedChanged);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.login_label.Location = new System.Drawing.Point(188, 108);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(70, 24);
            this.login_label.TabIndex = 3;
            this.login_label.Text = "Login";
            // 
            // login_pass_input
            // 
            this.login_pass_input.BackColor = System.Drawing.Color.Black;
            this.login_pass_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_pass_input.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_pass_input.ForeColor = System.Drawing.Color.GhostWhite;
            this.login_pass_input.Location = new System.Drawing.Point(79, 142);
            this.login_pass_input.MaxLength = 10;
            this.login_pass_input.Name = "login_pass_input";
            this.login_pass_input.Size = new System.Drawing.Size(287, 36);
            this.login_pass_input.TabIndex = 1;
            this.login_pass_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_pass_input.UseSystemPasswordChar = true;
            this.login_pass_input.TextChanged += new System.EventHandler(this.Login_pass_input_TextChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.signup_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.signup_panel);
            this.Controls.Add(this.login_panel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahmudunnabi Rain";
            this.signup_panel.ResumeLayout(false);
            this.signup_panel.PerformLayout();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox signup_password_input;
        private System.Windows.Forms.Button signup_submit;
        private System.Windows.Forms.Label instruction_label;
        private System.Windows.Forms.Panel signup_panel;
        private System.Windows.Forms.CheckBox checkBox_signup_show_pass;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.CheckBox checkBox_show_login_pass;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox login_pass_input;
    }
}

