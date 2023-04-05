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
            this.btn_newacc = new System.Windows.Forms.Button();
            this.btn_CreateAcc = new System.Windows.Forms.Button();
            this.lbl_accname = new System.Windows.Forms.Label();
            this.txt_AccName = new System.Windows.Forms.TextBox();
            this.pan_newAccount = new System.Windows.Forms.Panel();
            this.pan_newAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.Silver;
            this.btn_logout.Location = new System.Drawing.Point(710, 12);
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
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
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
            this.pan_Accounts.AutoScroll = true;
            this.pan_Accounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Accounts.Location = new System.Drawing.Point(12, 127);
            this.pan_Accounts.Name = "pan_Accounts";
            this.pan_Accounts.Size = new System.Drawing.Size(800, 311);
            this.pan_Accounts.TabIndex = 4;
            // 
            // btn_newacc
            // 
            this.btn_newacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_newacc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newacc.ForeColor = System.Drawing.Color.Silver;
            this.btn_newacc.Location = new System.Drawing.Point(149, 12);
            this.btn_newacc.Name = "btn_newacc";
            this.btn_newacc.Size = new System.Drawing.Size(217, 37);
            this.btn_newacc.TabIndex = 5;
            this.btn_newacc.Text = "Open new Account";
            this.btn_newacc.UseVisualStyleBackColor = false;
            this.btn_newacc.Click += new System.EventHandler(this.btn_newacc_Click);
            // 
            // btn_CreateAcc
            // 
            this.btn_CreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAcc.ForeColor = System.Drawing.Color.Silver;
            this.btn_CreateAcc.Location = new System.Drawing.Point(3, 54);
            this.btn_CreateAcc.Name = "btn_CreateAcc";
            this.btn_CreateAcc.Size = new System.Drawing.Size(105, 26);
            this.btn_CreateAcc.TabIndex = 17;
            this.btn_CreateAcc.Text = "Create Account";
            this.btn_CreateAcc.UseVisualStyleBackColor = false;
            this.btn_CreateAcc.Click += new System.EventHandler(this.btn_CreateAcc_Click);
            // 
            // lbl_accname
            // 
            this.lbl_accname.AutoSize = true;
            this.lbl_accname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accname.ForeColor = System.Drawing.Color.Silver;
            this.lbl_accname.Location = new System.Drawing.Point(2, 3);
            this.lbl_accname.Name = "lbl_accname";
            this.lbl_accname.Size = new System.Drawing.Size(152, 20);
            this.lbl_accname.TabIndex = 16;
            this.lbl_accname.Text = "Name of Account:";
            // 
            // txt_AccName
            // 
            this.txt_AccName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_AccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AccName.ForeColor = System.Drawing.Color.Silver;
            this.txt_AccName.Location = new System.Drawing.Point(3, 26);
            this.txt_AccName.Name = "txt_AccName";
            this.txt_AccName.Size = new System.Drawing.Size(177, 22);
            this.txt_AccName.TabIndex = 15;
            // 
            // pan_newAccount
            // 
            this.pan_newAccount.Controls.Add(this.btn_CreateAcc);
            this.pan_newAccount.Controls.Add(this.lbl_accname);
            this.pan_newAccount.Controls.Add(this.txt_AccName);
            this.pan_newAccount.Location = new System.Drawing.Point(372, 12);
            this.pan_newAccount.Name = "pan_newAccount";
            this.pan_newAccount.Size = new System.Drawing.Size(200, 100);
            this.pan_newAccount.TabIndex = 18;
            this.pan_newAccount.Visible = false;
            // 
            // KontoUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.btn_newacc);
            this.Controls.Add(this.pan_Accounts);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_transaction);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pan_newAccount);
            this.Name = "KontoUebersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KontoUebersicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KontoÜbersicht_FormClosing);
            this.pan_newAccount.ResumeLayout(false);
            this.pan_newAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel pan_Accounts;
        private System.Windows.Forms.Button btn_newacc;
        private System.Windows.Forms.Button btn_CreateAcc;
        private System.Windows.Forms.Label lbl_accname;
        private System.Windows.Forms.TextBox txt_AccName;
        private System.Windows.Forms.Panel pan_newAccount;
    }
}