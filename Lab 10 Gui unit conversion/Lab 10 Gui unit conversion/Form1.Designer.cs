namespace Lab_10_Gui_unit_conversion
{
    partial class Form1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.inchBox = new System.Windows.Forms.TextBox();
            this.mintueBox = new System.Windows.Forms.TextBox();
            this.gallonBox = new System.Windows.Forms.TextBox();
            this.bottleBox = new System.Windows.Forms.TextBox();
            this.jiffiesBox = new System.Windows.Forms.TextBox();
            this.beardBox = new System.Windows.Forms.TextBox();
            this.InchLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.gallonLabel = new System.Windows.Forms.Label();
            this.beardLabel = new System.Windows.Forms.Label();
            this.jifLabel = new System.Windows.Forms.Label();
            this.bottleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 48);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(123, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standard Units";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(364, 48);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Magic Units";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // inchBox
            // 
            this.inchBox.Location = new System.Drawing.Point(43, 171);
            this.inchBox.Margin = new System.Windows.Forms.Padding(4);
            this.inchBox.Name = "inchBox";
            this.inchBox.Size = new System.Drawing.Size(132, 22);
            this.inchBox.TabIndex = 2;
            this.inchBox.TextChanged += new System.EventHandler(this.inchBox_TextChanged);
            // 
            // mintueBox
            // 
            this.mintueBox.Location = new System.Drawing.Point(43, 247);
            this.mintueBox.Margin = new System.Windows.Forms.Padding(4);
            this.mintueBox.Name = "mintueBox";
            this.mintueBox.Size = new System.Drawing.Size(132, 22);
            this.mintueBox.TabIndex = 3;
            // 
            // gallonBox
            // 
            this.gallonBox.Location = new System.Drawing.Point(43, 309);
            this.gallonBox.Margin = new System.Windows.Forms.Padding(4);
            this.gallonBox.Name = "gallonBox";
            this.gallonBox.Size = new System.Drawing.Size(132, 22);
            this.gallonBox.TabIndex = 4;
            // 
            // bottleBox
            // 
            this.bottleBox.Location = new System.Drawing.Point(364, 309);
            this.bottleBox.Margin = new System.Windows.Forms.Padding(4);
            this.bottleBox.Name = "bottleBox";
            this.bottleBox.Size = new System.Drawing.Size(132, 22);
            this.bottleBox.TabIndex = 5;
            // 
            // jiffiesBox
            // 
            this.jiffiesBox.Location = new System.Drawing.Point(364, 248);
            this.jiffiesBox.Margin = new System.Windows.Forms.Padding(4);
            this.jiffiesBox.Name = "jiffiesBox";
            this.jiffiesBox.Size = new System.Drawing.Size(132, 22);
            this.jiffiesBox.TabIndex = 6;
            // 
            // beardBox
            // 
            this.beardBox.Location = new System.Drawing.Point(364, 171);
            this.beardBox.Margin = new System.Windows.Forms.Padding(4);
            this.beardBox.Name = "beardBox";
            this.beardBox.Size = new System.Drawing.Size(132, 22);
            this.beardBox.TabIndex = 7;
            // 
            // InchLabel
            // 
            this.InchLabel.AutoSize = true;
            this.InchLabel.Location = new System.Drawing.Point(223, 171);
            this.InchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InchLabel.Name = "InchLabel";
            this.InchLabel.Size = new System.Drawing.Size(49, 17);
            this.InchLabel.TabIndex = 8;
            this.InchLabel.Text = "Inches";
            this.InchLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(223, 255);
            this.minuteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(57, 17);
            this.minuteLabel.TabIndex = 9;
            this.minuteLabel.Text = "Mintues";
            // 
            // gallonLabel
            // 
            this.gallonLabel.AutoSize = true;
            this.gallonLabel.Location = new System.Drawing.Point(223, 316);
            this.gallonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gallonLabel.Name = "gallonLabel";
            this.gallonLabel.Size = new System.Drawing.Size(56, 17);
            this.gallonLabel.TabIndex = 10;
            this.gallonLabel.Text = "Gallons";
            // 
            // beardLabel
            // 
            this.beardLabel.AutoSize = true;
            this.beardLabel.CausesValidation = false;
            this.beardLabel.Location = new System.Drawing.Point(571, 171);
            this.beardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.beardLabel.Name = "beardLabel";
            this.beardLabel.Size = new System.Drawing.Size(106, 17);
            this.beardLabel.TabIndex = 11;
            this.beardLabel.Text = "Beard-Seconds";
            this.beardLabel.UseMnemonic = false;
            // 
            // jifLabel
            // 
            this.jifLabel.AutoSize = true;
            this.jifLabel.Location = new System.Drawing.Point(571, 251);
            this.jifLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jifLabel.Name = "jifLabel";
            this.jifLabel.Size = new System.Drawing.Size(44, 17);
            this.jifLabel.TabIndex = 12;
            this.jifLabel.Text = "Jiffies";
            this.jifLabel.UseMnemonic = false;
            // 
            // bottleLabel
            // 
            this.bottleLabel.AutoSize = true;
            this.bottleLabel.Location = new System.Drawing.Point(571, 316);
            this.bottleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bottleLabel.Name = "bottleLabel";
            this.bottleLabel.Size = new System.Drawing.Size(85, 17);
            this.bottleLabel.TabIndex = 13;
            this.bottleLabel.Text = "Bottlesworth";
            this.bottleLabel.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.bottleLabel);
            this.Controls.Add(this.jifLabel);
            this.Controls.Add(this.beardLabel);
            this.Controls.Add(this.gallonLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.InchLabel);
            this.Controls.Add(this.beardBox);
            this.Controls.Add(this.jiffiesBox);
            this.Controls.Add(this.bottleBox);
            this.Controls.Add(this.gallonBox);
            this.Controls.Add(this.mintueBox);
            this.Controls.Add(this.inchBox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox inchBox;
        private System.Windows.Forms.TextBox mintueBox;
        private System.Windows.Forms.TextBox gallonBox;
        private System.Windows.Forms.TextBox bottleBox;
        private System.Windows.Forms.TextBox jiffiesBox;
        private System.Windows.Forms.TextBox beardBox;
        private System.Windows.Forms.Label InchLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label gallonLabel;
        private System.Windows.Forms.Label beardLabel;
        private System.Windows.Forms.Label jifLabel;
        private System.Windows.Forms.Label bottleLabel;
    }
}

