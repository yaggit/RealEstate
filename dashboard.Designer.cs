namespace WinFormsApp1
{
    partial class dashboard
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
            textBox3 = new TextBox();
            label7 = new Label();
            payButton = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            propertyName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1096, 92);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1096, 29);
            label7.Name = "label7";
            label7.Size = new Size(55, 25);
            label7.TabIndex = 52;
            label7.Text = "Type:";
            // 
            // payButton
            // 
            payButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            payButton.Location = new Point(901, 83);
            payButton.Name = "payButton";
            payButton.Size = new Size(94, 40);
            payButton.TabIndex = 51;
            payButton.Text = "Pay";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(889, 29);
            label6.Name = "label6";
            label6.Size = new Size(126, 25);
            label6.TabIndex = 50;
            label6.Text = "Maintenance:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(648, 83);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 38);
            textBox2.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(380, 82);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(162, 80);
            textBox1.TabIndex = 48;
            // 
            // propertyName
            // 
            propertyName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            propertyName.Location = new Point(168, 82);
            propertyName.Name = "propertyName";
            propertyName.ReadOnly = true;
            propertyName.Size = new Size(125, 39);
            propertyName.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(648, 29);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 46;
            label5.Text = "Value:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(380, 29);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 45;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(168, 29);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 44;
            label3.Text = "Name:";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(payButton);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(propertyName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "dashboard";
            Size = new Size(1232, 185);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label7;
        private Button payButton;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox propertyName;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
