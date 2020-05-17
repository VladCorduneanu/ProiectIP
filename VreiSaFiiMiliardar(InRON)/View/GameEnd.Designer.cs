namespace View
{
    partial class GameEnd
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
            this.labelFinal = new System.Windows.Forms.Label();
            this.labelVirgil = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFinal
            // 
            this.labelFinal.BackColor = System.Drawing.Color.Transparent;
            this.labelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFinal.Location = new System.Drawing.Point(784, 226);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(211, 302);
            this.labelFinal.TabIndex = 0;
            this.labelFinal.Text = "label1";
            this.labelFinal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVirgil
            // 
            this.labelVirgil.BackColor = System.Drawing.Color.Transparent;
            this.labelVirgil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVirgil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVirgil.Location = new System.Drawing.Point(295, 62);
            this.labelVirgil.Name = "labelVirgil";
            this.labelVirgil.Size = new System.Drawing.Size(152, 111);
            this.labelVirgil.TabIndex = 1;
            this.labelVirgil.Text = "labelVirgil";
            this.labelVirgil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMenu.Location = new System.Drawing.Point(789, 547);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(206, 42);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // GameEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::View.Properties.Resources.start_game_iamge;
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelVirgil);
            this.Controls.Add(this.labelFinal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 640);
            this.MinimumSize = new System.Drawing.Size(1080, 640);
            this.Name = "GameEnd";
            this.Text = "GameEnd";
            this.Load += new System.EventHandler(this.GameEnd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Label labelVirgil;
        private System.Windows.Forms.Button buttonMenu;
    }
}