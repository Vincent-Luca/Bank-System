namespace Banksystem.forms
{
    partial class KontoÜbersicht
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_transactions = new System.Windows.Forms.DataGridView();
            this.Column_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_transactions
            // 
            this.dgv_transactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_transactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_username,
            this.Column_Amount,
            this.Column_date});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_transactions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_transactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_transactions.Location = new System.Drawing.Point(12, 235);
            this.dgv_transactions.Name = "dgv_transactions";
            this.dgv_transactions.Size = new System.Drawing.Size(776, 203);
            this.dgv_transactions.TabIndex = 0;
            // 
            // Column_username
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            this.Column_username.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_username.HeaderText = "From User";
            this.Column_username.Name = "Column_username";
            this.Column_username.ReadOnly = true;
            this.Column_username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_Amount
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column_Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_Amount.HeaderText = "Amount";
            this.Column_Amount.Name = "Column_Amount";
            this.Column_Amount.ReadOnly = true;
            this.Column_Amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column_date
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column_date.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column_date.HeaderText = "Date";
            this.Column_date.Name = "Column_date";
            this.Column_date.ReadOnly = true;
            this.Column_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KontoÜbersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_transactions);
            this.Name = "KontoÜbersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KontoÜbersicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KontoÜbersicht_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_date;
    }
}