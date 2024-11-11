namespace winfroms_note_taking
{
    partial class loginUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginUserControl));
            panel1 = new Panel();
            panel2 = new Panel();
            panel11 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel10 = new Panel();
            panel9 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            textBoxUsername = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            panel8 = new Panel();
            label5 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            panelLogin = new Panel();
            button2 = new Button();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 53, 71);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 65);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 481);
            panel2.TabIndex = 2;
            // 
            // panel11
            // 
            panel11.Controls.Add(pictureBox3);
            panel11.Controls.Add(label6);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 129);
            panel11.Name = "panel11";
            panel11.Size = new Size(411, 239);
            panel11.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(411, 184);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Bottom;
            label6.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 192);
            label6.Name = "label6";
            label6.Size = new Size(411, 47);
            label6.TabIndex = 0;
            label6.Text = "NotesMaster";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 368);
            panel10.Name = "panel10";
            panel10.Size = new Size(411, 113);
            panel10.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(411, 129);
            panel9.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(textBoxUsername);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(43, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 51);
            panel4.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Right;
            textBoxUsername.BackColor = Color.FromArgb(64, 64, 64);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxUsername.ForeColor = Color.Silver;
            textBoxUsername.Location = new Point(152, 15);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(245, 20);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.Text = "Enter username";
            textBoxUsername.Click += textBoxUsername_Click;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            textBoxUsername.KeyDown += textBoxUsername_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 20);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(152, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 1);
            panel3.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(label5);
            panel8.Location = new Point(43, 239);
            panel8.Name = "panel8";
            panel8.Size = new Size(400, 33);
            panel8.TabIndex = 9;
            panel8.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(149, -4);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 0;
            label5.Text = "Incorrect password";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 128);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(133, 297);
            button1.Name = "button1";
            button1.Size = new Size(215, 43);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 39);
            label1.Name = "label1";
            label1.Size = new Size(127, 54);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(textBoxPassword);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(43, 190);
            panel5.Name = "panel5";
            panel5.Size = new Size(400, 60);
            panel5.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Right;
            textBoxPassword.BackColor = Color.FromArgb(64, 64, 64);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxPassword.ForeColor = Color.Silver;
            textBoxPassword.Location = new Point(152, 18);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(245, 20);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "Enter password";
            textBoxPassword.Click += textBoxPassword_Click;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 20);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(152, 44);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 1);
            panel6.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(43, 149);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 27);
            panel7.TabIndex = 8;
            panel7.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(149, -6);
            label4.Name = "label4";
            label4.Size = new Size(144, 21);
            label4.TabIndex = 0;
            label4.Text = "Incorrect username";
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(button2);
            panelLogin.Controls.Add(panel4);
            panelLogin.Controls.Add(panel8);
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(panel7);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(panel5);
            panelLogin.Dock = DockStyle.Right;
            panelLogin.Location = new Point(355, 65);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(532, 481);
            panelLogin.TabIndex = 3;
            panelLogin.PreviewKeyDown += panelLogin_PreviewKeyDown;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.FromArgb(211, 203, 37);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 154, 29);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 233, 154);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = Color.White;
            button2.Location = new Point(133, 359);
            button2.Name = "button2";
            button2.Size = new Size(215, 43);
            button2.TabIndex = 10;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // loginUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panelLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "loginUserControl";
            Size = new Size(887, 546);
            panel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelLogin;
        private Label label1;
        private Panel panel3;
        private TextBox textBoxUsername;
        private Label label2;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox pictureBox2;
        private TextBox textBoxPassword;
        private Label label3;
        private Panel panel6;
        private Button button1;
        private Panel panel8;
        private Label label5;
        private Panel panel7;
        private Label label4;
        private Panel panel9;
        private Panel panel11;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel10;
        private Button button2;
    }
}
