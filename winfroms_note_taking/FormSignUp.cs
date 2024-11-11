using Microsoft.IdentityModel.Tokens;
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
    public partial class FormSignUp : Form
    {
        PrivatDbContext _context = new PrivatDbContext();
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signUp();

        }

        private void signUp()
        {
            string enteredEmail = textBoxEmail.Text;
            string enteredUserName = textBoxUsername.Text;
            string enteredPassword = textBoxPassword.Text;



            if (!string.IsNullOrWhiteSpace(enteredEmail))
            {
                var emails = (from k in _context.Users
                              select k.Email).ToList();
                if (!emails.Contains(enteredEmail))
                {
                    if (!string.IsNullOrWhiteSpace(enteredUserName))
                    {
                        var usernames = (from k in _context.Users
                                         select k.Username).ToList();
                        if (!usernames.Contains(enteredUserName))
                        {
                            if (!string.IsNullOrWhiteSpace(enteredPassword))
                            {
                                User newUser = new User();
                                newUser.Username = enteredUserName;
                                newUser.Email = enteredEmail;
                                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(enteredPassword);
                                newUser.Password = hashedPassword;

                                _context.Users.Add(newUser);
                                try
                                {
                                    _context.SaveChanges();

                                    this.Close();


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred while saving the user. Please try again.");
                                }
                            }
                            else
                            {
                                label5.Text = "Password empty!";
                                panel10.Visible = true;
                            }
                            
                        }
                        else
                        {
                            label4.Text = "Username already taken";
                            panel11.Visible = true;
                        }
                    }
                    else
                    {
                        label4.Text = "Username empty!";
                        panel11.Visible = true;
                    }

                }
                else
                {
                    label7.Text = "Email already used!";
                    panel16.Visible = true;
                }
            }
            else
            {
                label7.Text = "Email empty!";
                panel16.Visible = true;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            textBoxEmail.ForeColor = Color.White;
            panel16.Visible = false;

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            textBoxUsername.ForeColor = Color.White;
            panel11.Visible = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.ForeColor = Color.White;
            panel10.Visible = false;
        }

        private void textBoxEmail_Click(object sender, EventArgs e)
        {
            textBoxEmail.SelectAll();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.SelectAll();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.SelectAll();
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signUp();
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signUp();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signUp();
            }
        }
    }
}
