namespace pos_system.PL
{
    partial class login_form
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
            this.login_btn = new System.Windows.Forms.Button();
            this.users_list = new System.Windows.Forms.ListBox();
            this.pwd_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancel_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(65, 80);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "تسجيل الدخول";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // users_list
            // 
            this.users_list.FormattingEnabled = true;
            this.users_list.Location = new System.Drawing.Point(301, 42);
            this.users_list.Name = "users_list";
            this.users_list.Size = new System.Drawing.Size(120, 95);
            this.users_list.TabIndex = 1;
            this.users_list.SelectedIndexChanged += new System.EventHandler(this.users_list_SelectedIndexChanged);
            // 
            // pwd_txt
            // 
            this.pwd_txt.Location = new System.Drawing.Point(301, 177);
            this.pwd_txt.Name = "pwd_txt";
            this.pwd_txt.PasswordChar = '*';
            this.pwd_txt.Size = new System.Drawing.Size(120, 20);
            this.pwd_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "كلمه السر";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "اختر المستخدم";
            // 
            // cancel_login
            // 
            this.cancel_login.Location = new System.Drawing.Point(12, 191);
            this.cancel_login.Name = "cancel_login";
            this.cancel_login.Size = new System.Drawing.Size(75, 23);
            this.cancel_login.TabIndex = 5;
            this.cancel_login.Text = "الخروج";
            this.cancel_login.UseVisualStyleBackColor = true;
            this.cancel_login.Click += new System.EventHandler(this.cancel_login_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 226);
            this.Controls.Add(this.cancel_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwd_txt);
            this.Controls.Add(this.users_list);
            this.Controls.Add(this.login_btn);
            this.Name = "login_form";
            this.Text = "login_form";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.ListBox users_list;
        private System.Windows.Forms.TextBox pwd_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancel_login;
    }
}