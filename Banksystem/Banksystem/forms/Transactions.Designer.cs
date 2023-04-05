namespace Banksystem.forms
{
    partial class Transactions
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
            this.combo_Accounts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_YIBAN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Riban = new System.Windows.Forms.TextBox();
            this.btn_transaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_Accounts
            // 
            this.combo_Accounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.combo_Accounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Accounts.ForeColor = System.Drawing.Color.Silver;
            this.combo_Accounts.FormattingEnabled = true;
            this.combo_Accounts.Location = new System.Drawing.Point(17, 37);
            this.combo_Accounts.Name = "combo_Accounts";
            this.combo_Accounts.Size = new System.Drawing.Size(257, 21);
            this.combo_Accounts.TabIndex = 0;
            this.combo_Accounts.SelectedIndexChanged += new System.EventHandler(this.combo_Accounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Account:";
            // 
            // txt_YIBAN
            // 
            this.txt_YIBAN.BackColor = System.Drawing.Color.Gray;
            this.txt_YIBAN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_YIBAN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_YIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_YIBAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_YIBAN.Location = new System.Drawing.Point(17, 87);
            this.txt_YIBAN.Name = "txt_YIBAN";
            this.txt_YIBAN.ReadOnly = true;
            this.txt_YIBAN.Size = new System.Drawing.Size(252, 22);
            this.txt_YIBAN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your IBAN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recipients IBAN:";
            // 
            // txt_Riban
            // 
            this.txt_Riban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Riban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Riban.ForeColor = System.Drawing.Color.Silver;
            this.txt_Riban.Location = new System.Drawing.Point(17, 140);
            this.txt_Riban.Name = "txt_Riban";
            this.txt_Riban.Size = new System.Drawing.Size(252, 20);
            this.txt_Riban.TabIndex = 4;
            // 
            // btn_transaction
            // 
            this.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaction.Location = new System.Drawing.Point(17, 167);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(252, 34);
            this.btn_transaction.TabIndex = 6;
            this.btn_transaction.Text = "Make Transaction";
            this.btn_transaction.UseVisualStyleBackColor = true;
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(287, 218);
            this.Controls.Add(this.btn_transaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Riban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_YIBAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Accounts);
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Accounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_YIBAN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Riban;
        private System.Windows.Forms.Button btn_transaction;
    }
}