namespace Banksystem.forms
{
    partial class KontoUebersicht
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_transaction = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pan_Accounts = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Silver;
            this.btn_logout.Location = new System.Drawing.Point(686, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(102, 37);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_transaction
            // 
            this.btn_transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaction.ForeColor = System.Drawing.Color.Silver;
            this.btn_transaction.Location = new System.Drawing.Point(12, 12);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(131, 37);
            this.btn_transaction.TabIndex = 2;
            this.btn_transaction.Text = "Transaction";
            this.btn_transaction.UseVisualStyleBackColor = false;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Silver;
            this.lbl_username.Location = new System.Drawing.Point(12, 95);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(125, 29);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Accounts:";
            // 
            // pan_Accounts
            // 
            this.pan_Accounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Accounts.Location = new System.Drawing.Point(12, 127);
            this.pan_Accounts.Name = "pan_Accounts";
            this.pan_Accounts.Size = new System.Drawing.Size(776, 311);
            this.pan_Accounts.TabIndex = 4;
            // 
            // KontoUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_Accounts);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_transaction);
            this.Controls.Add(this.btn_logout);
            this.Name = "KontoUebersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KontoUebersicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KontoÜbersicht_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel pan_Accounts;
    }
}