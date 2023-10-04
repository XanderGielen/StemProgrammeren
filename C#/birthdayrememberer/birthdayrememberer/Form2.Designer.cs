namespace birthdayrememberer
{
    partial class Form2
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
            labelVerjaardagen = new Label();
            SuspendLayout();
            // 
            // labelVerjaardagen
            // 
            labelVerjaardagen.AutoSize = true;
            labelVerjaardagen.Location = new Point(22, 17);
            labelVerjaardagen.Name = "labelVerjaardagen";
            labelVerjaardagen.Size = new Size(15, 20);
            labelVerjaardagen.TabIndex = 0;
            labelVerjaardagen.Text = "..";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelVerjaardagen);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVerjaardagen;
    }
}