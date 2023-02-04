namespace Banksystem
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.rb_rememberme = new System.Windows.Forms.RadioButton();
            this.btn_newaccount = new System.Windows.Forms.Button();
            this.btn_showpin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Silver;
            this.txt_username.Location = new System.Drawing.Point(13, 32);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(177, 22);
            this.txt_username.TabIndex = 0;
            // 
            // txt_pin
            // 
            this.txt_pin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pin.ForeColor = System.Drawing.Color.Silver;
            this.txt_pin.Location = new System.Drawing.Point(13, 83);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(177, 22);
            this.txt_pin.TabIndex = 1;
            this.txt_pin.UseSystemPasswordChar = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Silver;
            this.lbl_username.Location = new System.Drawing.Point(12, 9);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(96, 20);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_pin.Location = new System.Drawing.Point(12, 60);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(43, 20);
            this.lbl_pin.TabIndex = 3;
            this.lbl_pin.Text = "PIN:";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Silver;
            this.btn_login.Location = new System.Drawing.Point(11, 164);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(177, 51);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // rb_rememberme
            // 
            this.rb_rememberme.AutoSize = true;
            this.rb_rememberme.ForeColor = System.Drawing.Color.Silver;
            this.rb_rememberme.Location = new System.Drawing.Point(12, 141);
            this.rb_rememberme.Name = "rb_rememberme";
            this.rb_rememberme.Size = new System.Drawing.Size(94, 17);
            this.rb_rememberme.TabIndex = 5;
            this.rb_rememberme.TabStop = true;
            this.rb_rememberme.Text = "Remember Me";
            this.rb_rememberme.UseVisualStyleBackColor = true;
            this.rb_rememberme.CheckedChanged += new System.EventHandler(this.rb_rememberme_CheckedChanged);
            // 
            // btn_newaccount
            // 
            this.btn_newaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_newaccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newaccount.ForeColor = System.Drawing.Color.Silver;
            this.btn_newaccount.Location = new System.Drawing.Point(11, 222);
            this.btn_newaccount.Name = "btn_newaccount";
            this.btn_newaccount.Size = new System.Drawing.Size(177, 32);
            this.btn_newaccount.TabIndex = 6;
            this.btn_newaccount.Text = "Create New account";
            this.btn_newaccount.UseVisualStyleBackColor = false;
            this.btn_newaccount.Click += new System.EventHandler(this.btn_newaccount_Click);
            // 
            // btn_showpin
            // 
            this.btn_showpin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_showpin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showpin.ForeColor = System.Drawing.Color.Silver;
            this.btn_showpin.Location = new System.Drawing.Point(13, 109);
            this.btn_showpin.Name = "btn_showpin";
            this.btn_showpin.Size = new System.Drawing.Size(80, 26);
            this.btn_showpin.TabIndex = 7;
            this.btn_showpin.Text = "Show Pin";
            this.btn_showpin.UseVisualStyleBackColor = false;
            this.btn_showpin.Click += new System.EventHandler(this.btn_showpin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(207, 264);
            this.Controls.Add(this.btn_showpin);
            this.Controls.Add(this.btn_newaccount);
            this.Controls.Add(this.rb_rememberme);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_pin);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.txt_username);
            this.MaximumSize = new System.Drawing.Size(223, 303);
            this.MinimumSize = new System.Drawing.Size(223, 303);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.RadioButton rb_rememberme;
        private System.Windows.Forms.Button btn_newaccount;
        private System.Windows.Forms.Button btn_showpin;
    }
}

