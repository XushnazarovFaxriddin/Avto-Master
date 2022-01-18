
namespace AvtoMaster
{
    partial class Mijozlar
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
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addBtn.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addBtn.Size = new System.Drawing.Size(56, 57);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1247, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mijozlar";
            // 
            // Mijozlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Mijozlar";
            this.Text = "Mijozlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
    }
}