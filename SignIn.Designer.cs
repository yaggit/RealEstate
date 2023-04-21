namespace WinFormsApp1
{
    partial class SignIn
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            sigin = new Label();
            name = new Label();
            email = new Label();
            mail = new Label();
            password = new Label();
            birthdate = new Label();
            policy = new Label();
            tandc = new LinkLabel();
            privacy = new LinkLabel();
            label1 = new Label();
            signincheck = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            signinbutton = new Button();
            label4 = new Label();
            loginlink = new LinkLabel();
            buttondark = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sigin
            // 
            sigin.AutoSize = true;
            sigin.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            sigin.Location = new Point(393, 125);
            sigin.Name = "sigin";
            sigin.Size = new Size(140, 52);
            sigin.TabIndex = 1;
            sigin.Text = "Sign In";
            sigin.Click += sigin_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(272, 224);
            name.Name = "name";
            name.Size = new Size(64, 28);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(272, 284);
            email.Name = "email";
            email.Size = new Size(67, 28);
            email.TabIndex = 3;
            email.Text = "Phone";
            email.Click += label1_Click;
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mail.Location = new Point(272, 348);
            mail.Name = "mail";
            mail.Size = new Size(59, 28);
            mail.TabIndex = 4;
            mail.Text = "Email";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(272, 474);
            password.Name = "password";
            password.Size = new Size(93, 28);
            password.TabIndex = 5;
            password.Text = "Password";
            // 
            // birthdate
            // 
            birthdate.AutoSize = true;
            birthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthdate.Location = new Point(272, 411);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(99, 28);
            birthdate.TabIndex = 6;
            birthdate.Text = "Birth Date";
            // 
            // policy
            // 
            policy.AutoSize = true;
            policy.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            policy.Location = new Point(257, 572);
            policy.Name = "policy";
            policy.Size = new Size(123, 23);
            policy.TabIndex = 7;
            policy.Text = "I agree to the ";
            // 
            // tandc
            // 
            tandc.AutoSize = true;
            tandc.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tandc.Location = new Point(375, 572);
            tandc.Name = "tandc";
            tandc.Size = new Size(168, 23);
            tandc.TabIndex = 8;
            tandc.TabStop = true;
            tandc.Text = "Terms and Condition";
            tandc.LinkClicked += tandc_LinkClicked;
            // 
            // privacy
            // 
            privacy.AutoSize = true;
            privacy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            privacy.Location = new Point(575, 572);
            privacy.Name = "privacy";
            privacy.Size = new Size(115, 23);
            privacy.TabIndex = 9;
            privacy.TabStop = true;
            privacy.Text = "Privacy Policy.";
            privacy.LinkClicked += privacy_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(539, 572);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 10;
            label1.Text = "and";
            // 
            // signincheck
            // 
            signincheck.AutoSize = true;
            signincheck.Location = new Point(233, 577);
            signincheck.Name = "signincheck";
            signincheck.Size = new Size(18, 17);
            signincheck.TabIndex = 11;
            signincheck.UseVisualStyleBackColor = true;
            signincheck.CheckedChanged += signincheck_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(407, 284);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(407, 349);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 27);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(407, 474);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 27);
            textBox4.TabIndex = 15;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(407, 413);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(141, 26);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 60);
            linkLabel1.TabIndex = 17;
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
            linkLabel2.Location = new Point(150, 86);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(101, 28);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Properties";
            linkLabel2.VisitedLinkColor = Color.Black;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // signinbutton
            // 
            signinbutton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            signinbutton.Location = new Point(424, 622);
            signinbutton.Name = "signinbutton";
            signinbutton.Size = new Size(94, 33);
            signinbutton.TabIndex = 20;
            signinbutton.Text = "Sign In";
            signinbutton.UseVisualStyleBackColor = true;
            signinbutton.Click += signinbutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(345, 531);
            label4.Name = "label4";
            label4.Size = new Size(198, 23);
            label4.TabIndex = 21;
            label4.Text = "Already have an account";
            label4.Click += label4_Click;
            // 
            // loginlink
            // 
            loginlink.ActiveLinkColor = Color.Black;
            loginlink.AutoSize = true;
            loginlink.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginlink.Location = new Point(539, 531);
            loginlink.Name = "loginlink";
            loginlink.Size = new Size(61, 23);
            loginlink.TabIndex = 22;
            loginlink.TabStop = true;
            loginlink.Text = "Log in.";
            loginlink.VisitedLinkColor = Color.Black;
            loginlink.LinkClicked += loginlink_LinkClicked;
            // 
            // buttondark
            // 
            buttondark.BackgroundImage = (Image)resources.GetObject("buttondark.BackgroundImage");
            buttondark.BackgroundImageLayout = ImageLayout.Center;
            buttondark.Location = new Point(760, 89);
            buttondark.Name = "buttondark";
            buttondark.Size = new Size(94, 29);
            buttondark.TabIndex = 23;
            buttondark.Text = "Dark";
            buttondark.UseVisualStyleBackColor = true;
            buttondark.Click += button1_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(938, 758);
            Controls.Add(buttondark);
            Controls.Add(loginlink);
            Controls.Add(label4);
            Controls.Add(signinbutton);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(signincheck);
            Controls.Add(label1);
            Controls.Add(privacy);
            Controls.Add(tandc);
            Controls.Add(policy);
            Controls.Add(birthdate);
            Controls.Add(password);
            Controls.Add(mail);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(sigin);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignIn";
            Load += SignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sigin;
        private Label name;
        private Label email;
        private Label mail;
        private Label password;
        private Label birthdate;
        private Label policy;
        private LinkLabel tandc;
        private LinkLabel privacy;
        private Label label1;
        private CheckBox signincheck;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private Button signinbutton;
        private Label label4;
        private LinkLabel loginlink;
        private Button buttondark;
    }
}