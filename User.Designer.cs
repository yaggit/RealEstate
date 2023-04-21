namespace WinFormsApp1
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            logout = new LinkLabel();
            button1 = new Button();
            label2 = new Label();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            linkLabel3 = new LinkLabel();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(121, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 60);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forsaken";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Blue;
            linkLabel2.Location = new Point(131, 88);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(101, 28);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Properties";
            linkLabel2.VisitedLinkColor = Color.Black;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(351, 55);
            label1.Name = "label1";
            label1.Size = new Size(214, 61);
            label1.TabIndex = 23;
            label1.Text = "Welcome ";
            label1.Click += label1_Click;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            logout.Location = new Point(1409, 28);
            logout.Name = "logout";
            logout.Size = new Size(79, 25);
            logout.TabIndex = 24;
            logout.TabStop = true;
            logout.Text = "Log Out";
            logout.LinkClicked += logout_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1397, 75);
            button1.Name = "button1";
            button1.Size = new Size(91, 40);
            button1.TabIndex = 26;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 162);
            label2.Name = "label2";
            label2.Size = new Size(182, 47);
            label2.TabIndex = 30;
            label2.Text = "Dashboard";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Light", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(32, 461);
            label8.Name = "label8";
            label8.Size = new Size(130, 47);
            label8.TabIndex = 41;
            label8.Text = "Market:";
            label8.Click += label8_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(41, 556);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1250, 284);
            flowLayoutPanel1.TabIndex = 42;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel3.Location = new Point(1397, 817);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(94, 23);
            linkLabel3.TabIndex = 44;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Contact Us";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1259, 76);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 45;
            button2.Text = "Market";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(46, 217);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1354, 241);
            flowLayoutPanel2.TabIndex = 46;
            // 
            // refresh
            // 
            refresh.Location = new Point(1113, 84);
            refresh.Name = "refresh";
            refresh.Size = new Size(94, 29);
            refresh.TabIndex = 47;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1518, 869);
            Controls.Add(refresh);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(button2);
            Controls.Add(linkLabel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(logout);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += User_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private LinkLabel logout;
        private LinkLabel profile;
        private Button button1;
        private Label label2;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
        private LinkLabel linkLabel3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button refresh;
    }
}