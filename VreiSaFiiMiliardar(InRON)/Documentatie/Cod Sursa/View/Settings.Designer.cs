namespace View
{
    partial class Settings
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
            this.buttonResetScore = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBoxSchimbaParola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonResetScore
            // 
            this.buttonResetScore.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonResetScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonResetScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResetScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonResetScore.Location = new System.Drawing.Point(112, 77);
            this.buttonResetScore.Name = "buttonResetScore";
            this.buttonResetScore.Size = new System.Drawing.Size(211, 42);
            this.buttonResetScore.TabIndex = 0;
            this.buttonResetScore.Text = "Reset Score";
            this.buttonResetScore.UseVisualStyleBackColor = false;
            this.buttonResetScore.Click += new System.EventHandler(this.buttonResetScore_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonChangePassword.Location = new System.Drawing.Point(112, 210);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(211, 42);
            this.buttonChangePassword.TabIndex = 1;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeleteAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteAccount.Location = new System.Drawing.Point(112, 141);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(211, 42);
            this.buttonDeleteAccount.TabIndex = 2;
            this.buttonDeleteAccount.Text = "Delete Account";
            this.buttonDeleteAccount.UseVisualStyleBackColor = false;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Location = new System.Drawing.Point(112, 492);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(211, 42);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxSchimbaParola
            // 
            this.textBoxSchimbaParola.Location = new System.Drawing.Point(112, 270);
            this.textBoxSchimbaParola.Name = "textBoxSchimbaParola";
            this.textBoxSchimbaParola.PasswordChar = '*';
            this.textBoxSchimbaParola.Size = new System.Drawing.Size(211, 20);
            this.textBoxSchimbaParola.TabIndex = 4;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources.menu_image;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.textBoxSchimbaParola);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDeleteAccount);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.buttonResetScore);
            this.MaximumSize = new System.Drawing.Size(1080, 640);
            this.MinimumSize = new System.Drawing.Size(1080, 640);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResetScore;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonDeleteAccount;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBoxSchimbaParola;
    }
}