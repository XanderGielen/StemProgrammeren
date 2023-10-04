namespace birthdayrememberer
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
            buttonKalender = new Button();
            buttonVoegToe = new Button();
            SuspendLayout();
            // 
            // buttonKalender
            // 
            buttonKalender.Location = new Point(12, 12);
            buttonKalender.Name = "buttonKalender";
            buttonKalender.Size = new Size(156, 66);
            buttonKalender.TabIndex = 0;
            buttonKalender.Text = "kalender";
            buttonKalender.UseVisualStyleBackColor = true;
            buttonKalender.Click += buttonKalender_Click;
            // 
            // buttonVoegToe
            // 
            buttonVoegToe.Location = new Point(12, 96);
            buttonVoegToe.Name = "buttonVoegToe";
            buttonVoegToe.Size = new Size(156, 79);
            buttonVoegToe.TabIndex = 1;
            buttonVoegToe.Text = "voeg een verjaardag toe";
            buttonVoegToe.UseVisualStyleBackColor = true;
            buttonVoegToe.Click += buttonVoegToe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(186, 217);
            Controls.Add(buttonVoegToe);
            Controls.Add(buttonKalender);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKalender;
        private Button buttonVoegToe;
    }
}