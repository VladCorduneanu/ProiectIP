namespace NView
{
    partial class Login
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.groupBoxSingUp = new System.Windows.Forms.GroupBox();
            this.textBoxSignUpConfirm = new System.Windows.Forms.TextBox();
            this.labelSignUpConfirm = new System.Windows.Forms.Label();
            this.labelSignUpPassword = new System.Windows.Forms.Label();
            this.labelSignUpUsername = new System.Windows.Forms.Label();
            this.buttonSignUpBack = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBoxSignUpPassword = new System.Windows.Forms.TextBox();
            this.textBoxSignUpUsername = new System.Windows.Forms.TextBox();
            this.buttonSingUpLogIn = new System.Windows.Forms.Button();
            this.groupBoxLogIn.SuspendLayout();
            this.groupBoxSingUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(490, 198);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(128, 23);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(490, 298);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(128, 23);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(484, 154);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(147, 31);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(484, 243);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(142, 31);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(448, 351);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(198, 47);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxLogIn.Controls.Add(this.groupBoxSingUp);
            this.groupBoxLogIn.Controls.Add(this.buttonSingUpLogIn);
            this.groupBoxLogIn.Controls.Add(this.buttonLogin);
            this.groupBoxLogIn.Controls.Add(this.textBoxUsername);
            this.groupBoxLogIn.Controls.Add(this.labelPassword);
            this.groupBoxLogIn.Controls.Add(this.textBoxPassword);
            this.groupBoxLogIn.Controls.Add(this.labelUsername);
            this.groupBoxLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.groupBoxLogIn.Location = new System.Drawing.Point(-38, -6);
            this.groupBoxLogIn.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Size = new System.Drawing.Size(1205, 626);
            this.groupBoxLogIn.TabIndex = 5;
            this.groupBoxLogIn.TabStop = false;
            this.groupBoxLogIn.Enter += new System.EventHandler(this.groupBoxLogIn_Enter);
            // 
            // groupBoxSingUp
            // 
            this.groupBoxSingUp.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSingUp.Controls.Add(this.textBoxSignUpConfirm);
            this.groupBoxSingUp.Controls.Add(this.labelSignUpConfirm);
            this.groupBoxSingUp.Controls.Add(this.labelSignUpPassword);
            this.groupBoxSingUp.Controls.Add(this.labelSignUpUsername);
            this.groupBoxSingUp.Controls.Add(this.buttonSignUpBack);
            this.groupBoxSingUp.Controls.Add(this.buttonSignUp);
            this.groupBoxSingUp.Controls.Add(this.textBoxSignUpPassword);
            this.groupBoxSingUp.Controls.Add(this.textBoxSignUpUsername);
            this.groupBoxSingUp.Location = new System.Drawing.Point(6, -21);
            this.groupBoxSingUp.Name = "groupBoxSingUp";
            this.groupBoxSingUp.Size = new System.Drawing.Size(1176, 696);
            this.groupBoxSingUp.TabIndex = 6;
            this.groupBoxSingUp.TabStop = false;
            this.groupBoxSingUp.Enter += new System.EventHandler(this.groupBoxSingUp_Enter);
            // 
            // textBoxSignUpConfirm
            // 
            this.textBoxSignUpConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignUpConfirm.Location = new System.Drawing.Point(507, 410);
            this.textBoxSignUpConfirm.Name = "textBoxSignUpConfirm";
            this.textBoxSignUpConfirm.Size = new System.Drawing.Size(128, 23);
            this.textBoxSignUpConfirm.TabIndex = 8;
            // 
            // labelSignUpConfirm
            // 
            this.labelSignUpConfirm.AutoSize = true;
            this.labelSignUpConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpConfirm.Location = new System.Drawing.Point(501, 355);
            this.labelSignUpConfirm.Name = "labelSignUpConfirm";
            this.labelSignUpConfirm.Size = new System.Drawing.Size(109, 31);
            this.labelSignUpConfirm.TabIndex = 7;
            this.labelSignUpConfirm.Text = "Confirm";
            // 
            // labelSignUpPassword
            // 
            this.labelSignUpPassword.AutoSize = true;
            this.labelSignUpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpPassword.Location = new System.Drawing.Point(501, 249);
            this.labelSignUpPassword.Name = "labelSignUpPassword";
            this.labelSignUpPassword.Size = new System.Drawing.Size(134, 31);
            this.labelSignUpPassword.TabIndex = 6;
            this.labelSignUpPassword.Text = "Password";
            // 
            // labelSignUpUsername
            // 
            this.labelSignUpUsername.AutoSize = true;
            this.labelSignUpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpUsername.Location = new System.Drawing.Point(501, 142);
            this.labelSignUpUsername.Name = "labelSignUpUsername";
            this.labelSignUpUsername.Size = new System.Drawing.Size(139, 31);
            this.labelSignUpUsername.TabIndex = 5;
            this.labelSignUpUsername.Text = "Username";
            // 
            // buttonSignUpBack
            // 
            this.buttonSignUpBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSignUpBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignUpBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSignUpBack.Location = new System.Drawing.Point(71, 71);
            this.buttonSignUpBack.Name = "buttonSignUpBack";
            this.buttonSignUpBack.Size = new System.Drawing.Size(122, 37);
            this.buttonSignUpBack.TabIndex = 4;
            this.buttonSignUpBack.Text = "Back";
            this.buttonSignUpBack.UseVisualStyleBackColor = false;
            this.buttonSignUpBack.Click += new System.EventHandler(this.buttonSignUpBack_Click);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSignUp.Location = new System.Drawing.Point(470, 466);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(198, 47);
            this.buttonSignUp.TabIndex = 3;
            this.buttonSignUp.Text = "Sing Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // textBoxSignUpPassword
            // 
            this.textBoxSignUpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignUpPassword.Location = new System.Drawing.Point(507, 306);
            this.textBoxSignUpPassword.Name = "textBoxSignUpPassword";
            this.textBoxSignUpPassword.Size = new System.Drawing.Size(128, 23);
            this.textBoxSignUpPassword.TabIndex = 1;
            // 
            // textBoxSignUpUsername
            // 
            this.textBoxSignUpUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSignUpUsername.Location = new System.Drawing.Point(507, 199);
            this.textBoxSignUpUsername.Name = "textBoxSignUpUsername";
            this.textBoxSignUpUsername.Size = new System.Drawing.Size(128, 23);
            this.textBoxSignUpUsername.TabIndex = 0;
            // 
            // buttonSingUpLogIn
            // 
            this.buttonSingUpLogIn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSingUpLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSingUpLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSingUpLogIn.Location = new System.Drawing.Point(934, 19);
            this.buttonSingUpLogIn.Name = "buttonSingUpLogIn";
            this.buttonSingUpLogIn.Size = new System.Drawing.Size(122, 37);
            this.buttonSingUpLogIn.TabIndex = 5;
            this.buttonSingUpLogIn.Text = "Sing Up";
            this.buttonSingUpLogIn.UseVisualStyleBackColor = false;
            this.buttonSingUpLogIn.Click += new System.EventHandler(this.buttonSingUpLogIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources.Login_image;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.groupBoxLogIn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogIn.PerformLayout();
            this.groupBoxSingUp.ResumeLayout(false);
            this.groupBoxSingUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBoxLogIn;
        private System.Windows.Forms.Button buttonSingUpLogIn;
        private System.Windows.Forms.GroupBox groupBoxSingUp;
        private System.Windows.Forms.TextBox textBoxSignUpPassword;
        private System.Windows.Forms.TextBox textBoxSignUpUsername;
        private System.Windows.Forms.Button buttonSignUpBack;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label labelSignUpPassword;
        private System.Windows.Forms.Label labelSignUpUsername;
        private System.Windows.Forms.TextBox textBoxSignUpConfirm;
        private System.Windows.Forms.Label labelSignUpConfirm;
    }
}