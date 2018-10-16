namespace MegaDesk_3_EvanPeterson
{
    partial class addForm
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
            this.cancelAddQuoteButton = new System.Windows.Forms.Button();
            this.depthNumberBox = new System.Windows.Forms.NumericUpDown();
            this.widthNumberBox = new System.Windows.Forms.NumericUpDown();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drawerBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rushBox = new System.Windows.Forms.ComboBox();
            this.quoteTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelAddQuoteButton
            // 
            this.cancelAddQuoteButton.Location = new System.Drawing.Point(646, 174);
            this.cancelAddQuoteButton.Name = "cancelAddQuoteButton";
            this.cancelAddQuoteButton.Size = new System.Drawing.Size(121, 23);
            this.cancelAddQuoteButton.TabIndex = 0;
            this.cancelAddQuoteButton.Text = "Cancel";
            this.cancelAddQuoteButton.UseVisualStyleBackColor = true;
            this.cancelAddQuoteButton.Click += new System.EventHandler(this.cancelAddQuoteButton_Click);
            // 
            // depthNumberBox
            // 
            this.depthNumberBox.Location = new System.Drawing.Point(81, 105);
            this.depthNumberBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNumberBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumberBox.Name = "depthNumberBox";
            this.depthNumberBox.Size = new System.Drawing.Size(120, 20);
            this.depthNumberBox.TabIndex = 1;
            this.depthNumberBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // widthNumberBox
            // 
            this.widthNumberBox.Location = new System.Drawing.Point(81, 136);
            this.widthNumberBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumberBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumberBox.Name = "widthNumberBox";
            this.widthNumberBox.Size = new System.Drawing.Size(120, 20);
            this.widthNumberBox.TabIndex = 2;
            this.widthNumberBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumberBox.ValueChanged += new System.EventHandler(this.widthNumberBox_ValueChanged);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(27, 136);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(50, 17);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(27, 105);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.MaximumSize = new System.Drawing.Size(600, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add New Quote";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(361, 106);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(121, 21);
            this.materialBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surface Material: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Drawers:";
            // 
            // drawerBox
            // 
            this.drawerBox.FormattingEnabled = true;
            this.drawerBox.Location = new System.Drawing.Point(361, 136);
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(121, 21);
            this.drawerBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rush Order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current Quote: ";
            // 
            // rushBox
            // 
            this.rushBox.FormattingEnabled = true;
            this.rushBox.Location = new System.Drawing.Point(646, 108);
            this.rushBox.Name = "rushBox";
            this.rushBox.Size = new System.Drawing.Size(121, 21);
            this.rushBox.TabIndex = 12;
            // 
            // quoteTextBox
            // 
            this.quoteTextBox.Location = new System.Drawing.Point(646, 140);
            this.quoteTextBox.Name = "quoteTextBox";
            this.quoteTextBox.ReadOnly = true;
            this.quoteTextBox.Size = new System.Drawing.Size(121, 20);
            this.quoteTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Check Quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(81, 50);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(182, 20);
            this.nameBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Create Quote";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quoteTextBox);
            this.Controls.Add(this.rushBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drawerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthNumberBox);
            this.Controls.Add(this.depthNumberBox);
            this.Controls.Add(this.cancelAddQuoteButton);
            this.Name = "addForm";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depthNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddQuoteButton;
        private System.Windows.Forms.NumericUpDown depthNumberBox;
        private System.Windows.Forms.NumericUpDown widthNumberBox;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drawerBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rushBox;
        private System.Windows.Forms.TextBox quoteTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}