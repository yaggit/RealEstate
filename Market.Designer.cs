namespace WinFormsApp1
{
    partial class Market
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Market));
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            sigin = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 62);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(141, 37);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 60);
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
            linkLabel2.Location = new Point(150, 97);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(101, 28);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Properties";
            linkLabel2.VisitedLinkColor = Color.Black;
            // 
            // sigin
            // 
            sigin.AutoSize = true;
            sigin.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            sigin.Location = new Point(981, 64);
            sigin.Name = "sigin";
            sigin.Size = new Size(143, 52);
            sigin.TabIndex = 23;
            sigin.Text = "Market";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(39, 188);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1112, 522);
            flowLayoutPanel1.TabIndex = 24;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Market
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 749);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(sigin);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Name = "Market";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Market";
            Load += Market_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label sigin;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}