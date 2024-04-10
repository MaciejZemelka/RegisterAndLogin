namespace RegAndLog
{
    partial class Login
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
            this.u_login = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.show_pass = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.Signup = new System.Windows.Forms.LinkLabel();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // u_login
            // 
            this.u_login.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_login.Location = new System.Drawing.Point(84, 85);
            this.u_login.Name = "u_login";
            this.u_login.Size = new System.Drawing.Size(205, 39);
            this.u_login.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(79, 52);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(221, 29);
            this.UserName.TabIndex = 5;
            this.UserName.Text = "Username \\ email";
            // 
            // show_pass
            // 
            this.show_pass.Location = new System.Drawing.Point(295, 191);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(50, 23);
            this.show_pass.TabIndex = 20;
            this.show_pass.Text = "show";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.Click += new System.EventHandler(this.show_pass_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(84, 181);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(205, 39);
            this.password.TabIndex = 19;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(83, 137);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(127, 29);
            this.Pass.TabIndex = 18;
            this.Pass.Text = "Password";
            // 
            // Signup
            // 
            this.Signup.AutoSize = true;
            this.Signup.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.Location = new System.Drawing.Point(233, 257);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(92, 25);
            this.Signup.TabIndex = 22;
            this.Signup.TabStop = true;
            this.Signup.Text = "Sign up";
            this.Signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signup_LinkClicked);
            // 
            // SignInBtn
            // 
            this.SignInBtn.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.Location = new System.Drawing.Point(84, 244);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(122, 48);
            this.SignInBtn.TabIndex = 21;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 355);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.show_pass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.u_login);
            this.Controls.Add(this.UserName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox u_login;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button show_pass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.LinkLabel Signup;
        private System.Windows.Forms.Button SignInBtn;
    }
}