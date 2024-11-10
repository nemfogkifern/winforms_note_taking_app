using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class mainUserControl : UserControl
    {
        public winfroms_note_taking.Models.User loggedInuser { get; set; }
        public mainUserControl()
        {
            InitializeComponent();

        }
        public void SetUser(winfroms_note_taking.Models.User user)
        {
            loggedInuser = user;
            label1.Text = user.Username;
        }

        
    }
}
