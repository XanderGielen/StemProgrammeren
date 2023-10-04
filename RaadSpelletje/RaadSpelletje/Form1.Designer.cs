namespace RaadSpelletje
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
            textBoxGetal = new TextBox();
            label1 = new Label();
            buttonEvalueren = new Button();
            buttonNieuwSpel = new Button();
            buttonEinde = new Button();
            label2 = new Label();
            labelBoodschap = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxGetal
            // 
            textBoxGetal.Location = new Point(236, 53);
            textBoxGetal.Name = "textBoxGetal";
            textBoxGetal.Size = new Size(125, 27);
            textBoxGetal.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 7;
            // 
            // buttonEvalueren
            // 
            buttonEvalueren.Location = new Point(12, 145);
            buttonEvalueren.Name = "buttonEvalueren";
            buttonEvalueren.Size = new Size(94, 29);
            buttonEvalueren.TabIndex = 2;
            buttonEvalueren.Text = "&Evalueren";
            buttonEvalueren.UseVisualStyleBackColor = true;
            buttonEvalueren.Click += buttonEvalueren_Click;
            // 
            // buttonNieuwSpel
            // 
            buttonNieuwSpel.Location = new Point(127, 145);
            buttonNieuwSpel.Name = "buttonNieuwSpel";
            buttonNieuwSpel.Size = new Size(94, 29);
            buttonNieuwSpel.TabIndex = 3;
            buttonNieuwSpel.Text = "&Nieuw spel";
            buttonNieuwSpel.UseVisualStyleBackColor = true;
            buttonNieuwSpel.Click += buttonNieuwSpel_Click;
            // 
            // buttonEinde
            // 
            buttonEinde.Location = new Point(245, 145);
            buttonEinde.Name = "buttonEinde";
            buttonEinde.Size = new Size(94, 29);
            buttonEinde.TabIndex = 4;
            buttonEinde.Text = "&Einde";
            buttonEinde.UseVisualStyleBackColor = true;
            buttonEinde.Click += buttonEinde_Click;
            buttonEinde.Enter += buttonEvalueren_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // labelBoodschap
            // 
            labelBoodschap.AutoSize = true;
            labelBoodschap.Location = new Point(41, 99);
            labelBoodschap.Name = "labelBoodschap";
            labelBoodschap.Size = new Size(0, 20);
            labelBoodschap.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 48);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 8;
            label3.Text = "gok een getal tussen 1 en 100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 211);
            Controls.Add(label3);
            Controls.Add(labelBoodschap);
            Controls.Add(label2);
            Controls.Add(buttonEinde);
            Controls.Add(buttonNieuwSpel);
            Controls.Add(buttonEvalueren);
            Controls.Add(label1);
            Controls.Add(textBoxGetal);
            Name = "Form1";
            Text = "Form1";
            Load += buttonNieuwSpel_Click;
            Validated += buttonEvalueren_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGetal;
        private Label label1;
        private Button buttonEvalueren;
        private Button buttonNieuwSpel;
        private Button buttonEinde;
        private Label label2;
        private Label labelBoodschap;
        private Label label3;
    }
}