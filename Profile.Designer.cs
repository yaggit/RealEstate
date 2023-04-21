namespace WinFormsApp1
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            useImage = new PictureBox();
            profileName = new TextBox();
            profilePhone = new TextBox();
            profileEmail = new TextBox();
            profilePassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 70);
            label1.Name = "label1";
            label1.Size = new Size(118, 50);
            label1.TabIndex = 24;
            label1.Text = "Profile";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(130, 42);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 60);
            linkLabel1.TabIndex = 25;
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
            linkLabel2.Location = new Point(143, 102);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(101, 28);
            linkLabel2.TabIndex = 26;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Properties";
            linkLabel2.VisitedLinkColor = Color.Black;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(107, 307);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 28;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 364);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 29;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(103, 426);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 30;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(103, 487);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 31;
            label5.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(213, 571);
            button1.Name = "button1";
            button1.Size = new Size(93, 36);
            button1.TabIndex = 33;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // useImage
            // 
            useImage.Location = new Point(228, 172);
            useImage.Name = "useImage";
            useImage.Size = new Size(100, 100);
            useImage.TabIndex = 34;
            useImage.TabStop = false;
            useImage.Click += pictureBox2_Click;
            // 
            // profileName
            // 
            profileName.Location = new Point(234, 305);
            profileName.Name = "profileName";
            profileName.ReadOnly = true;
            profileName.Size = new Size(125, 27);
            profileName.TabIndex = 35;
            profileName.TextChanged += profileName_TextChanged;
            // 
            // profilePhone
            // 
            profilePhone.Location = new Point(234, 364);
            profilePhone.Name = "profilePhone";
            profilePhone.ReadOnly = true;
            profilePhone.Size = new Size(125, 27);
            profilePhone.TabIndex = 36;
            // 
            // profileEmail
            // 
            profileEmail.Location = new Point(234, 427);
            profileEmail.Name = "profileEmail";
            profileEmail.ReadOnly = true;
            profileEmail.Size = new Size(125, 27);
            profileEmail.TabIndex = 37;
            // 
            // profilePassword
            // 
            profilePassword.Location = new Point(234, 487);
            profilePassword.Name = "profilePassword";
            profilePassword.ReadOnly = true;
            profilePassword.Size = new Size(125, 27);
            profilePassword.TabIndex = 38;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 656);
            Controls.Add(profilePassword);
            Controls.Add(profileEmail);
            Controls.Add(profilePhone);
            Controls.Add(profileName);
            Controls.Add(useImage);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)useImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private PictureBox useImage;
        private TextBox profileName;
        private TextBox profilePhone;
        private TextBox profileEmail;
        private TextBox profilePassword;
    }
}