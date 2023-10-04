namespace oefening_4
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
            radioButtonMan = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonVrouw = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonBerekenen = new Button();
            textBoxLengte = new TextBox();
            textBoxPolsOmtrek = new TextBox();
            textBoxIdeaalGewicht = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonMan
            // 
            radioButtonMan.AutoSize = true;
            radioButtonMan.Location = new Point(47, 26);
            radioButtonMan.Name = "radioButtonMan";
            radioButtonMan.Size = new Size(117, 24);
            radioButtonMan.TabIndex = 0;
            radioButtonMan.TabStop = true;
            radioButtonMan.Text = "radioButton1";
            radioButtonMan.UseVisualStyleBackColor = true;
            radioButtonMan.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonVrouw);
            groupBox1.Controls.Add(radioButtonMan);
            groupBox1.Location = new Point(35, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Geslacht";
            // 
            // radioButtonVrouw
            // 
            radioButtonVrouw.AutoSize = true;
            radioButtonVrouw.Location = new Point(47, 76);
            radioButtonVrouw.Name = "radioButtonVrouw";
            radioButtonVrouw.Size = new Size(117, 24);
            radioButtonVrouw.TabIndex = 2;
            radioButtonVrouw.TabStop = true;
            radioButtonVrouw.Text = "radioButton2";
            radioButtonVrouw.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 186);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "Lengte in cm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 237);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 3;
            label2.Text = "Polsomtrek in cm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 291);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 4;
            label3.Text = "Ideale gewicht:";
            // 
            // buttonBerekenen
            // 
            buttonBerekenen.Location = new Point(191, 344);
            buttonBerekenen.Name = "buttonBerekenen";
            buttonBerekenen.Size = new Size(94, 29);
            buttonBerekenen.TabIndex = 5;
            buttonBerekenen.Text = "&Bereken";
            buttonBerekenen.UseVisualStyleBackColor = true;
            // 
            // textBoxLengte
            // 
            textBoxLengte.Location = new Point(187, 179);
            textBoxLengte.Name = "textBoxLengte";
            textBoxLengte.Size = new Size(125, 27);
            textBoxLengte.TabIndex = 6;
            // 
            // textBoxPolsOmtrek
            // 
            textBoxPolsOmtrek.Location = new Point(187, 230);
            textBoxPolsOmtrek.Name = "textBoxPolsOmtrek";
            textBoxPolsOmtrek.Size = new Size(125, 27);
            textBoxPolsOmtrek.TabIndex = 7;
            // 
            // textBoxIdeaalGewicht
            // 
            textBoxIdeaalGewicht.Location = new Point(187, 291);
            textBoxIdeaalGewicht.Name = "textBoxIdeaalGewicht";
            textBoxIdeaalGewicht.ReadOnly = true;
            textBoxIdeaalGewicht.Size = new Size(125, 27);
            textBoxIdeaalGewicht.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxIdeaalGewicht);
            Controls.Add(textBoxPolsOmtrek);
            Controls.Add(textBoxLengte);
            Controls.Add(buttonBerekenen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonMan;
        private GroupBox groupBox1;
        private RadioButton radioButtonVrouw;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonBerekenen;
        private TextBox textBoxLengte;
        private TextBox textBoxPolsOmtrek;
        private TextBox textBoxIdeaalGewicht;
    }
}