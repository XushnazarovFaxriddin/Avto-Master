
namespace AvtoMaster
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInTxt = new System.Windows.Forms.TextBox();
            this.ParolTxt = new System.Windows.Forms.TextBox();
            this.KirishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avto Master";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(215, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATXK shahobchalari ishini avtomatlashtirish.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInTxt
            // 
            this.LogInTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInTxt.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInTxt.Location = new System.Drawing.Point(219, 218);
            this.LogInTxt.Multiline = true;
            this.LogInTxt.Name = "LogInTxt";
            this.LogInTxt.Size = new System.Drawing.Size(337, 37);
            this.LogInTxt.TabIndex = 2;
            this.LogInTxt.Tag = "Log In";
            this.LogInTxt.Text = "Log In";
            // 
            // ParolTxt
            // 
            this.ParolTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParolTxt.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParolTxt.Location = new System.Drawing.Point(219, 289);
            this.ParolTxt.Multiline = true;
            this.ParolTxt.Name = "ParolTxt";
            this.ParolTxt.Size = new System.Drawing.Size(337, 37);
            this.ParolTxt.TabIndex = 3;
            this.ParolTxt.Tag = "Parol";
            this.ParolTxt.Text = "Parol";
            // 
            // KirishBtn
            // 
            this.KirishBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.KirishBtn.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KirishBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.KirishBtn.Location = new System.Drawing.Point(216, 361);
            this.KirishBtn.Name = "KirishBtn";
            this.KirishBtn.Size = new System.Drawing.Size(345, 44);
            this.KirishBtn.TabIndex = 1;
            this.KirishBtn.TabStop = false;
            this.KirishBtn.Text = "Kirish";
            this.KirishBtn.UseVisualStyleBackColor = false;
            this.KirishBtn.Click += new System.EventHandler(this.KirishBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KirishBtn);
            this.Controls.Add(this.ParolTxt);
            this.Controls.Add(this.LogInTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Kirish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogInTxt;
        private System.Windows.Forms.TextBox ParolTxt;
        private System.Windows.Forms.Button KirishBtn;
    }
}

