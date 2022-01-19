namespace AvtoMaster
{
    partial class AddTovar
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
            this.nomiTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.turiTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kmTxtBox = new System.Windows.Forms.TextBox();
            this.yaratishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yangi tovar yaratish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(69, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tovar nomi:";
            // 
            // nomiTxtBox
            // 
            this.nomiTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomiTxtBox.Location = new System.Drawing.Point(73, 134);
            this.nomiTxtBox.Name = "nomiTxtBox";
            this.nomiTxtBox.Size = new System.Drawing.Size(628, 30);
            this.nomiTxtBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(69, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tovar turi:";
            // 
            // turiTxtBox
            // 
            this.turiTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turiTxtBox.Location = new System.Drawing.Point(73, 212);
            this.turiTxtBox.Name = "turiTxtBox";
            this.turiTxtBox.Size = new System.Drawing.Size(628, 30);
            this.turiTxtBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(69, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Necha KM masofa xizmat qilishi:";
            // 
            // kmTxtBox
            // 
            this.kmTxtBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmTxtBox.Location = new System.Drawing.Point(73, 294);
            this.kmTxtBox.Name = "kmTxtBox";
            this.kmTxtBox.Size = new System.Drawing.Size(628, 30);
            this.kmTxtBox.TabIndex = 6;
            // 
            // yaratishBtn
            // 
            this.yaratishBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.yaratishBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yaratishBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.yaratishBtn.Location = new System.Drawing.Point(247, 364);
            this.yaratishBtn.Name = "yaratishBtn";
            this.yaratishBtn.Size = new System.Drawing.Size(268, 36);
            this.yaratishBtn.TabIndex = 7;
            this.yaratishBtn.Text = "Yaratish";
            this.yaratishBtn.UseVisualStyleBackColor = false;
            this.yaratishBtn.Click += new System.EventHandler(this.yaratishBtn_Click);
            // 
            // AddTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.yaratishBtn);
            this.Controls.Add(this.kmTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.turiTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomiTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTovar";
            this.Text = "AddTovar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomiTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox turiTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kmTxtBox;
        private System.Windows.Forms.Button yaratishBtn;
    }
}