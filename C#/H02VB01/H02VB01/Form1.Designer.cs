namespace H02VB01
{
    partial class labPrijs
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
            butSluiten = new Button();
            butBerekenen = new Button();
            butWissen = new Button();
            txtTeBetalen = new TextBox();
            txtAantal = new TextBox();
            txtPrijs = new TextBox();
            label1 = new Label();
            labAantal = new Label();
            labTeBetalen = new Label();
            SuspendLayout();
            // 
            // butSluiten
            // 
            butSluiten.BackColor = SystemColors.ButtonShadow;
            butSluiten.Location = new Point(142, 340);
            butSluiten.Name = "butSluiten";
            butSluiten.Size = new Size(123, 61);
            butSluiten.TabIndex = 0;
            butSluiten.Text = "Sluiten";
            butSluiten.UseVisualStyleBackColor = false;
            butSluiten.Click += butSluiten_Click;
            // 
            // butBerekenen
            // 
            butBerekenen.BackColor = SystemColors.ButtonShadow;
            butBerekenen.Location = new Point(142, 265);
            butBerekenen.Name = "butBerekenen";
            butBerekenen.Size = new Size(123, 69);
            butBerekenen.TabIndex = 1;
            butBerekenen.Text = "Berekenen";
            butBerekenen.UseVisualStyleBackColor = false;
            butBerekenen.Click += butBerekenen_Click;
            // 
            // butWissen
            // 
            butWissen.BackColor = SystemColors.ButtonShadow;
            butWissen.Location = new Point(18, 265);
            butWissen.Name = "butWissen";
            butWissen.Size = new Size(118, 69);
            butWissen.TabIndex = 2;
            butWissen.Text = "Wissen";
            butWissen.UseVisualStyleBackColor = false;
            butWissen.Click += button3_Click;
            // 
            // txtTeBetalen
            // 
            txtTeBetalen.Location = new Point(142, 205);
            txtTeBetalen.Name = "txtTeBetalen";
            txtTeBetalen.Size = new Size(125, 27);
            txtTeBetalen.TabIndex = 3;
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(142, 132);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(125, 27);
            txtAantal.TabIndex = 4;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(142, 59);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(125, 27);
            txtPrijs.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 59);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 6;
            label1.Text = "Prijs:";
            label1.Click += label1_Click;
            // 
            // labAantal
            // 
            labAantal.AutoSize = true;
            labAantal.Location = new Point(76, 132);
            labAantal.Name = "labAantal";
            labAantal.Size = new Size(55, 20);
            labAantal.TabIndex = 7;
            labAantal.Text = "Aantal:";
            // 
            // labTeBetalen
            // 
            labTeBetalen.AutoSize = true;
            labTeBetalen.Location = new Point(50, 212);
            labTeBetalen.Name = "labTeBetalen";
            labTeBetalen.Size = new Size(81, 20);
            labTeBetalen.TabIndex = 8;
            labTeBetalen.Text = "Te betalen:";
            // 
            // labPrijs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 432);
            Controls.Add(labTeBetalen);
            Controls.Add(labAantal);
            Controls.Add(label1);
            Controls.Add(txtPrijs);
            Controls.Add(txtAantal);
            Controls.Add(txtTeBetalen);
            Controls.Add(butWissen);
            Controls.Add(butBerekenen);
            Controls.Add(butSluiten);
            Name = "labPrijs";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butSluiten;
        private Button butBerekenen;
        private Button butWissen;
        private TextBox txtTeBetalen;
        private TextBox txtAantal;
        private TextBox txtPrijs;
        private Label label1;
        private Label labAantal;
        private Label labTeBetalen;
    }
}