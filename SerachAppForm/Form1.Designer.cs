namespace SerachAppForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.grpPrice = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.grpPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(173, 41);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(343, 213);
            this.dgvData.TabIndex = 0;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(12, 41);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(155, 21);
            this.cmbName.TabIndex = 2;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(12, 168);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(149, 20);
            this.txtWord.TabIndex = 3;
            this.txtWord.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(11, 42);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(39, 20);
            this.txtMin.TabIndex = 4;
            this.txtMin.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(110, 42);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(39, 20);
            this.txtMax.TabIndex = 5;
            this.txtMax.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpPrice
            // 
            this.grpPrice.Controls.Add(this.label2);
            this.grpPrice.Controls.Add(this.label1);
            this.grpPrice.Controls.Add(this.txtMax);
            this.grpPrice.Controls.Add(this.txtMin);
            this.grpPrice.Location = new System.Drawing.Point(12, 68);
            this.grpPrice.Name = "grpPrice";
            this.grpPrice.Size = new System.Drawing.Size(155, 83);
            this.grpPrice.TabIndex = 6;
            this.grpPrice.TabStop = false;
            this.grpPrice.Text = "Search by Price";
            this.grpPrice.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 283);
            this.Controls.Add(this.grpPrice);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.grpPrice.ResumeLayout(false);
            this.grpPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.GroupBox grpPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

