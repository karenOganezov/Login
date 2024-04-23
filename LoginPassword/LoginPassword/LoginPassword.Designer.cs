namespace LoginPassword
{
    partial class LoginPassword
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logintxt = new TextBox();
            passwordtxt = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            EnterBtn = new Button();
            LoginOrSignUpLabel = new Label();
            switchingBtn = new Button();
            wrongLoginLabel = new Label();
            signedIn = new Label();
            SuspendLayout();
            // 
            // logintxt
            // 
            logintxt.Location = new Point(179, 158);
            logintxt.Name = "logintxt";
            logintxt.Size = new Size(208, 27);
            logintxt.TabIndex = 0;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(179, 200);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(208, 27);
            passwordtxt.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(95, 161);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(100, 203);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // EnterBtn
            // 
            EnterBtn.Location = new Point(226, 249);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(125, 40);
            EnterBtn.TabIndex = 4;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = true;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // LoginOrSignUpLabel
            // 
            LoginOrSignUpLabel.AutoSize = true;
            LoginOrSignUpLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LoginOrSignUpLabel.Location = new Point(226, 104);
            LoginOrSignUpLabel.Name = "LoginOrSignUpLabel";
            LoginOrSignUpLabel.Size = new Size(118, 41);
            LoginOrSignUpLabel.TabIndex = 5;
            LoginOrSignUpLabel.Text = "LOG IN";
            // 
            // switchingBtn
            // 
            switchingBtn.FlatAppearance.BorderColor = Color.White;
            switchingBtn.FlatAppearance.BorderSize = 0;
            switchingBtn.FlatStyle = FlatStyle.Flat;
            switchingBtn.Font = new Font("Segoe UI", 7F);
            switchingBtn.Location = new Point(205, 305);
            switchingBtn.Name = "switchingBtn";
            switchingBtn.Size = new Size(169, 45);
            switchingBtn.TabIndex = 6;
            switchingBtn.Text = " ";
            switchingBtn.UseVisualStyleBackColor = true;
            switchingBtn.Click += switchingBtn_Click;
            // 
            // wrongLoginLabel
            // 
            wrongLoginLabel.AutoSize = true;
            wrongLoginLabel.Font = new Font("Segoe UI", 6F);
            wrongLoginLabel.ForeColor = Color.FromArgb(192, 0, 0);
            wrongLoginLabel.Location = new Point(179, 234);
            wrongLoginLabel.Name = "wrongLoginLabel";
            wrongLoginLabel.Size = new Size(210, 12);
            wrongLoginLabel.TabIndex = 7;
            wrongLoginLabel.Text = "Wrong username or password. Please try again";
            // 
            // signedIn
            // 
            signedIn.AutoSize = true;
            signedIn.BackColor = Color.Transparent;
            signedIn.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            signedIn.Location = new Point(39, 305);
            signedIn.Name = "signedIn";
            signedIn.Size = new Size(526, 57);
            signedIn.TabIndex = 8;
            signedIn.Text = "You signed in succesfully!";
            // 
            // LoginPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(577, 450);
            Controls.Add(signedIn);
            Controls.Add(wrongLoginLabel);
            Controls.Add(switchingBtn);
            Controls.Add(LoginOrSignUpLabel);
            Controls.Add(EnterBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(passwordtxt);
            Controls.Add(logintxt);
            Name = "LoginPassword";
            Text = "LoginOrSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Logintxt;
        private TextBox passwordtxt;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Button EnterBtn;
        private Label LoginOrSignUpLabel;
        private Button switchingBtn;
        private Label wrongLoginLabel;
        private TextBox logintxt;
        private Label signedIn;
    }
}
