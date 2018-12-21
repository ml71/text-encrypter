/**
 * 
What is this application and what does it do?

This application is a text; it encrypts and decrypts text.


What special features do you want me to be aware of?

When the user first opens the application, 
they are told to either login or create a password depending on if a password already exists.
When they get to the encrypt panel, 
they can choose to encrypt or decrypt text under encryption in the menu.
On the encryption page, 
there is a checkbox that allows the user to decide whether to include or skip non-ascii characters
The user can change their password, logout, go to the about tab, or choose to reset the application.
The reset application function wouldn't be practical in a normal app; 
it is used to erase the password and "restore" the application for the purpose of testing it.


What did you find most interesting in your learning for this assignment? 
Did you run into any challenges?

The most interesting part was the event-driven nature of the program,
since it differed from what I was previously accustomed to.
One of the biggest challenges was trying to make different pages appear. 
Eventually, I decided to stack the panels on top of one another.
Although it is not the most efficient method, due to the time constraint,
it was difficult to master a more complex method.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinMaggieTextEncrypter.Properties;        //allows form to save user settings

namespace LinMaggieTextEncrypter
{
    public partial class FormTextEncrypter : Form
    {
        public bool toChangePassword = false;       //tracks when the user wants to change password
        public bool isEncrypt = true;               //remembers whether user wants to encrypt or decrypt text
        public bool isLoggedIn = false;             //tracks if user is logged in

        public FormTextEncrypter()
        {
            InitializeComponent();
            //start with welcome (intro) panel
            ShowPnlWelcome();
            this.Size = new System.Drawing.Size(400, 400);      //set form size
            //makes all panels appear at same location
            pnlAbout.Location = new Point(0, 24);
            pnlCurrentPassword.Location = new Point(0, 24);
            pnlEncrypt.Location = new Point(0, 24);
            pnlNewPassword.Location = new Point(0, 24);
            pnlWelcome.Location = new Point(0, 24);

        }

        //when OK button is clicked in new password panel
        private void btnNewPasswordOK_Click(object sender, EventArgs e)
        {
            //if the password is not the same as the confirm password box
            if (txtNewPasswordPassword.Text != txtNewPasswordConfirmPassword.Text)
            {
                //shows error message box
                MessageBox.Show("These passwords do not match. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPasswordPassword.Select();    //places cursor in text box

            }
            else if (String.IsNullOrEmpty(txtNewPasswordPassword.Text))     //if passwords match, but string is empty
            {
                //shows error message box
                MessageBox.Show("Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNewPasswordPassword.Select();    //places cursor in text box
            }
            else
            {
                //save password
                Settings.Default.Password = txtNewPasswordPassword.Text;
                Settings.Default.Save();
                //Console.WriteLine("PASSWORD when they match: " + Settings.Default.Password.ToString());  //prints password to output

                //go to encrypt panel
                ShowPnlEncryptEncrypt();
            }
        }
 
        //when OK is clicked in current password panel
        private void btnCurrentPasswordOK_Click(object sender, EventArgs e)
        {
            //if the password is incorrect
            if (Settings.Default.Password.ToString() != txtCurrentPassword.Text)
            {
                //shows error message box
                MessageBox.Show("The password you entered is incorrect. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //text box is emptied
                txtCurrentPassword.Text = String.Empty;
                txtCurrentPassword.Select();
            }
            else if (!toChangePassword)     //if user does not want to change password
            {
                ShowPnlEncryptEncrypt();                 //show encrpyt page
                txtCurrentPassword.Text = String.Empty;
                isLoggedIn = true;
            }
            else                            //if user wants to change password
            {
                ShowPnlNewPassword();       //show new password panel
                toChangePassword = false;
                isLoggedIn = true;
            }

        }


        //when encrypt/decrypt button is clicked
        private void btnEncryptAction_Click(object sender, EventArgs e)
        {
            if (isEncrypt)
            {
                txtEncryptOutput.Text = Encrypter.EncryptText(txtEncryptInput.Text, chkPrintChar.Checked);        //encrypts text if Encrypt is clicked
            }
            else
            {
                txtEncryptOutput.Text = Encrypter.DecryptText(txtEncryptInput.Text, chkPrintChar.Checked);        //decrypts text if Decrypt is clicked
            }

        }

        //when reset application is clicked in menu
        private void menuItemAboutResetApplication_Click(object sender, EventArgs e)
        {
            //password is removed
            Settings.Default.Password = String.Empty;
            Settings.Default.Save();
            //Console.WriteLine("Password when reset: " + Settings.Default.Password.ToString());
            btnWelcomeLogin.Enabled = false;            //cannot login since there is no password
            btnWelcomeCreatePassword.Enabled = true;
            ShowPnlWelcome();                           //returns to welcome panel
            isLoggedIn = false;
        }

        //when encrypt is clicked in menu
        private void menuItemEncryptionEncrypt_Click(object sender, EventArgs e)
        {
            ShowPnlEncryptEncrypt();        //show encrypt panel that encrypts text
        }

        //when decrypt is clicked in menu
        private void menuItemEncryptionDecrypt_Click(object sender, EventArgs e)
        {
            ShowPnlEncryptDecrypt();        //show encrpyt panel that decrypts text
        }

        //when clear all is clicked in encrypt panel
        private void btnEncryptClearAll_Click(object sender, EventArgs e)
        {
            //empties text boxes
            txtEncryptOutput.Text = String.Empty;
            txtEncryptInput.Text = String.Empty;
        }

        //when the copy output button is clicked
        private void btnEncryptCopyOutput_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEncryptOutput.Text))       //if the output is not null or empty
                Clipboard.SetText(txtEncryptOutput.Text);           //output is copied to clipboard
        }

        //when the paste button is clicked
        private void btnEncryptPaste_Click(object sender, EventArgs e)
        {
            txtEncryptInput.Paste(Clipboard.GetText());             //pastes clipboard to input box
            //puts cursor at end of text box
            txtEncryptInput.Select();
            txtEncryptInput.Select(txtEncryptInput.Text.Length, 0);
        }

        //shows panel where user enters new password and confirms password
        public void ShowPnlNewPassword()
        {
            //empties text boxes
            txtNewPasswordPassword.Text = String.Empty;
            txtNewPasswordConfirmPassword.Text = String.Empty;
            
            //controls which panels are visible
            pnlNewPassword.Visible = true;
            pnlCurrentPassword.Visible = false;
            pnlEncrypt.Visible = false;
            pnlWelcome.Visible = false;
            pnlAbout.Visible = false;
            
            //which menu items are accessible
            menuItemEncryption.Enabled = false;
            menuItemUser.Enabled = false;
            menuItemAboutAbout.Enabled = false;

            txtNewPasswordPassword.Select();        //places cursor in text box
        }

        //shows panel for user to enter their current password
        public void ShowPnlCurrentPassword()
        {
            //which menu items are accessible
            menuItemEncryption.Enabled = false;
            menuItemUser.Enabled = false;
            menuItemAboutAbout.Enabled = false;
            
            //empties text box
            txtCurrentPassword.Text = String.Empty;
            
            //controls which panels are visible
            pnlNewPassword.Visible = false;
            pnlCurrentPassword.Visible = true;
            pnlEncrypt.Visible = false;
            pnlWelcome.Visible = false;
            pnlAbout.Visible = false;

            txtCurrentPassword.Select();        //places cursor in text box

        }

        //shows welcome panel
        public void ShowPnlWelcome()
        {
            //which menu items are accessible
            menuItemEncryption.Enabled = false;
            menuItemUser.Enabled = false;
            menuItemAboutAbout.Enabled = true;
            
            //controls which panels are visible
            pnlNewPassword.Visible = false;
            pnlCurrentPassword.Visible = false;
            pnlEncrypt.Visible = false;
            pnlWelcome.Visible = true;
            pnlAbout.Visible = false;
        }

        //shows encrypt panel prepared for encrypting
        public void ShowPnlEncryptEncrypt()
        {
            //which menu items are accessible
            menuItemEncryption.Enabled = true;
            menuItemUser.Enabled = true;
            menuItemAboutAbout.Enabled = true;

            //button allows user to encrypt text
            isEncrypt = true;
            btnEncryptAction.Text = "Encrypt";
            txtEncryptOutput.Text = String.Empty;
            txtEncryptInput.Text = String.Empty;
            
            //controls which panels are visible
            pnlNewPassword.Visible = false;
            pnlCurrentPassword.Visible = false;
            pnlEncrypt.Visible = true;
            pnlWelcome.Visible = false;
            pnlAbout.Visible = false;

            txtEncryptInput.Select();       //places cursor in text box
            isLoggedIn = true;
        }

        //shows encrypt panel prepared for decrypting
        public void ShowPnlEncryptDecrypt()
        {
            //which menu items are accessible
            menuItemEncryption.Enabled = true;
            menuItemUser.Enabled = true;
            menuItemAboutAbout.Enabled = true;

            //button allows user to decrypt text
            isEncrypt = false;
            btnEncryptAction.Text = "Decrypt";
            txtEncryptOutput.Text = String.Empty;
            txtEncryptInput.Text = String.Empty;
            //controls which panels are visible
            pnlNewPassword.Visible = false;
            pnlCurrentPassword.Visible = false;
            pnlEncrypt.Visible = true;
            pnlWelcome.Visible = false;
            pnlAbout.Visible = false;

            txtEncryptInput.Select();       //places cursor in text box 
            isLoggedIn = true;
        }

        //shows about panel
        public void ShowPnlAbout()
        {
            //which menu items are accessible
            if (isLoggedIn)
                menuItemEncryption.Enabled = true;  //can encrypt text if logged in
            else
                menuItemEncryption.Enabled = false; //cannot encrypt text if not logged in

            menuItemUser.Enabled = false;
            menuItemAboutAbout.Enabled = false;
            //controls which panels are visible
            pnlNewPassword.Visible = false;
            pnlCurrentPassword.Visible = false;
            pnlEncrypt.Visible = false;
            pnlWelcome.Visible = false;
            pnlAbout.Visible = true;
        }

        //when about is clicked in menu
        private void menuItemAboutAbout_Click(object sender, EventArgs e)
        {
            ShowPnlAbout();     //takes user to about panel
        }

        //when login is clicked on welcome panel
        private void btnWelcomeLogin_Click(object sender, EventArgs e)
        {
            ShowPnlCurrentPassword();               //takes user to panel to enter password
            lblCurrentPassword.Text = "Password:";  //changes label to "Password"
        }

        //when create password is clicked on welcome panel
        private void btnWelcomeCreatePassword_Click(object sender, EventArgs e)
        {
            ShowPnlNewPassword();   //allows user to create password
        }

        //when logout is clicked in menu
        private void menuItemUserLogout_Click(object sender, EventArgs e)
        {
            ShowPnlWelcome();       //goes to welcome panel
            isLoggedIn = false;
        }

        //when welcome panel appears
        private void pnlWelcome_Paint(object sender, PaintEventArgs e)
        {
            if (String.IsNullOrEmpty(Settings.Default.Password))
            {
                //if password does not exist, user can create password and cannot login
                btnWelcomeCreatePassword.Enabled = true;
                btnWelcomeLogin.Enabled = false;
            }
            else
            {
                //if password exists, user can only login and cannot create password
                btnWelcomeCreatePassword.Enabled = false;
                btnWelcomeLogin.Enabled = true;
            }
        }

        //when about button is clicked on about page
        private void btnAboutOK_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                ShowPnlEncryptEncrypt();        //if user is already logged in, takes them back to encrypt panel
            }
            else
            {
                ShowPnlWelcome();               //if user is not logged in, takes them to welcome panel
            }
        }

        //when cancel is clicked on new password panel
        private void btnNewPasswordCancel_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Settings.Default.Password))
                ShowPnlWelcome();           //if password does not exist, return to welcome panel
            else
                ShowPnlEncryptEncrypt();    //if password already exists, return to encrypt panel
        }

        //when change password is clicked in menu
        private void menuItemUserChangePassword_Click(object sender, EventArgs e)
        {
            toChangePassword = true;
            ShowPnlCurrentPassword();       //take user to enter current password
            lblCurrentPassword.Text = "Current Password:";      //changes label "Current Password:"
        }

        //when cancel is clicked on current password panel
        private void btnCurrentPasswordCancel_Click(object sender, EventArgs e)
        {
            //decides which page to take user to
            if (toChangePassword)
            {
                toChangePassword = false;
                ShowPnlEncryptEncrypt();    //return to encrypt page
            }
            else
                ShowPnlWelcome();       //return to welcome page

        }

        //when exit is clicked in menu
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();       //closes text encrypter form
        }
        
    }
}
