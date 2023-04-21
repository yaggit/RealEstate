namespace WinFormsApp1
{
    partial class AddPropertyDialogue
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            t1 = new TextBox();
            t2 = new TextBox();
            t3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            type = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 114);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 174);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Address";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 232);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 293);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Image";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(240, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 87);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(199, 465);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // t1
            // 
            t1.Location = new Point(240, 112);
            t1.Name = "t1";
            t1.Size = new Size(125, 27);
            t1.TabIndex = 6;
            t1.TextChanged += t1_TextChanged;
            // 
            // t2
            // 
            t2.Location = new Point(240, 174);
            t2.Name = "t2";
            t2.Size = new Size(125, 27);
            t2.TabIndex = 7;
            // 
            // t3
            // 
            t3.Location = new Point(240, 232);
            t3.Name = "t3";
            t3.Size = new Size(125, 27);
            t3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(142, 30);
            label5.Name = "label5";
            label5.Size = new Size(208, 46);
            label5.TabIndex = 25;
            label5.Text = "Add Property";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 400);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 26;
            label6.Text = "Type:";
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Items.AddRange(new object[] { "Studio", "1BHK", "2BHK", "3BHK", "Duplex", "Penthouse", "Villa" });
            type.Location = new Point(240, 397);
            type.Name = "type";
            type.Size = new Size(151, 28);
            type.TabIndex = 27;
            type.SelectedIndexChanged += type_SelectedIndexChanged;
            // 
            // AddPropertyDialogue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 523);
            Controls.Add(type);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(t3);
            Controls.Add(t2);
            Controls.Add(t1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "AddPropertyDialogue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPropertyDialogue";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox t1;
        private TextBox t2;
        private TextBox t3;
        private Label label5;
        private Label label6;
        private ComboBox type;
    }
}