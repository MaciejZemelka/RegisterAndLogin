namespace RegAndLog
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignIn = new System.Windows.Forms.LinkLabel();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_date = new System.Windows.Forms.DateTimePicker();
            this.con_password = new System.Windows.Forms.TextBox();
            this.ConPass = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.u_name = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.show_pass = new System.Windows.Forms.Button();
            this.show_con_pass = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.show_con_pass);
            this.panel1.Controls.Add(this.show_pass);
            this.panel1.Controls.Add(this.SignIn);
            this.panel1.Controls.Add(this.SignUpBtn);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.b_date);
            this.panel1.Controls.Add(this.con_password);
            this.panel1.Controls.Add(this.ConPass);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Pass);
            this.panel1.Controls.Add(this.BirthDate);
            this.panel1.Controls.Add(this.e_mail);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.u_name);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(84, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 672);
            this.panel1.TabIndex = 0;
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(260, 600);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(88, 25);
            this.SignIn.TabIndex = 16;
            this.SignIn.TabStop = true;
            this.SignIn.Text = "Sign In";
            this.SignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignIn_LinkClicked);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(92, 587);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(122, 48);
            this.SignUpBtn.TabIndex = 15;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(119, 361);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(205, 28);
            this.gender.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gender";
            // 
            // b_date
            // 
            this.b_date.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_date.Location = new System.Drawing.Point(119, 276);
            this.b_date.Name = "b_date";
            this.b_date.Size = new System.Drawing.Size(205, 21);
            this.b_date.TabIndex = 11;
            // 
            // con_password
            // 
            this.con_password.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_password.Location = new System.Drawing.Point(119, 521);
            this.con_password.Name = "con_password";
            this.con_password.PasswordChar = '*';
            this.con_password.Size = new System.Drawing.Size(205, 39);
            this.con_password.TabIndex = 10;
            // 
            // ConPass
            // 
            this.ConPass.AutoSize = true;
            this.ConPass.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConPass.Location = new System.Drawing.Point(114, 488);
            this.ConPass.Name = "ConPass";
            this.ConPass.Size = new System.Drawing.Size(234, 29);
            this.ConPass.TabIndex = 9;
            this.ConPass.Text = "Confirm Password";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(119, 429);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(205, 39);
            this.password.TabIndex = 8;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(114, 396);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(127, 29);
            this.Pass.TabIndex = 7;
            this.Pass.Text = "Password";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate.Location = new System.Drawing.Point(114, 243);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(131, 29);
            this.BirthDate.TabIndex = 5;
            this.BirthDate.Text = "BirthDate";
            // 
            // e_mail
            // 
            this.e_mail.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mail.Location = new System.Drawing.Point(119, 186);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(205, 39);
            this.e_mail.TabIndex = 4;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(114, 153);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(83, 29);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // u_name
            // 
            this.u_name.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_name.Location = new System.Drawing.Point(119, 98);
            this.u_name.Name = "u_name";
            this.u_name.Size = new System.Drawing.Size(205, 39);
            this.u_name.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(114, 65);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(131, 29);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // show_pass
            // 
            this.show_pass.Location = new System.Drawing.Point(330, 439);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(50, 23);
            this.show_pass.TabIndex = 17;
            this.show_pass.Text = "show";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.Click += new System.EventHandler(this.show_pass_Click);
            // 
            // show_con_pass
            // 
            this.show_con_pass.Location = new System.Drawing.Point(330, 531);
            this.show_con_pass.Name = "show_con_pass";
            this.show_con_pass.Size = new System.Drawing.Size(50, 23);
            this.show_con_pass.TabIndex = 18;
            this.show_con_pass.Text = "show";
            this.show_con_pass.UseVisualStyleBackColor = true;
            this.show_con_pass.Click += new System.EventHandler(this.show_con_pass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(641, 729);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox con_password;
        private System.Windows.Forms.Label ConPass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox u_name;
        private System.Windows.Forms.DateTimePicker b_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.LinkLabel SignIn;
        private System.Windows.Forms.Button show_pass;
        private System.Windows.Forms.Button show_con_pass;
    }
}

