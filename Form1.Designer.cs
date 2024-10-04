namespace JogoDaVelha
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
            btn = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            empates = new Label();
            Opontos = new Label();
            label2 = new Label();
            xpontos = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Location = new Point(98, 3);
            btn.Name = "btn";
            btn.Size = new Size(112, 59);
            btn.TabIndex = 0;
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(216, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 59);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(334, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 59);
            btn2.TabIndex = 2;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(102, 88);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 59);
            btn3.TabIndex = 3;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(220, 88);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 59);
            btn4.TabIndex = 4;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(338, 88);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 59);
            btn5.TabIndex = 5;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(102, 174);
            btn6.Name = "btn6";
            btn6.Size = new Size(112, 59);
            btn6.TabIndex = 6;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(220, 174);
            btn7.Name = "btn7";
            btn7.Size = new Size(112, 59);
            btn7.TabIndex = 7;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(338, 174);
            btn8.Name = "btn8";
            btn8.Size = new Size(112, 59);
            btn8.TabIndex = 8;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn7);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 239);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(124, 257);
            button1.Name = "button1";
            button1.Size = new Size(348, 34);
            button1.TabIndex = 10;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(empates);
            panel2.Controls.Add(Opontos);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(xpontos);
            panel2.Location = new Point(22, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 143);
            panel2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 93);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 5;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 93);
            label5.Name = "label5";
            label5.Size = new Size(26, 25);
            label5.TabIndex = 4;
            label5.Text = "O";
            // 
            // empates
            // 
            empates.AutoSize = true;
            empates.Location = new Point(338, 42);
            empates.Name = "empates";
            empates.Size = new Size(80, 25);
            empates.TabIndex = 3;
            empates.Text = "Empates";
            // 
            // Opontos
            // 
            Opontos.AutoSize = true;
            Opontos.Location = new Point(251, 42);
            Opontos.Name = "Opontos";
            Opontos.Size = new Size(22, 25);
            Opontos.TabIndex = 2;
            Opontos.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 93);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // xpontos
            // 
            xpontos.AutoSize = true;
            xpontos.Location = new Point(155, 42);
            xpontos.Name = "xpontos";
            xpontos.Size = new Size(22, 25);
            xpontos.TabIndex = 0;
            xpontos.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 469);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label empates;
        private Label Opontos;
        private Label label2;
        private Label xpontos;
    }
}
