namespace WinFormsApp1
{
    partial class policy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(policy));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 0;
            label1.Text = "Terms and Conditions:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 87);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(919, 502);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(973, 41);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 4;
            label2.Text = "Privacy Policy:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(973, 87);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(919, 502);
            textBox2.TabIndex = 0;
            textBox2.TabStop = false;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // close
            // 
            close.Location = new Point(1393, 621);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 5;
            close.Text = "Close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // policy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 817);
            Controls.Add(close);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "policy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "policy";
            WindowState = FormWindowState.Maximized;
            Load += policy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button close;
    }
}