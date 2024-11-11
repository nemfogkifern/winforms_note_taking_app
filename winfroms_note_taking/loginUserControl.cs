using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winfroms_note_taking.Models;

namespace winfroms_note_taking
{
    public partial class loginUserControl : UserControl
    {
        PrivatDbContext _context = new PrivatDbContext();
        List<string> usernamesList = new List<string>();

        public User loggedInUser { get; private set; }

        public event EventHandler LoginSucceeded;


        public loginUserControl()
        {
            InitializeComponent();
            loadUserData();
        }

        private void loadUserData()
        {
            var usernames = (from k in _context.Users
                             select k.Username).ToList();
            usernamesList.AddRange(usernames);





            var passwords = from k in _context.Users
                            select k.Password;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            textBoxUsername.ForeColor = Color.White;
            panel7.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = Color.White;
            panel8.Visible = false;
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.SelectAll();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var enteredUsername = textBoxUsername.Text;
            var enteredPassword = textBoxPassword.Text;

            if (usernamesList.Contains(enteredUsername))
            {
                var hashedcorrectPassword = (from k in _context.Users
                                       where k.Username == enteredUsername
                                       select k.Password).ToList();
                panel7.Visible = false;



                bool passwordCorrect = BCrypt.Net.BCrypt.Verify(enteredPassword, hashedcorrectPassword[0]);

                if (passwordCorrect)
                {
                    loggedInUser = (from k in _context.Users
                                    where k.Username == enteredUsername
                                    select k).FirstOrDefault();

                    panel8.Visible = false;


                    LoginSucceeded.Invoke(this, EventArgs.Empty);

                    this.Parent.Controls.Remove(this);



                }
                else
                {
                    panel8.Visible = true;
                }

            }
            else
            {
                panel7.Visible = true;
            };
        }

        private void panelLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();

            formSignUp.FormClosed += FormSignUp_FormClosed;

            formSignUp.ShowDialog();
        }

        private void FormSignUp_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loadUserData();
        }
    }
}
