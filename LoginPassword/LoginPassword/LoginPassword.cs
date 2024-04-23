using System.Reflection;
using System.Security.Cryptography.Xml;
using Microsoft.VisualBasic.Logging;

namespace LoginPassword
{
    public partial class LoginPassword : Form
    {
        private int situation = 0;
        string path = "loginPassword.dat";
        public LoginPassword()
        {
            InitializeComponent();
            wrongLoginLabel.Text = "";
            UpdateText();
            UpdateBackgroundColor();
        }
        private void UpdateBackgroundColor()
        {
            if(situation == 0 || situation == 1)
            {
                BackColor = SystemColors.ActiveCaption; 
                BackgroundImage = null;
            }
            else if(situation == 2)
            {
                BackgroundImage = Properties.Resources.cattt;

            }
        }
        private void UpdateText()
        {
            if (situation == 0)
            {
                signedIn.Text = "";
                LoginOrSignUpLabel.Text = "LOG IN";
                switchingBtn.Text = "Don't have an account? No problem just create one";
                UsernameLabel.Text = "Username:";
                PasswordLabel.Text = "Password";
                EnterBtn.Visible = true;
                switchingBtn.Visible = true;
                logintxt.Visible = true;
                passwordtxt.Visible = true;
            }
            else if (situation == 1)
            {
                wrongLoginLabel.Text = "";
                LoginOrSignUpLabel.Text = "SIGN UP";
                switchingBtn.Text = "Already have an account? then click here to sign in";

            }
            else if(situation == 2)
            {
                signedIn.Text = "You signed in succesfully!";
                LoginOrSignUpLabel.Text = "";
                wrongLoginLabel.Text = "";
                UsernameLabel.Text = "";
                PasswordLabel.Text = "";
                EnterBtn.Visible = false;
                switchingBtn.Visible = false;
                logintxt.Visible = false;
                passwordtxt.Visible = false;
            }
        }

        private void switchingBtn_Click(object sender, EventArgs e)
        {
            switch (situation)
            {
                case 0:
                    situation = 1;
                    break;
                case 1:
                    situation = 0;
                    break;
            }
            UpdateText();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logintxt.Text) || string.IsNullOrEmpty(passwordtxt.Text))
            {
                wrongLoginLabel.Text = "Wrong username or password. Please try again";
            }
            else if (situation == 0)
            {
                if (CheckLoginPassword(logintxt.Text, passwordtxt.Text, path))
                {
                    situation = 2;
                    UpdateText();
                }
                else
                {
                    wrongLoginLabel.Text = "Wrong username or password. Please try again";
                }
            }
            else if (situation == 1)
            {
                CreateAccount(logintxt.Text, passwordtxt.Text, path);
            }
            UpdateBackgroundColor();
        }
        static bool CheckLoginPassword(string enteredLogin, string enteredPassword, string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                string rightLogin = reader.ReadString();
                string rightPassword = reader.ReadString();
                if (rightLogin == enteredLogin && rightPassword == enteredPassword)
                {
                    return true;
                }
            }
            return false;
        }
        static void CreateAccount(string login, string password, string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(login);
                writer.Write(password);
            }
        }
    }
}
