namespace RealEstateManagmentSystem
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelNameInput = new System.Windows.Forms.Panel();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelPhoneInput = new System.Windows.Forms.Panel();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelEmailInput = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.panelAddressInput = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panelPasswordInput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmPaasword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.panelTopBar.SuspendLayout();
            this.panelNameInput.SuspendLayout();
            this.panelPhoneInput.SuspendLayout();
            this.panelEmailInput.SuspendLayout();
            this.panelAddressInput.SuspendLayout();
            this.panelPasswordInput.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTopBar.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(755, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.lblTitle.Location = new System.Drawing.Point(326, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sign Up";
            // 
            // panelNameInput
            // 
            this.panelNameInput.Controls.Add(this.textBoxLastName);
            this.panelNameInput.Controls.Add(this.textBoxFirstName);
            this.panelNameInput.Controls.Add(this.lblName);
            this.panelNameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNameInput.Location = new System.Drawing.Point(0, 43);
            this.panelNameInput.Name = "panelNameInput";
            this.panelNameInput.Size = new System.Drawing.Size(800, 80);
            this.panelNameInput.TabIndex = 20;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxLastName.Location = new System.Drawing.Point(332, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(170, 22);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxFirstName.Location = new System.Drawing.Point(332, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(170, 22);
            this.textBoxFirstName.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblName.Location = new System.Drawing.Point(166, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // panelPhoneInput
            // 
            this.panelPhoneInput.Controls.Add(this.textBoxPhone);
            this.panelPhoneInput.Controls.Add(this.lblPhone);
            this.panelPhoneInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhoneInput.Location = new System.Drawing.Point(0, 123);
            this.panelPhoneInput.Name = "panelPhoneInput";
            this.panelPhoneInput.Size = new System.Drawing.Size(800, 40);
            this.panelPhoneInput.TabIndex = 23;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxPhone.Location = new System.Drawing.Point(332, 8);
            this.textBoxPhone.Mask = "\\+\\2\\5\\1 000 000 000";
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(170, 22);
            this.textBoxPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPhone.Location = new System.Drawing.Point(166, 7);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 24);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone";
            // 
            // panelEmailInput
            // 
            this.panelEmailInput.Controls.Add(this.lblAddress);
            this.panelEmailInput.Controls.Add(this.textBoxAddress);
            this.panelEmailInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmailInput.Location = new System.Drawing.Point(0, 163);
            this.panelEmailInput.Name = "panelEmailInput";
            this.panelEmailInput.Size = new System.Drawing.Size(800, 40);
            this.panelEmailInput.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAddress.Location = new System.Drawing.Point(166, 8);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxAddress.Location = new System.Drawing.Point(332, 8);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(170, 22);
            this.textBoxAddress.TabIndex = 6;
            // 
            // panelAddressInput
            // 
            this.panelAddressInput.Controls.Add(this.lblEmail);
            this.panelAddressInput.Controls.Add(this.textBoxEmail);
            this.panelAddressInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddressInput.Location = new System.Drawing.Point(0, 203);
            this.panelAddressInput.Name = "panelAddressInput";
            this.panelAddressInput.Size = new System.Drawing.Size(800, 40);
            this.panelAddressInput.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblEmail.Location = new System.Drawing.Point(166, 8);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(332, 8);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(170, 22);
            this.textBoxEmail.TabIndex = 10;
            // 
            // panelPasswordInput
            // 
            this.panelPasswordInput.Controls.Add(this.label1);
            this.panelPasswordInput.Controls.Add(this.textBoxConfirmPaasword);
            this.panelPasswordInput.Controls.Add(this.textBoxPassword);
            this.panelPasswordInput.Controls.Add(this.lblPassword);
            this.panelPasswordInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPasswordInput.Location = new System.Drawing.Point(0, 243);
            this.panelPasswordInput.Name = "panelPasswordInput";
            this.panelPasswordInput.Size = new System.Drawing.Size(800, 80);
            this.panelPasswordInput.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(166, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Confirm Password";
            // 
            // textBoxConfirmPaasword
            // 
            this.textBoxConfirmPaasword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmPaasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxConfirmPaasword.Location = new System.Drawing.Point(332, 45);
            this.textBoxConfirmPaasword.Name = "textBoxConfirmPaasword";
            this.textBoxConfirmPaasword.PasswordChar = '*';
            this.textBoxConfirmPaasword.Size = new System.Drawing.Size(170, 22);
            this.textBoxConfirmPaasword.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(332, 10);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(170, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblPassword.Location = new System.Drawing.Point(166, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(104)))), ((int)(((byte)(254)))));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.btnSignUp.Location = new System.Drawing.Point(284, 371);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(140, 40);
            this.btnSignUp.TabIndex = 27;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.panelPasswordInput);
            this.Controls.Add(this.panelAddressInput);
            this.Controls.Add(this.panelEmailInput);
            this.Controls.Add(this.panelPhoneInput);
            this.Controls.Add(this.panelNameInput);
            this.Controls.Add(this.panelTopBar);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelNameInput.ResumeLayout(false);
            this.panelNameInput.PerformLayout();
            this.panelPhoneInput.ResumeLayout(false);
            this.panelPhoneInput.PerformLayout();
            this.panelEmailInput.ResumeLayout(false);
            this.panelEmailInput.PerformLayout();
            this.panelAddressInput.ResumeLayout(false);
            this.panelAddressInput.PerformLayout();
            this.panelPasswordInput.ResumeLayout(false);
            this.panelPasswordInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNameInput;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelPhoneInput;
        private System.Windows.Forms.MaskedTextBox textBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Panel panelEmailInput;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Panel panelAddressInput;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panelPasswordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmPaasword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSignUp;
    }
}