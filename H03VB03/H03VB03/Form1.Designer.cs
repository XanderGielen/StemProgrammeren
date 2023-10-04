namespace H03VB03
{
    partial class FormKassa
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
            buttonBerekenen = new Button();
            buttonSluiten = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radioButtonParticulier = new RadioButton();
            radioButtonWinkelier = new RadioButton();
            textBoxTotaal = new TextBox();
            textBoxKortingspercentage = new TextBox();
            textBoxKorting = new TextBox();
            textBoxTeBetalenIncl = new TextBox();
            textBoxTeBetalenExcl = new TextBox();
            textBoxBTWBedrag = new TextBox();
            textBoxAantal = new TextBox();
            textBoxEenheidsprijs = new TextBox();
            groupBoxAard = new GroupBox();
            groupBoxAard.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBerekenen
            // 
            buttonBerekenen.Location = new Point(270, 160);
            buttonBerekenen.Name = "buttonBerekenen";
            buttonBerekenen.Size = new Size(94, 29);
            buttonBerekenen.TabIndex = 0;
            buttonBerekenen.Text = "&Berekenen";
            buttonBerekenen.UseVisualStyleBackColor = true;
            buttonBerekenen.Click += ButtonBerekenen_Click;
            // 
            // buttonSluiten
            // 
            buttonSluiten.Location = new Point(401, 163);
            buttonSluiten.Name = "buttonSluiten";
            buttonSluiten.Size = new Size(94, 29);
            buttonSluiten.TabIndex = 1;
            buttonSluiten.Text = "&Sluiten";
            buttonSluiten.UseVisualStyleBackColor = true;
            buttonSluiten.Click += buttonSluiten_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 205);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "Totaal inc. BTW:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 239);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 3;
            label2.Text = "Kortingspercentage:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 281);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Korting:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 318);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 5;
            label4.Text = "Te betalen inc. BTW:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 364);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 6;
            label5.Text = "Te betalen excl. BTW:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 404);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 7;
            label6.Text = "BTW bedrag:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(443, 106);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 8;
            label7.Text = "Aantal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 61);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 9;
            label8.Text = "Eenheidsprijs";
            // 
            // radioButtonParticulier
            // 
            radioButtonParticulier.AutoSize = true;
            radioButtonParticulier.Location = new Point(35, 27);
            radioButtonParticulier.Name = "radioButtonParticulier";
            radioButtonParticulier.Size = new Size(95, 24);
            radioButtonParticulier.TabIndex = 10;
            radioButtonParticulier.TabStop = true;
            radioButtonParticulier.Text = "Particulier";
            radioButtonParticulier.UseVisualStyleBackColor = true;
            // 
            // radioButtonWinkelier
            // 
            radioButtonWinkelier.AutoSize = true;
            radioButtonWinkelier.Location = new Point(35, 83);
            radioButtonWinkelier.Name = "radioButtonWinkelier";
            radioButtonWinkelier.Size = new Size(92, 24);
            radioButtonWinkelier.TabIndex = 11;
            radioButtonWinkelier.TabStop = true;
            radioButtonWinkelier.Text = "Winkelier";
            radioButtonWinkelier.UseVisualStyleBackColor = true;
            // 
            // textBoxTotaal
            // 
            textBoxTotaal.Location = new Point(229, 205);
            textBoxTotaal.Name = "textBoxTotaal";
            textBoxTotaal.ReadOnly = true;
            textBoxTotaal.Size = new Size(125, 27);
            textBoxTotaal.TabIndex = 13;
            // 
            // textBoxKortingspercentage
            // 
            textBoxKortingspercentage.Location = new Point(229, 239);
            textBoxKortingspercentage.Name = "textBoxKortingspercentage";
            textBoxKortingspercentage.ReadOnly = true;
            textBoxKortingspercentage.Size = new Size(125, 27);
            textBoxKortingspercentage.TabIndex = 14;
            // 
            // textBoxKorting
            // 
            textBoxKorting.Location = new Point(229, 281);
            textBoxKorting.Name = "textBoxKorting";
            textBoxKorting.ReadOnly = true;
            textBoxKorting.Size = new Size(125, 27);
            textBoxKorting.TabIndex = 15;
            // 
            // textBoxTeBetalenIncl
            // 
            textBoxTeBetalenIncl.Location = new Point(229, 318);
            textBoxTeBetalenIncl.Name = "textBoxTeBetalenIncl";
            textBoxTeBetalenIncl.ReadOnly = true;
            textBoxTeBetalenIncl.Size = new Size(125, 27);
            textBoxTeBetalenIncl.TabIndex = 16;
            // 
            // textBoxTeBetalenExcl
            // 
            textBoxTeBetalenExcl.Location = new Point(229, 364);
            textBoxTeBetalenExcl.Name = "textBoxTeBetalenExcl";
            textBoxTeBetalenExcl.ReadOnly = true;
            textBoxTeBetalenExcl.Size = new Size(125, 27);
            textBoxTeBetalenExcl.TabIndex = 17;
            // 
            // textBoxBTWBedrag
            // 
            textBoxBTWBedrag.Location = new Point(229, 404);
            textBoxBTWBedrag.Name = "textBoxBTWBedrag";
            textBoxBTWBedrag.ReadOnly = true;
            textBoxBTWBedrag.Size = new Size(125, 27);
            textBoxBTWBedrag.TabIndex = 18;
            // 
            // textBoxAantal
            // 
            textBoxAantal.Location = new Point(511, 106);
            textBoxAantal.Name = "textBoxAantal";
            textBoxAantal.Size = new Size(125, 27);
            textBoxAantal.TabIndex = 19;
            // 
            // textBoxEenheidsprijs
            // 
            textBoxEenheidsprijs.Location = new Point(511, 61);
            textBoxEenheidsprijs.Name = "textBoxEenheidsprijs";
            textBoxEenheidsprijs.Size = new Size(125, 27);
            textBoxEenheidsprijs.TabIndex = 20;
            // 
            // groupBoxAard
            // 
            groupBoxAard.Controls.Add(radioButtonWinkelier);
            groupBoxAard.Controls.Add(radioButtonParticulier);
            groupBoxAard.Location = new Point(12, 43);
            groupBoxAard.Name = "groupBoxAard";
            groupBoxAard.Size = new Size(250, 125);
            groupBoxAard.TabIndex = 21;
            groupBoxAard.TabStop = false;
            groupBoxAard.Text = "Aard";
            // 
            // FormKassa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(groupBoxAard);
            Controls.Add(textBoxEenheidsprijs);
            Controls.Add(textBoxAantal);
            Controls.Add(textBoxBTWBedrag);
            Controls.Add(textBoxTeBetalenExcl);
            Controls.Add(textBoxTeBetalenIncl);
            Controls.Add(textBoxKorting);
            Controls.Add(textBoxKortingspercentage);
            Controls.Add(textBoxTotaal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSluiten);
            Controls.Add(buttonBerekenen);
            Name = "FormKassa";
            Text = "Kassa CreaTura";
            groupBoxAard.ResumeLayout(false);
            groupBoxAard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBerekenen;
        private Button buttonSluiten;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radioButtonParticulier;
        private RadioButton radioButtonWinkelier;
        private TextBox textBoxTotaal;
        private TextBox textBoxKortingspercentage;
        private TextBox textBoxKorting;
        private TextBox textBoxTeBetalenIncl;
        private TextBox textBoxTeBetalenExcl;
        private TextBox textBoxBTWBedrag;
        private TextBox textBoxAantal;
        private TextBox textBoxEenheidsprijs;
        private GroupBox groupBoxAard;
    }
}