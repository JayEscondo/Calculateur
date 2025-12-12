namespace Calculatrice
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            Addition = new Button();
            soustraction = new Button();
            Calcul = new Button();
            virgule = new Button();
            division = new Button();
            Multiplication = new Button();
            Reset = new Button();
            LabelCalcul = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(391, 46);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(14, 135);
            button1.Name = "button1";
            button1.Size = new Size(85, 35);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(116, 134);
            button2.Name = "button2";
            button2.Size = new Size(85, 35);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(219, 135);
            button3.Name = "button3";
            button3.Size = new Size(85, 35);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.AutoSize = true;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.Location = new Point(14, 176);
            button4.Name = "button4";
            button4.Size = new Size(85, 35);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.AutoSize = true;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.Location = new Point(116, 175);
            button5.Name = "button5";
            button5.Size = new Size(85, 35);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.AutoSize = true;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.Location = new Point(219, 176);
            button6.Name = "button6";
            button6.Size = new Size(85, 35);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.AutoSize = true;
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button7.Location = new Point(14, 217);
            button7.Name = "button7";
            button7.Size = new Size(85, 35);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.AutoSize = true;
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button8.Location = new Point(116, 216);
            button8.Name = "button8";
            button8.Size = new Size(85, 35);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.AutoSize = true;
            button9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button9.Location = new Point(219, 217);
            button9.Name = "button9";
            button9.Size = new Size(85, 35);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button10.AutoSize = true;
            button10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button10.Location = new Point(116, 257);
            button10.Name = "button10";
            button10.Size = new Size(85, 35);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Addition
            // 
            Addition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Addition.AutoSize = true;
            Addition.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Addition.Location = new Point(319, 135);
            Addition.Name = "Addition";
            Addition.Size = new Size(85, 35);
            Addition.TabIndex = 11;
            Addition.Text = "+";
            Addition.UseVisualStyleBackColor = true;
            Addition.Click += addition_Click;
            // 
            // soustraction
            // 
            soustraction.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            soustraction.AutoSize = true;
            soustraction.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            soustraction.Location = new Point(319, 176);
            soustraction.Name = "soustraction";
            soustraction.Size = new Size(85, 35);
            soustraction.TabIndex = 12;
            soustraction.Text = "-";
            soustraction.UseVisualStyleBackColor = true;
            soustraction.Click += soustraction_Click;
            // 
            // Calcul
            // 
            Calcul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Calcul.AutoSize = true;
            Calcul.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Calcul.Location = new Point(319, 258);
            Calcul.Name = "Calcul";
            Calcul.Size = new Size(85, 35);
            Calcul.TabIndex = 13;
            Calcul.Text = "=";
            Calcul.UseVisualStyleBackColor = true;
            Calcul.Click += Calcul_Click;
            // 
            // virgule
            // 
            virgule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            virgule.AutoSize = true;
            virgule.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            virgule.Location = new Point(219, 258);
            virgule.Name = "virgule";
            virgule.Size = new Size(85, 35);
            virgule.TabIndex = 14;
            virgule.Text = ",";
            virgule.UseVisualStyleBackColor = true;
            virgule.Click += virgule_Click;
            // 
            // division
            // 
            division.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            division.AutoSize = true;
            division.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            division.Location = new Point(319, 217);
            division.Name = "division";
            division.Size = new Size(85, 35);
            division.TabIndex = 15;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // Multiplication
            // 
            Multiplication.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Multiplication.AutoSize = true;
            Multiplication.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Multiplication.Location = new Point(219, 94);
            Multiplication.Name = "Multiplication";
            Multiplication.Size = new Size(85, 35);
            Multiplication.TabIndex = 16;
            Multiplication.Text = "*";
            Multiplication.UseVisualStyleBackColor = true;
            Multiplication.Click += Multiplication_Click;
            // 
            // Reset
            // 
            Reset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Reset.AutoSize = true;
            Reset.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Reset.Location = new Point(319, 94);
            Reset.Name = "Reset";
            Reset.Size = new Size(85, 35);
            Reset.TabIndex = 17;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // LabelCalcul
            // 
            LabelCalcul.Location = new Point(14, 9);
            LabelCalcul.Name = "LabelCalcul";
            LabelCalcul.Size = new Size(390, 20);
            LabelCalcul.TabIndex = 18;
            LabelCalcul.TextAlign = ContentAlignment.MiddleRight;
            LabelCalcul.Click += LabelCalcul_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(415, 305);
            Controls.Add(LabelCalcul);
            Controls.Add(Reset);
            Controls.Add(Multiplication);
            Controls.Add(division);
            Controls.Add(virgule);
            Controls.Add(Calcul);
            Controls.Add(soustraction);
            Controls.Add(Addition);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculatrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button Addition;
        private Button soustraction;
        private Button Calcul;
        private Button virgule;
        private Button division;
        private Button Multiplication;
        private Button Reset;
        private Label LabelCalcul;
    }
}
