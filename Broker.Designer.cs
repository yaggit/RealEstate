namespace WinFormsApp1
{
    partial class Broker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Broker));
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            addProperty = new Button();
            label2 = new Label();
            closeBroker = new Button();
            propertyList = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(127, 55);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(198, 60);
            linkLabel1.TabIndex = 22;
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
            linkLabel2.Location = new Point(138, 115);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(101, 28);
            linkLabel2.TabIndex = 23;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Properties";
            linkLabel2.VisitedLinkColor = Color.Black;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(374, 82);
            label1.Name = "label1";
            label1.Size = new Size(148, 61);
            label1.TabIndex = 24;
            label1.Text = "Broker";
            // 
            // addProperty
            // 
            addProperty.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addProperty.Location = new Point(877, 131);
            addProperty.Name = "addProperty";
            addProperty.Size = new Size(94, 34);
            addProperty.TabIndex = 25;
            addProperty.Text = "Add";
            addProperty.UseVisualStyleBackColor = true;
            addProperty.Click += addProperty_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 193);
            label2.Name = "label2";
            label2.Size = new Size(98, 41);
            label2.TabIndex = 26;
            label2.Text = "Listing";
            // 
            // closeBroker
            // 
            closeBroker.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            closeBroker.Location = new Point(1001, 695);
            closeBroker.Name = "closeBroker";
            closeBroker.Size = new Size(94, 34);
            closeBroker.TabIndex = 27;
            closeBroker.Text = "Close";
            closeBroker.UseVisualStyleBackColor = true;
            closeBroker.Click += closeBroker_Click;
            // 
            // propertyList
            // 
            propertyList.AutoScroll = true;
            propertyList.Location = new Point(52, 248);
            propertyList.Name = "propertyList";
            propertyList.Size = new Size(1052, 508);
            propertyList.TabIndex = 28;
            propertyList.Paint += propertyList_Paint;
            // 
            // Broker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 768);
            Controls.Add(propertyList);
            Controls.Add(closeBroker);
            Controls.Add(label2);
            Controls.Add(addProperty);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Name = "Broker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Broker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
        private Button addProperty;
        private Label label2;
        private Button closeBroker;
        public static FlowLayoutPanel propertyList;
    }
}