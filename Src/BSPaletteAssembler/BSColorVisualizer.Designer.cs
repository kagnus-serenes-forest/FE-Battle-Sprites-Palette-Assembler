namespace BSPaletteAssembler
{
    partial class BSColorVisualizer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorViewer = new System.Windows.Forms.PictureBox();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorViewer
            // 
            this.ColorViewer.BackColor = System.Drawing.Color.White;
            this.ColorViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorViewer.Location = new System.Drawing.Point(4, 4);
            this.ColorViewer.Name = "ColorViewer";
            this.ColorViewer.Size = new System.Drawing.Size(20, 20);
            this.ColorViewer.TabIndex = 0;
            this.ColorViewer.TabStop = false;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            this.RedLabel.Location = new System.Drawing.Point(4, 27);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(21, 15);
            this.RedLabel.TabIndex = 1;
            this.RedLabel.Text = "??";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GreenLabel.ForeColor = System.Drawing.Color.Green;
            this.GreenLabel.Location = new System.Drawing.Point(4, 41);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(21, 15);
            this.GreenLabel.TabIndex = 2;
            this.GreenLabel.Text = "??";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BlueLabel.ForeColor = System.Drawing.Color.Blue;
            this.BlueLabel.Location = new System.Drawing.Point(4, 55);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(21, 15);
            this.BlueLabel.TabIndex = 3;
            this.BlueLabel.Text = "??";
            // 
            // BSColorVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.ColorViewer);
            this.Name = "BSColorVisualizer";
            this.Size = new System.Drawing.Size(29, 73);
            ((System.ComponentModel.ISupportInitialize)(this.ColorViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ColorViewer;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
    }
}
