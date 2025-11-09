namespace WinFormsApp1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(110, 369);
            button1.Name = "button1";
            button1.Size = new Size(129, 53);
            button1.TabIndex = 0;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(36, 230);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(36, 275);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(433, 40);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 132);
            label1.Name = "label1";
            label1.Size = new Size(103, 28);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(36, 176);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 40);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 473);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Resource1.Profile;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(87, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 159);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(342, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 473);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(283, 369);
            button2.Name = "button2";
            button2.Size = new Size(129, 53);
            button2.TabIndex = 24;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = SystemColors.ButtonShadow;
            checkBox1.Location = new Point(315, 321);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 29);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.Black;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Impact", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(452, 9);
            label7.Name = "label7";
            label7.Size = new Size(32, 28);
            label7.TabIndex = 22;
            label7.Text = "-";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(489, 9);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(32, 28);
            label5.TabIndex = 21;
            label5.Text = "X";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(150, 31);
            label2.Name = "label2";
            label2.Size = new Size(234, 50);
            label2.TabIndex = 9;
            label2.Text = "S I G N   U P";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 473);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIGN UP PAGE";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label4;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label7;
        private Label label5;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
        private Button button2;
    }
}