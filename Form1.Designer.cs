namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            login = new Label();
            email = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            password = new Label();
            emailfield = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            passwordfield = new TextBox();
            loginbutton = new Button();
            label4 = new Label();
            signinlabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location = new Point(359, 139);
            login.Name = "login";
            login.Size = new Size(117, 52);
            login.TabIndex = 0;
            login.Text = "Login";
            login.Click += label1_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(249, 223);
            email.Name = "email";
            email.Size = new Size(59, 28);
            email.TabIndex = 1;
            email.Text = "Email";
            email.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(249, 292);
            password.Name = "password";
            password.Size = new Size(93, 28);
            password.TabIndex = 3;
            password.Text = "Password";
            password.Click += password_Click;
            // 
            // emailfield
            // 
            emailfield.Location = new Point(406, 223);
            emailfield.Margin = new Padding(3, 4, 3, 4);
            emailfield.Name = "emailfield";
            emailfield.Size = new Size(175, 27);
            emailfield.TabIndex = 4;
            emailfield.TextChanged += emailfield_TextChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // passwordfield
            // 
            passwordfield.Location = new Point(406, 296);
            passwordfield.Margin = new Padding(3, 4, 3, 4);
            passwordfield.Name = "passwordfield";
            passwordfield.Size = new Size(175, 27);
            passwordfield.TabIndex = 6;
            passwordfield.TextChanged += passwordfield_TextChanged;
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginbutton.Location = new Point(382, 369);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(94, 33);
            loginbutton.TabIndex = 7;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(300, 476);
            label4.Name = "label4";
            label4.Size = new Size(176, 23);
            label4.TabIndex = 8;
            label4.Text = "Haven't signed up yet";
            label4.Click += label4_Click;
            // 
            // signinlabel
            // 
            signinlabel.ActiveLinkColor = Color.Black;
            signinlabel.AutoSize = true;
            signinlabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            signinlabel.Location = new Point(475, 476);
            signinlabel.Name = "signinlabel";
            signinlabel.Size = new Size(106, 23);
            signinlabel.TabIndex = 10;
            signinlabel.TabStop = true;
            signinlabel.Text = "Sign In here.";
            signinlabel.VisitedLinkColor = Color.Black;
            signinlabel.LinkClicked += signinlabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(127, 25);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(168, 50);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forsaken";
            linkLabel1.VisitedLinkColor = Color.Black;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Blue;
            linkLabel2.Location = new Point(137, 76);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(101, 28);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Properties";
            linkLabel2.VisitedLinkColor = Color.Black;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 605);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(signinlabel);
            Controls.Add(label4);
            Controls.Add(loginbutton);
            Controls.Add(passwordfield);
            Controls.Add(emailfield);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login;
        private Label email;
        private ContextMenuStrip contextMenuStrip1;
        private Label password;
        private TextBox emailfield;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox passwordfield;
        private Button loginbutton;
        private Label label4;
        private LinkLabel signinlabel;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}