namespace Banksystem.forms
{
    partial class NewAccount
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.lbl_confirmpin = new System.Windows.Forms.Label();
            this.txt_confirmpin = new System.Windows.Forms.TextBox();
            this.btn_createnewaccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Silver;
            this.txt_username.Location = new System.Drawing.Point(12, 47);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(188, 24);
            this.txt_username.TabIndex = 0;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Silver;
            this.lbl_username.Location = new System.Drawing.Point(12, 20);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(111, 24);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pin.ForeColor = System.Drawing.Color.Silver;
            this.lbl_pin.Location = new System.Drawing.Point(12, 74);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(46, 24);
            this.lbl_pin.TabIndex = 3;
            this.lbl_pin.Text = "Pin:";
            // 
            // txt_pin
            // 
            this.txt_pin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pin.ForeColor = System.Drawing.Color.Silver;
            this.txt_pin.Location = new System.Drawing.Point(12, 101);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(188, 24);
            this.txt_pin.TabIndex = 2;
            this.txt_pin.UseSystemPasswordChar = true;
            // 
            // lbl_confirmpin
            // 
            this.lbl_confirmpin.AutoSize = true;
            this.lbl_confirmpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_confirmpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmpin.ForeColor = System.Drawing.Color.Silver;
            this.lbl_confirmpin.Location = new System.Drawing.Point(12, 128);
            this.lbl_confirmpin.Name = "lbl_confirmpin";
            this.lbl_confirmpin.Size = new System.Drawing.Size(124, 24);
            this.lbl_confirmpin.TabIndex = 5;
            this.lbl_confirmpin.Text = "Confirm Pin:";
            // 
            // txt_confirmpin
            // 
            this.txt_confirmpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_confirmpin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirmpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmpin.ForeColor = System.Drawing.Color.Silver;
            this.txt_confirmpin.Location = new System.Drawing.Point(12, 155);
            this.txt_confirmpin.Name = "txt_confirmpin";
            this.txt_confirmpin.Size = new System.Drawing.Size(188, 24);
            this.txt_confirmpin.TabIndex = 4;
            this.txt_confirmpin.UseSystemPasswordChar = true;
            // 
            // btn_createnewaccount
            // 
            this.btn_createnewaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_createnewaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createnewaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createnewaccount.ForeColor = System.Drawing.Color.Silver;
            this.btn_createnewaccount.Location = new System.Drawing.Point(12, 225);
            this.btn_createnewaccount.Name = "btn_createnewaccount";
            this.btn_createnewaccount.Size = new System.Drawing.Size(188, 58);
            this.btn_createnewaccount.TabIndex = 7;
            this.btn_createnewaccount.Text = "Create New Account";
            this.btn_createnewaccount.UseVisualStyleBackColor = false;
            this.btn_createnewaccount.Click += new System.EventHandler(this.btn_createnewaccount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(12, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show pin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(217, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_createnewaccount);
            this.Controls.Add(this.lbl_confirmpin);
            this.Controls.Add(this.txt_confirmpin);
            this.Controls.Add(this.lbl_pin);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.MaximumSize = new System.Drawing.Size(233, 335);
            this.MinimumSize = new System.Drawing.Size(233, 335);
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.Label lbl_confirmpin;
        private System.Windows.Forms.TextBox txt_confirmpin;
        private System.Windows.Forms.Button btn_createnewaccount;
        private System.Windows.Forms.Button button1;
    }
}