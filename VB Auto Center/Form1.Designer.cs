namespace VB_Auto_Center
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterBut = new System.Windows.Forms.Button();
            this.VBLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XRadio = new System.Windows.Forms.RadioButton();
            this.BRadio = new System.Windows.Forms.RadioButton();
            this.ARadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prNumberTBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.prNumberTBox);
            this.panel1.Controls.Add(this.enterBut);
            this.panel1.Controls.Add(this.VBLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.XRadio);
            this.panel1.Controls.Add(this.BRadio);
            this.panel1.Controls.Add(this.ARadio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(371, 264);
            this.panel1.TabIndex = 1;
            // 
            // enterBut
            // 
            this.enterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBut.ForeColor = System.Drawing.Color.Green;
            this.enterBut.Location = new System.Drawing.Point(140, 197);
            this.enterBut.Name = "enterBut";
            this.enterBut.Size = new System.Drawing.Size(105, 34);
            this.enterBut.TabIndex = 8;
            this.enterBut.Text = "Search";
            this.enterBut.UseVisualStyleBackColor = true;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // VBLabel
            // 
            this.VBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VBLabel.Location = new System.Drawing.Point(143, 140);
            this.VBLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.VBLabel.Name = "VBLabel";
            this.VBLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.VBLabel.Size = new System.Drawing.Size(208, 23);
            this.VBLabel.TabIndex = 7;
            this.VBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "VB Auto part no :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // XRadio
            // 
            this.XRadio.Location = new System.Drawing.Point(146, 107);
            this.XRadio.Name = "XRadio";
            this.XRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.XRadio.Size = new System.Drawing.Size(205, 24);
            this.XRadio.TabIndex = 5;
            this.XRadio.TabStop = true;
            this.XRadio.Text = "Brand X";
            this.XRadio.UseVisualStyleBackColor = true;
            // 
            // BRadio
            // 
            this.BRadio.Location = new System.Drawing.Point(146, 77);
            this.BRadio.Name = "BRadio";
            this.BRadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BRadio.Size = new System.Drawing.Size(205, 24);
            this.BRadio.TabIndex = 4;
            this.BRadio.TabStop = true;
            this.BRadio.Text = "Brand B";
            this.BRadio.UseVisualStyleBackColor = true;
            // 
            // ARadio
            // 
            this.ARadio.Location = new System.Drawing.Point(146, 47);
            this.ARadio.Name = "ARadio";
            this.ARadio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ARadio.Size = new System.Drawing.Size(205, 24);
            this.ARadio.TabIndex = 3;
            this.ARadio.TabStop = true;
            this.ARadio.Text = "Brand A";
            this.ARadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part number :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prNumberTBox
            // 
            this.prNumberTBox.Location = new System.Drawing.Point(147, 14);
            this.prNumberTBox.Name = "prNumberTBox";
            this.prNumberTBox.Size = new System.Drawing.Size(204, 20);
            this.prNumberTBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 294);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VB Auto Center";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton XRadio;
        private System.Windows.Forms.RadioButton BRadio;
        private System.Windows.Forms.RadioButton ARadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VBLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enterBut;
        private System.Windows.Forms.TextBox prNumberTBox;
    }
}

