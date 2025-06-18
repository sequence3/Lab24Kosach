namespace Lab_24
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button1 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 35);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 34);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MistyRose;
            textBox2.Location = new Point(37, 93);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 34);
            textBox2.TabIndex = 0;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(37, 239);
            button2.Name = "button2";
            button2.Size = new Size(500, 49);
            button2.TabIndex = 1;
            button2.Text = "Зупинити 1 потік";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(575, 36);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(500, 34);
            textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.MistyRose;
            textBox4.Location = new Point(575, 93);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(500, 34);
            textBox4.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(575, 169);
            button3.Name = "button3";
            button3.Size = new Size(500, 49);
            button3.TabIndex = 1;
            button3.Text = "Запустити 2 потік";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Red;
            button4.Location = new Point(575, 239);
            button4.Name = "button4";
            button4.Size = new Size(500, 49);
            button4.TabIndex = 1;
            button4.Text = "Зупинити 2 потік";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1108, 36);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(500, 34);
            textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.MistyRose;
            textBox6.Location = new Point(1108, 93);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(500, 34);
            textBox6.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(1108, 169);
            button5.Name = "button5";
            button5.Size = new Size(500, 49);
            button5.TabIndex = 1;
            button5.Text = "Запустити 3 потік";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ForeColor = Color.Red;
            button6.Location = new Point(1108, 239);
            button6.Name = "button6";
            button6.Size = new Size(500, 49);
            button6.TabIndex = 1;
            button6.Text = "Зупинити 3 потік";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.ForeColor = Color.Red;
            button8.Location = new Point(37, 384);
            button8.Name = "button8";
            button8.Size = new Size(1571, 49);
            button8.TabIndex = 1;
            button8.Text = "Зупинити усі потоки";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 169);
            button1.Name = "button1";
            button1.Size = new Size(500, 49);
            button1.TabIndex = 1;
            button1.Text = "Запустити 1 потік";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button7
            // 
            button7.Location = new Point(37, 317);
            button7.Name = "button7";
            button7.Size = new Size(1571, 49);
            button7.TabIndex = 1;
            button7.Text = "Запустити усі потоки";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 471);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            ShowIcon = false;
            Text = "Лаб24 Косач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnStartKHAFRE_Click;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button1;
        private Button button7;
    }
}
