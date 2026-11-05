namespace Calculatrice
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grilleBoutons = new TableLayoutPanel();
            lblHistorique = new Label();
            lblAffichage = new Label();
            btnReset = new Button();
            btnEffacer = new Button();
            btnDivision = new Button();
            btnMultiplication = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnSoustraction = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnAddition = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnEgal = new Button();
            btn0 = new Button();
            btnVirgule = new Button();
            grilleBoutons.SuspendLayout();
            SuspendLayout();
            //
            // grilleBoutons
            //
            grilleBoutons.ColumnCount = 4;
            grilleBoutons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grilleBoutons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grilleBoutons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grilleBoutons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            grilleBoutons.Controls.Add(lblHistorique, 0, 0);
            grilleBoutons.Controls.Add(lblAffichage, 0, 1);
            grilleBoutons.Controls.Add(btnReset, 0, 2);
            grilleBoutons.Controls.Add(btnEffacer, 1, 2);
            grilleBoutons.Controls.Add(btnDivision, 2, 2);
            grilleBoutons.Controls.Add(btnMultiplication, 3, 2);
            grilleBoutons.Controls.Add(btn7, 0, 3);
            grilleBoutons.Controls.Add(btn8, 1, 3);
            grilleBoutons.Controls.Add(btn9, 2, 3);
            grilleBoutons.Controls.Add(btnSoustraction, 3, 3);
            grilleBoutons.Controls.Add(btn4, 0, 4);
            grilleBoutons.Controls.Add(btn5, 1, 4);
            grilleBoutons.Controls.Add(btn6, 2, 4);
            grilleBoutons.Controls.Add(btnAddition, 3, 4);
            grilleBoutons.Controls.Add(btn1, 0, 5);
            grilleBoutons.Controls.Add(btn2, 1, 5);
            grilleBoutons.Controls.Add(btn3, 2, 5);
            grilleBoutons.Controls.Add(btnEgal, 3, 5);
            grilleBoutons.Controls.Add(btn0, 0, 6);
            grilleBoutons.Controls.Add(btnVirgule, 2, 6);
            grilleBoutons.Dock = DockStyle.Fill;
            grilleBoutons.Location = new Point(8, 8);
            grilleBoutons.Name = "grilleBoutons";
            grilleBoutons.RowCount = 7;
            grilleBoutons.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            grilleBoutons.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            grilleBoutons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            grilleBoutons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            grilleBoutons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            grilleBoutons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            grilleBoutons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            grilleBoutons.Size = new Size(304, 404);
            grilleBoutons.TabIndex = 0;
            //
            // lblHistorique
            //
            grilleBoutons.SetColumnSpan(lblHistorique, 4);
            lblHistorique.Dock = DockStyle.Fill;
            lblHistorique.Font = new Font("Segoe UI", 10F);
            lblHistorique.ForeColor = SystemColors.GrayText;
            lblHistorique.Name = "lblHistorique";
            lblHistorique.TabIndex = 0;
            lblHistorique.TextAlign = ContentAlignment.MiddleRight;
            //
            // lblAffichage
            //
            lblAffichage.AutoEllipsis = true;
            lblAffichage.BackColor = SystemColors.Window;
            grilleBoutons.SetColumnSpan(lblAffichage, 4);
            lblAffichage.Dock = DockStyle.Fill;
            lblAffichage.Font = new Font("Segoe UI", 24F);
            lblAffichage.Name = "lblAffichage";
            lblAffichage.TabIndex = 1;
            lblAffichage.Text = "0";
            lblAffichage.TextAlign = ContentAlignment.MiddleRight;
            //
            // btnReset
            //
            btnReset.Dock = DockStyle.Fill;
            btnReset.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReset.Name = "btnReset";
            btnReset.TabStop = false;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += Reset_Click;
            //
            // btnEffacer
            //
            btnEffacer.Dock = DockStyle.Fill;
            btnEffacer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.TabStop = false;
            btnEffacer.Text = "←";
            btnEffacer.UseVisualStyleBackColor = true;
            btnEffacer.Click += Effacer_Click;
            //
            // btnDivision
            //
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDivision.Name = "btnDivision";
            btnDivision.TabStop = false;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += Operation_Click;
            //
            // btnMultiplication
            //
            btnMultiplication.Dock = DockStyle.Fill;
            btnMultiplication.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.TabStop = false;
            btnMultiplication.Text = "×";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += Operation_Click;
            //
            // btn7
            //
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn7.Name = "btn7";
            btn7.TabStop = false;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Chiffre_Click;
            //
            // btn8
            //
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn8.Name = "btn8";
            btn8.TabStop = false;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Chiffre_Click;
            //
            // btn9
            //
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn9.Name = "btn9";
            btn9.TabStop = false;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Chiffre_Click;
            //
            // btnSoustraction
            //
            btnSoustraction.Dock = DockStyle.Fill;
            btnSoustraction.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSoustraction.Name = "btnSoustraction";
            btnSoustraction.TabStop = false;
            btnSoustraction.Text = "−";
            btnSoustraction.UseVisualStyleBackColor = true;
            btnSoustraction.Click += Operation_Click;
            //
            // btn4
            //
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn4.Name = "btn4";
            btn4.TabStop = false;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Chiffre_Click;
            //
            // btn5
            //
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn5.Name = "btn5";
            btn5.TabStop = false;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Chiffre_Click;
            //
            // btn6
            //
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn6.Name = "btn6";
            btn6.TabStop = false;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Chiffre_Click;
            //
            // btnAddition
            //
            btnAddition.Dock = DockStyle.Fill;
            btnAddition.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAddition.Name = "btnAddition";
            btnAddition.TabStop = false;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += Operation_Click;
            //
            // btn1
            //
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn1.Name = "btn1";
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Chiffre_Click;
            //
            // btn2
            //
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn2.Name = "btn2";
            btn2.TabStop = false;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Chiffre_Click;
            //
            // btn3
            //
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn3.Name = "btn3";
            btn3.TabStop = false;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Chiffre_Click;
            //
            // btnEgal
            //
            btnEgal.BackColor = Color.SteelBlue;
            btnEgal.Dock = DockStyle.Fill;
            btnEgal.FlatStyle = FlatStyle.Flat;
            btnEgal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEgal.ForeColor = Color.White;
            btnEgal.Name = "btnEgal";
            grilleBoutons.SetRowSpan(btnEgal, 2);
            btnEgal.TabStop = false;
            btnEgal.Text = "=";
            btnEgal.UseVisualStyleBackColor = false;
            btnEgal.Click += Egal_Click;
            //
            // btn0
            //
            grilleBoutons.SetColumnSpan(btn0, 2);
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn0.Name = "btn0";
            btn0.TabStop = false;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Chiffre_Click;
            //
            // btnVirgule
            //
            btnVirgule.Dock = DockStyle.Fill;
            btnVirgule.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnVirgule.Name = "btnVirgule";
            btnVirgule.TabStop = false;
            btnVirgule.Text = ",";
            btnVirgule.UseVisualStyleBackColor = true;
            btnVirgule.Click += Virgule_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 420);
            Controls.Add(grilleBoutons);
            KeyPreview = true;
            MinimumSize = new Size(300, 400);
            Name = "Form1";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculatrice";
            grilleBoutons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel grilleBoutons;
        private Label lblHistorique;
        private Label lblAffichage;
        private Button btnReset;
        private Button btnEffacer;
        private Button btnDivision;
        private Button btnMultiplication;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSoustraction;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnAddition;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnEgal;
        private Button btn0;
        private Button btnVirgule;
    }
}
