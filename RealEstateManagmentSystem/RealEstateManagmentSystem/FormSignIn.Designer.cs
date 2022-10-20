namespace RealEstateManagmentSystem
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.btnSingUp = new System.Windows.Forms.Button();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSingUp
            // 
            this.btnSingUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btnSingUp.FlatAppearance.BorderSize = 0;
            this.btnSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSingUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnSingUp.Location = new System.Drawing.Point(404, 339);
            this.btnSingUp.Name = "btnSingUp";
            this.btnSingUp.Size = new System.Drawing.Size(111, 38);
            this.btnSingUp.TabIndex = 17;
            this.btnSingUp.Text = "Sign Up";
            this.btnSingUp.UseVisualStyleBackColor = false;
            this.btnSingUp.Click += new System.EventHandler(this.btnSingUp_Click);
            // 
            // btnSingIn
            // 
            this.btnSingIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btnSingIn.FlatAppearance.BorderSize = 0;
            this.btnSingIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSingIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnSingIn.Location = new System.Drawing.Point(285, 339);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(111, 38);
            this.btnSingIn.TabIndex = 16;
            this.btnSingIn.Text = "Sign In";
            this.btnSingIn.UseVisualStyleBackColor = false;
            this.btnSingIn.Click += new System.EventHandler(this.btnSingIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxPassword.Location = new System.Drawing.Point(285, 293);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(230, 23);
            this.textBoxPassword.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(354, 252);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxEmail.Location = new System.Drawing.Point(285, 212);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(230, 23);
            this.textBoxEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmail.Location = new System.Drawing.Point(373, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // pictureBoxAccount
            // 
            this.pictureBoxAccount.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccount.Image")));
            this.pictureBoxAccount.Location = new System.Drawing.Point(354, 72);
            this.pictureBoxAccount.Name = "pictureBoxAccount";
            this.pictureBoxAccount.Size = new System.Drawing.Size(92, 92);
            this.pictureBoxAccount.TabIndex = 11;
            this.pictureBoxAccount.TabStop = false;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.panelTopBar.Controls.Add(this.btnClose);
            this.panelTopBar.Controls.Add(this.lblTitle);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(800, 43);
            this.panelTopBar.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(754, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.lblTitle.Location = new System.Drawing.Point(351, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Log In";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.btnSingUp);
            this.Controls.Add(this.btnSingIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pictureBoxAccount);
            this.Name = "FormSignIn";
            this.Text = "FormSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSingUp;
        private System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pictureBoxAccount;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}