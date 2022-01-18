
namespace AvtoMaster
{
    partial class Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TovarlarBtn = new System.Windows.Forms.Button();
            this.MijozlarBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(196, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ATXK shahobchalari ishini avtomatlashtirish.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(188, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Avto Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TovarlarBtn
            // 
            this.TovarlarBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TovarlarBtn.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TovarlarBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.TovarlarBtn.Location = new System.Drawing.Point(198, 111);
            this.TovarlarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TovarlarBtn.Name = "TovarlarBtn";
            this.TovarlarBtn.Size = new System.Drawing.Size(254, 65);
            this.TovarlarBtn.TabIndex = 4;
            this.TovarlarBtn.Text = "Tovarlar";
            this.TovarlarBtn.UseVisualStyleBackColor = false;
            this.TovarlarBtn.Click += new System.EventHandler(this.TovarlarBtn_Click);
            // 
            // MijozlarBtn
            // 
            this.MijozlarBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MijozlarBtn.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MijozlarBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.MijozlarBtn.Location = new System.Drawing.Point(198, 202);
            this.MijozlarBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MijozlarBtn.Name = "MijozlarBtn";
            this.MijozlarBtn.Size = new System.Drawing.Size(254, 65);
            this.MijozlarBtn.TabIndex = 5;
            this.MijozlarBtn.Text = "Mijozlar";
            this.MijozlarBtn.UseVisualStyleBackColor = false;
            this.MijozlarBtn.Click += new System.EventHandler(this.MijozlarBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(198, 291);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Muddati yetgan";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MijozlarBtn);
            this.Controls.Add(this.TovarlarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TovarlarBtn;
        private System.Windows.Forms.Button MijozlarBtn;
        private System.Windows.Forms.Button button2;
    }
}