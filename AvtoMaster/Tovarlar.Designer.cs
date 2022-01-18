
namespace AvtoMaster
{
    partial class Tovarlar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TovarlarDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TovarlarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).BeginInit();
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
            this.addBtn.Size = new System.Drawing.Size(56, 58);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1063, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tovarlar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.TovarlarDataGridView);
            this.panel1.Location = new System.Drawing.Point(1, 86);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1283, 719);
            this.panel1.TabIndex = 2;
            // 
            // TovarlarDataGridView
            // 
            this.TovarlarDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TovarlarDataGridView.AutoGenerateColumns = false;
            this.TovarlarDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.TovarlarDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.TovarlarDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.TovarlarDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TovarlarDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TovarlarDataGridView.ColumnHeadersHeight = 50;
            this.TovarlarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TovarlarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomiDataGridViewTextBoxColumn,
            this.turiDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.DeleteBtn});
            this.TovarlarDataGridView.DataSource = this.tovarBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TovarlarDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TovarlarDataGridView.Location = new System.Drawing.Point(6, 6);
            this.TovarlarDataGridView.Name = "TovarlarDataGridView";
            this.TovarlarDataGridView.ReadOnly = true;
            this.TovarlarDataGridView.RowHeadersWidth = 51;
            this.TovarlarDataGridView.RowTemplate.Height = 24;
            this.TovarlarDataGridView.Size = new System.Drawing.Size(1271, 707);
            this.TovarlarDataGridView.TabIndex = 0;
            this.TovarlarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TovarlarDataGridView_CellContentClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DataPropertyName = "delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteBtn.HeaderText = "O\'chirish";
            this.DeleteBtn.MinimumWidth = 6;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ReadOnly = true;
            this.DeleteBtn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 35;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomiDataGridViewTextBoxColumn
            // 
            this.nomiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomiDataGridViewTextBoxColumn.DataPropertyName = "Nomi";
            this.nomiDataGridViewTextBoxColumn.HeaderText = "Nomi";
            this.nomiDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.nomiDataGridViewTextBoxColumn.Name = "nomiDataGridViewTextBoxColumn";
            this.nomiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // turiDataGridViewTextBoxColumn
            // 
            this.turiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.turiDataGridViewTextBoxColumn.DataPropertyName = "Turi";
            this.turiDataGridViewTextBoxColumn.HeaderText = "Turi";
            this.turiDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.turiDataGridViewTextBoxColumn.Name = "turiDataGridViewTextBoxColumn";
            this.turiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "Km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Km";
            this.kmDataGridViewTextBoxColumn.MinimumWidth = 45;
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            this.kmDataGridViewTextBoxColumn.ReadOnly = true;
            this.kmDataGridViewTextBoxColumn.Width = 150;
            // 
            // tovarBindingSource1
            // 
            this.tovarBindingSource1.DataSource = typeof(AvtoMaster.Yordamchi.Tovar);
            // 
            // Tovarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 805);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Tovarlar";
            this.Text = "Tovarlar";
            this.Load += new System.EventHandler(this.Tovarlar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TovarlarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TovarlarDataGridView;
        private System.Windows.Forms.BindingSource tovarBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
    }
}