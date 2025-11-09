namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 473);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Resource1.Profile;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(87, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 159);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(342, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 473);
            panel2.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = SystemColors.ButtonShadow;
            checkBox1.Location = new Point(305, 318);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 29);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Cursor = Cursors.Hand;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Impact", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Image = Resource1.Restore_Window;
            label7.Location = new Point(448, 11);
            label7.Name = "label7";
            label7.Size = new Size(32, 28);
            label7.TabIndex = 32;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(110, 249);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 31;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(176, 139);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 30;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(36, 230);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 29;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(36, 132);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 27;
            label2.Text = "Username";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(64, 0, 64);
            button2.Location = new Point(283, 369);
            button2.Name = "button2";
            button2.Size = new Size(129, 53);
            button2.TabIndex = 28;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(36, 275);
            textBox2.Margin = new Padding(0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(423, 40);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(164, 31);
            label1.Name = "label1";
            label1.Size = new Size(180, 50);
            label1.TabIndex = 25;
            label1.Text = "L O G I N";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(36, 176);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 40);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(64, 0, 64);
            button1.Location = new Point(110, 369);
            button1.Name = "button1";
            button1.Size = new Size(129, 53);
            button1.TabIndex = 26;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.BackColor = SystemColors.ControlText;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(485, 11);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(32, 28);
            label5.TabIndex = 22;
            label5.Text = "X";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 473);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN PAGE";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private CheckBox checkBox1;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
    }
}
