namespace WinFormsApp1
{
    partial class Listing
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
            button1 = new Button();
            valueText = new TextBox();
            addressText = new TextBox();
            nameText = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(792, 35);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 43;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // valueText
            // 
            valueText.Location = new Point(443, 37);
            valueText.Name = "valueText";
            valueText.Size = new Size(125, 27);
            valueText.TabIndex = 42;
            // 
            // addressText
            // 
            addressText.Location = new Point(275, 37);
            addressText.Name = "addressText";
            addressText.Size = new Size(125, 27);
            addressText.TabIndex = 41;
            addressText.TextChanged += textBox2_TextChanged;
            // 
            // nameText
            // 
            nameText.Location = new Point(112, 37);
            nameText.Name = "nameText";
            nameText.Size = new Size(124, 27);
            nameText.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(443, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 39;
            label5.Text = "Value:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 38;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 37;
            label3.Text = "Name:";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 79);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(609, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 45;
            label1.Text = "Type:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(609, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 46;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Listing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(valueText);
            Controls.Add(addressText);
            Controls.Add(nameText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Name = "Listing";
            Size = new Size(899, 102);
            Load += Listing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox valueText;
        private TextBox addressText;
        private TextBox nameText;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
    }
}
