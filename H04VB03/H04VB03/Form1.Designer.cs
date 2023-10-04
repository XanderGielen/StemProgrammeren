namespace H04VB03
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
            buttonBerekenen = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxBeginkapitaal = new TextBox();
            textBoxRentepercentage = new TextBox();
            textBoxKapitaal = new TextBox();
            SuspendLayout();
            // 
            // buttonBerekenen
            // 
            buttonBerekenen.Location = new Point(210, 115);
            buttonBerekenen.Name = "buttonBerekenen";
            buttonBerekenen.Size = new Size(211, 29);
            buttonBerekenen.TabIndex = 0;
            buttonBerekenen.Text = "&Berekenen";
            buttonBerekenen.UseVisualStyleBackColor = true;
            buttonBerekenen.Click += buttonBerekenen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 1;
            label1.Text = "Beginkapitaal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 67);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 2;
            label2.Text = "Rentepercentage:";
            // 
            // textBoxBeginkapitaal
            // 
            textBoxBeginkapitaal.Location = new Point(296, 31);
            textBoxBeginkapitaal.Name = "textBoxBeginkapitaal";
            textBoxBeginkapitaal.Size = new Size(125, 27);
            textBoxBeginkapitaal.TabIndex = 3;
            // 
            // textBoxRentepercentage
            // 
            textBoxRentepercentage.Location = new Point(296, 67);
            textBoxRentepercentage.Name = "textBoxRentepercentage";
            textBoxRentepercentage.Size = new Size(125, 27);
            textBoxRentepercentage.TabIndex = 4;
            // 
            // textBoxKapitaal
            // 
            textBoxKapitaal.Location = new Point(210, 179);
            textBoxKapitaal.Multiline = true;
            textBoxKapitaal.Name = "textBoxKapitaal";
            textBoxKapitaal.ReadOnly = true;
            textBoxKapitaal.ScrollBars = ScrollBars.Vertical;
            textBoxKapitaal.Size = new Size(211, 233);
            textBoxKapitaal.TabIndex = 5;
            textBoxKapitaal.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(textBoxKapitaal);
            Controls.Add(textBoxRentepercentage);
            Controls.Add(textBoxBeginkapitaal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonBerekenen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBerekenen;
        private Label label1;
        private Label label2;
        private TextBox textBoxBeginkapitaal;
        private TextBox textBoxRentepercentage;
        private TextBox textBoxKapitaal;
    }
}