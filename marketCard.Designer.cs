namespace WinFormsApp1
{
    partial class marketCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marketCard));
            pictureBox1 = new PictureBox();
            valueText = new TextBox();
            addressText = new TextBox();
            nameText = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(38, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 87);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // valueText
            // 
            valueText.Location = new Point(534, 74);
            valueText.Name = "valueText";
            valueText.Size = new Size(125, 27);
            valueText.TabIndex = 48;
            // 
            // addressText
            // 
            addressText.Location = new Point(366, 74);
            addressText.Name = "addressText";
            addressText.Size = new Size(125, 27);
            addressText.TabIndex = 47;
            // 
            // nameText
            // 
            nameText.Location = new Point(203, 74);
            nameText.Name = "nameText";
            nameText.Size = new Size(124, 27);
            nameText.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 37);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 45;
            label5.Text = "Value:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 37);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 44;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 37);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 43;
            label3.Text = "Name:";
            // 
            // button1
            // 
            button1.Location = new Point(758, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 49;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(894, 111);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 50;
            button2.Text = "Rent";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(721, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 51;
            label1.Text = "Type:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(807, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 52;
            // 
            // marketCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(valueText);
            Controls.Add(addressText);
            Controls.Add(nameText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "marketCard";
            Size = new Size(1013, 157);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox valueText;
        private TextBox addressText;
        private TextBox nameText;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
    }
}
