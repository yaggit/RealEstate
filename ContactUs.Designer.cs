namespace WinFormsApp1
{
    partial class ContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUs));
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            profileEmail = new TextBox();
            profilePhone = new TextBox();
            profileName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Blue;
            linkLabel2.Location = new Point(126, 98);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(101, 28);
            linkLabel2.TabIndex = 25;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Properties";
            linkLabel2.VisitedLinkColor = Color.Black;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(116, 38);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 60);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forsaken";
            linkLabel1.VisitedLinkColor = Color.Black;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(515, 65);
            label2.Name = "label2";
            label2.Size = new Size(184, 61);
            label2.TabIndex = 27;
            label2.Text = "Contact ";
            // 
            // profileEmail
            // 
            profileEmail.Location = new Point(243, 305);
            profileEmail.Name = "profileEmail";
            profileEmail.ReadOnly = true;
            profileEmail.Size = new Size(125, 27);
            profileEmail.TabIndex = 44;
            // 
            // profilePhone
            // 
            profilePhone.Location = new Point(243, 242);
            profilePhone.Name = "profilePhone";
            profilePhone.ReadOnly = true;
            profilePhone.Size = new Size(125, 27);
            profilePhone.TabIndex = 43;
            // 
            // profileName
            // 
            profileName.Location = new Point(243, 183);
            profileName.Name = "profileName";
            profileName.ReadOnly = true;
            profileName.Size = new Size(125, 27);
            profileName.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(112, 304);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 40;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 242);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 39;
            label3.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(112, 185);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 38;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(112, 366);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 45;
            label5.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(243, 366);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 230);
            textBox1.TabIndex = 46;
            // 
            // button1
            // 
            button1.Location = new Point(459, 641);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 47;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 641);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 48;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ContactUs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 711);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(profileEmail);
            Controls.Add(profilePhone);
            Controls.Add(profileName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Name = "ContactUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactUs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox profileEmail;
        private TextBox profilePhone;
        private TextBox profileName;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}