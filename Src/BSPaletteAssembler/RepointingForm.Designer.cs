namespace BSPaletteAssembler
{
    partial class RepointingForm
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
            this.Offset = new System.Windows.Forms.NumericUpDown();
            this.repointButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Offset)).BeginInit();
            this.SuspendLayout();
            // 
            // Offset
            // 
            this.Offset.Hexadecimal = true;
            this.Offset.Location = new System.Drawing.Point(13, 13);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(120, 20);
            this.Offset.TabIndex = 0;
            this.Offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // repointButton
            // 
            this.repointButton.Location = new System.Drawing.Point(139, 10);
            this.repointButton.Name = "repointButton";
            this.repointButton.Size = new System.Drawing.Size(75, 23);
            this.repointButton.TabIndex = 1;
            this.repointButton.Text = "Repoint";
            this.repointButton.UseVisualStyleBackColor = true;
            this.repointButton.Click += new System.EventHandler(this.repointButton_Click);
            // 
            // RepointingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 43);
            this.Controls.Add(this.repointButton);
            this.Controls.Add(this.Offset);
            this.Name = "RepointingForm";
            this.Text = "Repoint palette";
            ((System.ComponentModel.ISupportInitialize)(this.Offset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Offset;
        private System.Windows.Forms.Button repointButton;
    }
}