using Microsoft.IdentityModel.Tokens;
using winfroms_note_taking.Models;

namespace winfroms_note_taking
{

    public partial class Form1 : Form
    {
        PrivatDbContext _context = new PrivatDbContext();
        public User loggedInUser { get; set; }

        private bool isDragging = false;
        private Point dragStartPoint;

        private bool isResizing = false;
        private Point resizeStartPoint;
        private Size initialSize;
        public Form1()
        {
            InitializeComponent();

            //string plainPassword = "makkamikka";
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword);
            //
            //string enteredPassword = "Entered password";
            //bool isValid = BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);

            



            loginUserControl loginUserControl = new loginUserControl();
            loginUserControl.LoginSucceeded += LoginUserControl_LoginSucceeded;
            loginUserControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(loginUserControl);





        }
        

        private void LoginUserControl_LoginSucceeded(object? sender, EventArgs e)
        {
            var loginControl = sender as loginUserControl;
            loggedInUser = loginControl?.loggedInUser;


            mainUserControl mainUserControl = new mainUserControl();
            mainUserControl.Dock = DockStyle.Fill;
            mainUserControl.SetUser(loggedInUser);
            panel1.Controls.Add(mainUserControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Visszaállítás normál méretre és helyre
                this.WindowState = FormWindowState.Normal;
                
            }
            else
            {
                
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Áthelyezés indítása
            if (e.Button == MouseButtons.Left && !IsResizingArea(e.Location))
            {
                isDragging = true;
                dragStartPoint = e.Location;
            }
            // Átméretezés indítása
            else if (e.Button == MouseButtons.Left && IsResizingArea(e.Location))
            {
                isResizing = true;
                resizeStartPoint = e.Location;
                initialSize = this.Size;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (isDragging)
            {
                // Áthelyezés
                this.Location = new Point(this.Location.X + e.X - dragStartPoint.X, this.Location.Y + e.Y - dragStartPoint.Y);
            }
            else if (isResizing)
            {
                // Átméretezés
                int newWidth = initialSize.Width + (e.X - resizeStartPoint.X);
                int newHeight = initialSize.Height + (e.Y - resizeStartPoint.Y);

                this.Size = new Size(Math.Max(newWidth, MinimumSize.Width), Math.Max(newHeight, MinimumSize.Height));
            }
            else
            {
                // Egérkurzor módosítása a szélén
                if (IsResizingArea(e.Location))
                {
                    this.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // Áthelyezés vagy átméretezés befejezése
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                isResizing = false;
            }
        }

        private bool IsResizingArea(Point location)
        {
            // Az ablak jobb alsó sarkában legyen átméretezési zóna
            const int resizeMargin = 10; // Példa margó
            return location.X >= this.ClientSize.Width - resizeMargin && location.Y >= this.ClientSize.Height - resizeMargin;
        }
    }
}
