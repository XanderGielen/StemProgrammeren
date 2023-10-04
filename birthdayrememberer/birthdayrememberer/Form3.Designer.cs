namespace birthdayrememberer
{
    partial class Form3
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
            textBoxVerjaardagDatum = new TextBox();
            label1 = new Label();
            buttonOpslaan = new Button();
            SuspendLayout();
            // 
            // textBoxVerjaardagDatum
            // 
            textBoxVerjaardagDatum.Location = new Point(284, 118);
            textBoxVerjaardagDatum.Name = "textBoxVerjaardagDatum";
            textBoxVerjaardagDatum.Size = new Size(125, 27);
            textBoxVerjaardagDatum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 118);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 1;
            label1.Text = "Voer een datum in: ";
            // 
            // buttonOpslaan
            // 
            buttonOpslaan.Location = new Point(223, 203);
            buttonOpslaan.Name = "buttonOpslaan";
            buttonOpslaan.Size = new Size(94, 29);
            buttonOpslaan.TabIndex = 2;
            buttonOpslaan.Text = "opslaan";
            buttonOpslaan.UseVisualStyleBackColor = true;
            buttonOpslaan.Click += buttonOpslaan_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpslaan);
            Controls.Add(label1);
            Controls.Add(textBoxVerjaardagDatum);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxVerjaardagDatum;
        private Label label1;
        private Button buttonOpslaan;
    }
}