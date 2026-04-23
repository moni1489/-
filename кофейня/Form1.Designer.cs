namespace кофейня
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(56, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(702, 331);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Moccasin;
            tabPage1.Controls.Add(checkBox8);
            tabPage1.Controls.Add(checkBox7);
            tabPage1.Controls.Add(checkBox6);
            tabPage1.Controls.Add(checkBox5);
            tabPage1.Controls.Add(checkBox4);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(694, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Меню";
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 20F);
            checkBox8.Location = new Point(499, 102);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(202, 41);
            checkBox8.TabIndex = 18;
            checkBox8.Text = "Маршмеллоу";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 20F);
            checkBox7.Location = new Point(497, 55);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(109, 41);
            checkBox7.TabIndex = 17;
            checkBox7.Text = "Сахар";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 20F);
            checkBox6.Location = new Point(285, 145);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(176, 41);
            checkBox6.TabIndex = 16;
            checkBox6.Text = "Банановый";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 20F);
            checkBox5.Location = new Point(285, 98);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(201, 41);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "Шоколадный";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 20F);
            checkBox4.Location = new Point(285, 51);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(163, 41);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "Ореховый";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Pink;
            button2.Location = new Point(570, 243);
            button2.Name = "button2";
            button2.Size = new Size(118, 54);
            button2.TabIndex = 13;
            button2.Text = "Перейти к заказу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Pink;
            label5.Font = new Font("Palatino Linotype", 23F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(497, 10);
            label5.Name = "label5";
            label5.Size = new Size(191, 42);
            label5.TabIndex = 12;
            label5.Text = "supplements";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Pink;
            label4.Font = new Font("Palatino Linotype", 23F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(300, -40);
            label4.Name = "label4";
            label4.Size = new Size(104, 88);
            label4.TabIndex = 11;
            label4.Text = "\r\nsyrups";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Pink;
            label3.Font = new Font("Palatino Linotype", 23F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 10);
            label3.Name = "label3";
            label3.Size = new Size(73, 42);
            label3.TabIndex = 1;
            label3.Text = "cafe";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 20F);
            checkBox3.Location = new Point(36, 145);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(104, 41);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Латте";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 20F);
            checkBox2.Location = new Point(36, 98);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(158, 41);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Капучино";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 20F);
            checkBox1.Location = new Point(36, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(177, 41);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Американо";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PapayaWhip;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button1);
            tabPage2.ForeColor = SystemColors.Info;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(694, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказать";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(251, 98);
            button3.Name = "button3";
            button3.Size = new Size(167, 61);
            button3.TabIndex = 3;
            button3.Text = "Оплатить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(591, 252);
            button1.Name = "button1";
            button1.Size = new Size(97, 45);
            button1.TabIndex = 0;
            button1.Text = "Вернуться в меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Onyx", 50F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 15);
            label1.Name = "label1";
            label1.Size = new Size(99, 74);
            label1.TabIndex = 0;
            label1.Text = "Cafe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
    }
}
